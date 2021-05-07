namespace sample_design_patterns
{
    public class KidsCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }

        public override Sandwich CreateSandwich()
        {
            return new GrilledCheese();
        }
    }
}