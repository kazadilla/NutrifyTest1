namespace NutrifyTest1.Components.Domain
{
    public class EmotionLog
    {
        public int EmotionLogID { get; set; } // Primary Key
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Emotion { get; set; } //Sad, Stressed, Anxious, Irritable, Unmotivated, Overwhelmed, Other
        public int UserID { get; set; } // Foreign Key
        public int RecipeID { get; set; } // Foreign Key
    }
}
