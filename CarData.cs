using System;
using System.Collections.Generic;
using System.Text;

namespace UberFareEstimator
{
    class CarData
    {
        double cost_per_minute;
        double cost_per_mile;

        // create object with sole purpose is to assign arguments to variables
        public CarData(double costPerMinute, double costPerMile)
        {
            this.cost_per_minute = costPerMinute;
            this.cost_per_mile = costPerMile;
        }

        // this object calculates & returns the fare
        public double calculateFareEstimate(int ride_time, int ride_distance)
        {
            double fare = 0;

            fare = (ride_time * cost_per_minute) + (ride_distance * cost_per_mile);

            return fare;
        }
    }
}
