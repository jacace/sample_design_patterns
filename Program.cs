using System;

//dotnet new console

namespace sample_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-Sample of the CircuitBreaker Design Pattern
            CircuitBreaker objCircuit = new CircuitBreaker();
            objCircuit.ExecuteAction(null);

            //2-Sample of Template Method Design Pattern
            CommodityNodejsPipelineAsCode samplePipeline = new CommodityNodejsPipelineAsCode();
            samplePipeline.Run(null, null, null);
            Console.WriteLine("Sample call!");

            //3-Sample of Strategy Design Pattern
            CICDPipeline pipeline = new CICDPipeline(new CICDBuildStragey());
            pipeline.Build();

        }
    }
}
