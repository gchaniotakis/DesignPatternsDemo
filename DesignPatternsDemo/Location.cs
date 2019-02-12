using DesignPatternsDemo.Events;
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
            if (latitude > 90 || latitude < -90)
            {
                throw new CoordinateOufOfRangeException("Latitude is out of range");
            }
            Latitude = latitude;

            if (longtitude > 180 || longtitude < -180)
            {
                throw new CoordinateOufOfRangeException("Longtitude is out of range")l
            }
            Longtitude = longtitude;
        }
    }
}
