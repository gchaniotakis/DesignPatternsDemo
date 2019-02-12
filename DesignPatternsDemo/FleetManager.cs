using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    public class FleetManager
    {
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private Location _location;

        public FleetManager(Location location)
        {
            _location = location;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
            vehicle.LocationChanged += VehicleOnLocationChanged;
        }

        private void VehicleOnLocationChanged(object sender, EventArgs e)
        {
            var vehicle = sender as Vehicle;
            if (_location.GetDistance(vehicle.Location) <1000)
            {
                Console.WriteLine($"Vehicle {vehicle.Id} is close to HQ!");
            }
        }

        public void RemoveVehicle(string id)
        {
            var index = _vehicles.FindIndex(v => v.Id == id);
            if (index > 0)
            {
                _vehicles.RemoveAt(index);
            }

            
        }
    }
}