using System;
using System.Threading;

public class CircuitBreaker
{
    private readonly ICircuitBreakerStateStore stateStore = 
      CircuitBreakerStateStoreFactory.GetCircuitBreakerStateStore();

    private readonly object halfOpenSyncObject = new object();

    public bool IsClosed { get { return stateStore.IsClosed; } }

    public bool IsOpen { get { return !IsClosed; } }

    public void ExecuteAction(Action action)
    {

        if (IsOpen)
        {
            // The circuit breaker is Open.
            DoOpenSteps(action);
        }
        else
        {
            // The circuit breaker is Closed, execute the action.
            try
            {
                action();
            }
            catch (Exception ex)
            {
                // If an exception still occurs here, simply 
                // retrip the breaker immediately.
                this.TrackException(ex);
                throw;
            }
        }


    }

    private void TrackException(Exception ex)
    {
        // For simplicity in this example, open the circuit breaker on the first exception.
        this.stateStore.Trip(ex);
    }

    private void DoOpenSteps(Action action)
    {
        // The circuit breaker is Open. Check if the Open timeout has expired.
        if (stateStore.LastStateChangedDateUtc  < DateTime.UtcNow)
        {
            // The Open timeout has expired. Allow one operation to execute. Note that, in            
            bool lockTaken = false;
            try
            {
                Monitor.TryEnter(halfOpenSyncObject, ref lockTaken);
                if (lockTaken)
                {
                    // Set the circuit breaker state to HalfOpen.
                    stateStore.HalfOpen();

                    // Attempt the operation.
                    action();

                    // If this action succeeds, reset the state and allow other operations.
                    this.stateStore.Reset();
                    return;
                }
            }
            catch (Exception ex)
            {
                // If there's still an exception, trip the breaker again immediately.
                this.stateStore.Trip(ex);
                throw;
            }
            finally
            {
                if (lockTaken)
                {
                    Monitor.Exit(halfOpenSyncObject);
                }
            }
        }
        // The Open timeout hasn't yet expired. Throw a CircuitBreakerOpen exception 
        throw stateStore.LastException;
    }

}