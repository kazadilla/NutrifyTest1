namespace NutrifyTest1.Components.Domain
{
    public class Goal
    {
        public int GoalID { get; set; } // Primary Key
        public string? GoalType { get; set; }  // WeightLoss, MuscleGain, Endurance, GeneralFitness
        public DateOnly TargetDate { get; set; }
        public string? TargetCalories { get; set; }
        public int UserID { get; set; } // Foreign Key
    }
}

