using System.ComponentModel.DataAnnotations;

namespace HealthApp.Data.Workout
{
    public class Workout
    {
        [Key]
        public int Workout_ID { get; set; }

        public int Workout_Time { get; set; }

        public string Workout_Activity { get; set; }
    }
}
