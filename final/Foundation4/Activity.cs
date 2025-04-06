using System;

namespace ExerciseTracking
{
    // Base Activity class
    public abstract class Activity
    {
        public DateTime Date { get; set; }
        public int Duration { get; set; } // Duration in minutes

        public Activity(DateTime date, int duration)
        {
            Date = date;
            Duration = duration;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Duration} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
        }
    }
}