using System;

namespace UberFareEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            // make instance of class that contains our method
            var estimator = new Estimator();

            double[] cost_per_minute = new double[4];
            double[] cost_per_mile = new double[4];

            cost_per_minute[0] = .2;
            cost_per_minute[0] = .35;
            cost_per_minute[0] = .4;
            cost_per_minute[0] = .45;

            cost_per_mile[0] = 1.1;
            cost_per_mile[1] = 1.8;
            cost_per_mile[2] = 2.3;
            cost_per_mile[3] = 3.5;

            // run method in estimator class
            var test = estimator.fareEstimator(30, 7, cost_per_minute[], cost_per_mile[]);



            Console.WriteLine(test);
        }

        public class Estimator
        {
            public double[] fareEstimator(int ride_time, int ride_distance, double[] cost_per_minute, double[] cost_per_mile)
            {

                // initialize array
                double[] answer = new double[cost_per_mile.Length];

                // loop through array, doing the equation for each item in cost_per_minute & cost_per_mile
                for (int i = 0; i < cost_per_mile.Length; i++)
                {
                    answer[i] = (ride_time * cost_per_minute[i]) + (ride_distance * cost_per_mile[i]);
                }
                return answer;
            }
        }
    }
}
