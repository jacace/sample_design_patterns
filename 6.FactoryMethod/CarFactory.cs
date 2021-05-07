
namespace sample_design_patterns
{

    public class CarFactory
    {

        public ICar BuildCar(CarType type)
        {
            switch (type)
            {
                case CarType.BMW320:
                    return new BMW320();
                default:
                    return new PorscheMacan();
            }
        }
    }

}