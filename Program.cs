using System;

namespace UberFareEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            int ride_time = 30;
            int ride_distance = 7;
            double[] cost_per_minute = { 0.2, 0.35, 0.4, 0.45 };
            double[] cost_per_mile = { 1.1, 1.8, 2.3, 3.5 };

            double[] estimatedFare = new double[cost_per_mile.Length];

            for (int i = 0; i < cost_per_mile.Length; i++)
            {
                CarData testCar = new CarData(cost_per_minute[i], cost_per_mile[i]);

                estimatedFare[i] = (ride_time * cost_per_minute[i]) + (ride_distance * cost_per_mile[i]);
            }

            Console.WriteLine(String.Join(" ", estimatedFare));
        }
    }
}
