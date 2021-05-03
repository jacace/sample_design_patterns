public class CircuitBreakerStateStoreFactory
{
    public static ICircuitBreakerStateStore GetCircuitBreakerStateStore()
    {
        return new CircuitBreakerStateStore();
    }

}