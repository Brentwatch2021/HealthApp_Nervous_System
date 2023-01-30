using HealthApp.Data.Workout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;
using System.Linq;

namespace HealthApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkoutController : ControllerBase
    {
        private ILogger<WorkoutController> _logger;
        private Workout_Context _context;

        public WorkoutController(ILogger<WorkoutController> logger, Workout_Context context)
        {
            this._logger = logger;
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Workout> Get()
        {
            try
            {
                return this?._context?.Workouts;
            }
            catch (Exception ex)
            {
                this._logger.Log(LogLevel.Error, "There was an error connecting to the Database: ", ex);
            }

            return null;
        }

        [HttpPost]
        public void PostWorkout(Workout workout)
        {
            try
            {
                this?._context?.Add(workout);
                this?._context.SaveChanges();
            }
            catch (Exception ex)
            {
                this._logger.Log(LogLevel.Error, "There was an error connecting to the Database: ", ex);
            }
        }

    }
}
