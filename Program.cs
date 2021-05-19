using System;
using System.Collections;
using System.Collections.Generic;

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

            //4-Sample of State Pattern: the context in this case (BookingStateBase and implementations)
            //  refers to the state to perform state specific behaviour
            //  Booking just calls the state
            Booking booking = Booking.CreateNew("jacace");
            PendingState state = new PendingState();
            state.Accept(booking); //why not directly call booking.TransitionToState?

            //5-Abstract Factory
            RecipeFactory kitchenFactory = null;
            Console.WriteLine("Are you an (A) adult or (B) child?");
            char response = Console.ReadKey().KeyChar;
            switch (response)
            {
                case 'A':
                    kitchenFactory = new AdultCuisineFactory();
                    break;
                default:
                    kitchenFactory = new KidsCuisineFactory();
                    break;
            }

            //6-Factory Method
            CarFactory factory = new CarFactory();
            ICar objCar = factory.BuildCar(CarType.PorscheMacan);

            //7-Table driven method / Control table
            MonthWrapper objMonth=new MonthWrapper();
            string localizedMonthName=objMonth.getMonthName("ES", 1);
        }
    }

}
