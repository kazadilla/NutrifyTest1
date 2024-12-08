namespace NutrifyTest1.Components.Domain
{
    public class User
    {
        public int UserID { get; set; } // Primary Key
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Age { get; set; }
        public bool? Gender { get; set; }
        public string? DietaryPreferences { get; set; }
        public string? HealthGoal { get; set; }
    }
}
