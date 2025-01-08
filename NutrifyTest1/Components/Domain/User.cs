namespace NutrifyTest1.Components.Domain
{
    public class User
    {
        public int UserID { get; set; } // Primary Key
        public string? Age { get; set; }
        public bool? Gender { get; set; }
        public string? DietaryPreferences { get; set; }
        public string? HealthGoal { get; set; }
    }
}
