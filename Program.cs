using System;

namespace UberFareEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            // test data
            int ride_time = 30;
            int ride_distance = 7;
            double[] cost_per_minute = { 0.2, 0.35, 0.4, 0.45 };
            double[] cost_per_mile = { 1.1, 1.8, 2.3, 3.5 };

            // create array to hold output data
            double[] estimatedFare = new double[cost_per_mile.Length];

            // loop through test data
            for (int i = 0; i < cost_per_mile.Length; i++)
            {
                // create instance of car object that takes test data arrays as input
                CarData testCar = new CarData(cost_per_minute[i], cost_per_mile[i]);

                // perform calculation
                estimatedFare[i] = (ride_time * cost_per_minute[i]) + (ride_distance * cost_per_mile[i]);
            }

            // print the array of doubles together as one print statement using join() b/c without that console just prints System.double[]
            Console.WriteLine(String.Join(" ", estimatedFare));
        }
    }
}
