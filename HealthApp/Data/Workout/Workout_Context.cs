using Microsoft.EntityFrameworkCore;

namespace HealthApp.Data.Workout
{
    public class Workout_Context : DbContext
    {
        public Workout_Context(DbContextOptions<Workout_Context> options) : base(options)
        {
        }
        public DbSet<Workout> Workouts { get; set; }
    }
}
