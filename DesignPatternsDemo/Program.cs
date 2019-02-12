using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Vehicle("AB-1234");
            var fleetmanager = new FleetManager(new Location(0, 0));
            fleetmanager.AddVehicle(myCar);
            
            myCar.LocationChanged += MyCarOnLocationChanged;
            myCar.Location = new Location(10, 10);

            fleetmanager.RemoveVehicle(myCar.Id);

            var myOtherCar = new Vehicle("BA-4321");
            myOtherCar.Location = new Location(-20, 10);
            myOtherCar.LocationChanged += MyCarOnLocationChanged;
            fleetmanager.AddVehicle(myOtherCar);

            for (double i = myCar.Location.Latitude; i>=0; i--)
            {
                myCar.Location = new Location(i, i);
            }






            Console.ReadKey();
        }


        private static void PrintCar(object sender, EventArgs e)
        {
            Console.WriteLine("The location of the car has changed");
        }

        private static void MyCarOnLocationChanged(object sender, EventArgs e)
        {
            var car = sender as Vehicle;
            Console.WriteLine($"The location of the car {car.Id}is {car.Location}");
        }

            
    }   
}
