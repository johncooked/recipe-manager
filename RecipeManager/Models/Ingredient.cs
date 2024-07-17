namespace RecipeManager.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }    

        public double Quanity { get; set; }

        public string Unit { get; set; }

        public double Calories { get; set; }

        public List<Recipe> Recipes { get; set; }

        public Ingredient()
        {
            
        }
    }
}
