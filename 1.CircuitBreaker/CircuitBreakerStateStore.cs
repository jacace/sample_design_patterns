using System;

public class CircuitBreakerStateStore : ICircuitBreakerStateStore
{
    private CircuitBreakerStateEnum state = CircuitBreakerStateEnum.Closed;
    private Exception lastException = null;
    private DateTime lastStateChangedDateUtc = DateTime.MinValue;
    private bool isClosed = false;

    public CircuitBreakerStateEnum State
    {
        get
        {
            return this.state;
        }
    }

    public Exception LastException
    {
        get
        {
            return this.lastException;
        }
    }

    public DateTime LastStateChangedDateUtc
    {
        get
        {
            return this.lastStateChangedDateUtc;
        }
    }

    public bool IsClosed
    {
        get
        {
            return this.isClosed;
        }
    }

    public void HalfOpen()
    {
        this.state = CircuitBreakerStateEnum.HalfOpen;
    }

    public void Reset()
    {
        this.state = CircuitBreakerStateEnum.Closed;
        this.isClosed = true;
    }

    public void Trip(Exception ex)
    {
        this.state = CircuitBreakerStateEnum.Open;
        this.isClosed = false;
        this.lastStateChangedDateUtc = DateTime.UtcNow;
        this.lastException = ex;
    }

}