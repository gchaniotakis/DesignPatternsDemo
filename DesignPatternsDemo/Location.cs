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

        public double GetDistance(Location other)
        {
            var d1 = Latitude * (Math.PI / 180.0);
            var num1 = Longtitude * (Math.PI / 180.0);
            var d2 = other.Latitude * (Math.PI / 180.0);
            var num2 = other.Longtitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }

        public override string ToString()
        {
            return $"({Longtitude}, {Latitude})";
        }

    }
}
