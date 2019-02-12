using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    public class Location
    {
        public double Latitude { get; }

        public double Longtitude { get; }

        public Location(double latitude, double longtitude)
        {
            Latitude = latitude;
            Longtitude = longtitude;
        }
    }
}
