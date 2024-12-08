namespace NutrifyTest1.Components.Domain
{
    public class MealPlan
    {
        public int MealPlanID { get; set; } // Primary Key
        public string Name { get; set; }
        public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Today); 
        public DateOnly EndDate { get; set; }
        public int DailyCalorieGoal { get; set; }
        public int UserID { get; set; } // Foreign Key
    }
}

