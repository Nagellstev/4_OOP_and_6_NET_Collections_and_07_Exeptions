using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.VehicleDetails;

namespace CarPark.Vehicles
{
    internal class Vehicle
    {
        public string Model
        { get; set; }
        public string Color
        { get; set; }
        public int maxSpeed
        { get; set; }
        public decimal Power
        {
            get
            {
                return engine.Power;
            }
        }
        public decimal MaxLoad
        {
            get
            {
                return chassis.Load;
            }
        }

        public Engine engine = new Engine();
        public Transmission transmission = new Transmission();
        public Chassis chassis = new Chassis();

        public virtual void PropertiesOutput()
        {

        }
    }
}
