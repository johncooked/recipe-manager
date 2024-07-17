using System.ComponentModel.DataAnnotations;

namespace RecipeManager.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }

        public string Instructions { get; set; }

        [Display(Name = "Total Calories")]
        public  double TotalCalories { get; set; }

        public Recipe()
        {
                
        }
    }
}
