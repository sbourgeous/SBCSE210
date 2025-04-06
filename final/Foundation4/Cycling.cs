using System;

namespace ExerciseTracking
{
    // Cycling class
    public class Cycling : Activity
    {
        public double Speed { get; set; } // Speed in mph

        public Cycling(DateTime date, int duration, double speed) : base(date, duration)
        {
            Speed = speed;
        }

        public override double GetDistance() => (Speed * Duration) / 60;

        public override double GetSpeed() => Speed;

        public override double GetPace() => 60 / Speed;
    }
}