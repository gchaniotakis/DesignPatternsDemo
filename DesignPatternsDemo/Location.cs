using DesignPatternsDemo.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    public class Location : IEquatable<Location>
    {
        public double Latitude { get; }

        public double Longtitude { get; }

        public Location(double latitude, double longtitude)
        {
            if (latitude > 90 || latitude < -90)
            {
                throw new CoordinateOufOfRangeException("Latitude is out of range");
            }
            

            if (longtitude > 180 || longtitude < -180)
            {
                throw new CoordinateOufOfRangeException("Longtitude is out of range");
            }

            Latitude = latitude;
            Longtitude = longtitude;
        }

        public bool Equals(Location other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return (Math.Abs(Latitude - other.Latitude) < 1e-6 &&
                    Math.Abs(Longtitude - other.Longtitude) < 1e-6);

        }

    }
}
