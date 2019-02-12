using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Events
{
    public class CoordinateOufOfRangeException : Exception
    {

        public CoordinateOufOfRangeException() : base (string.Empty)
        {

        }
        public CoordinateOufOfRangeException(string message) : base(message)
        {
            
        }

        public CoordinateOufOfRangeException(string message, Exception innerException) : base (message, innerException)
        {

        }
    }
}
