using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipeManager.Models;

namespace RecipeManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RecipeManager.Models.Ingredient> Ingredient { get; set; } = default!;
        public DbSet<RecipeManager.Models.Recipe> Recipe { get; set; } = default!;
        public DbSet<RecipeManager.Models.MealPlan> MealPlan { get; set; } = default!;
    }
}
