using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NutrifyTest1.Components.Domain;

namespace NutrifyTest1.Data
{
    public class NutrifyTest1Context : DbContext
    {
        public NutrifyTest1Context (DbContextOptions<NutrifyTest1Context> options)
            : base(options)
        {
        }

        public DbSet<NutrifyTest1.Components.Domain.MealPlan> MealPlan { get; set; } = default!;
        public DbSet<NutrifyTest1.Components.Domain.EmotionLog> EmotionLog { get; set; } = default!;
        public DbSet<NutrifyTest1.Components.Domain.Food> Food { get; set; } = default!;
        public DbSet<NutrifyTest1.Components.Domain.Goal> Goal { get; set; } = default!;
        public DbSet<NutrifyTest1.Components.Domain.FoodLog> FoodLog { get; set; } = default!;
        public DbSet<NutrifyTest1.Components.Domain.UserProgress> UserProgress { get; set; } = default!;
        public DbSet<NutrifyTest1.Components.Domain.Recipe> Recipe { get; set; } = default!;
        public DbSet<NutrifyTest1.Components.Domain.User> User { get; set; } = default!;
    }
}
