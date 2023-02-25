/// The program described in README.md

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using CarPark.Vehicles;

namespace CarPark
{
    public class Program
    {
        public static void Main()
        {
            PassengerCar passengerCar = new PassengerCar();
            passengerCar.Model = "Passenger Car";
            passengerCar.MaxSpeed = 200;
            passengerCar.Color = "Blue";
            passengerCar.BodyType = "Sedan";
            passengerCar.Number = 10;

            passengerCar.engine.EngineType = "Gas";
            passengerCar.engine.SerialNumber = 123;
            passengerCar.engine.Volume = 2.4m;
            passengerCar.engine.Power = 180;

            passengerCar.chassis.WheelsNumber = 4;
            passengerCar.chassis.Load = 2000;
            passengerCar.chassis.SerialNumber = 234;

            passengerCar.transmission.Manufacturer = "ZF";
            passengerCar.transmission.GearsNumber = 5;
            passengerCar.transmission.Type = "automatic";

            Truck truck = new Truck();
            truck.Model = "Truck";
            truck.MaxSpeed = 120;
            truck.Color = "White";
            truck.TruckBodyVolume = 6;
            truck.Number = 11;

            truck.engine.EngineType = "Diesel";
            truck.engine.SerialNumber = 345;
            truck.engine.Volume = 6.4m;
            truck.engine.Power = 220;

            truck.chassis.WheelsNumber = 6;
            truck.chassis.Load = 12000;
            truck.chassis.SerialNumber = 456;

            truck.transmission.Manufacturer = "Bonfiglioli";
            truck.transmission.GearsNumber = 12;
            truck.transmission.Type = "manual";

            Bus bus = new Bus();
            bus.Model = "Bus";
            bus.MaxSpeed = 140;
            bus.Color = "Grey";
            bus.PassengerCaparcity = 50;
            bus.Number = 12;

            bus.engine.EngineType = "Diesel";
            bus.engine.SerialNumber = 567;
            bus.engine.Volume = 5.4m;
            bus.engine.Power = 210;

            bus.chassis.WheelsNumber = 4;
            bus.chassis.Load = 8000;
            bus.chassis.SerialNumber = 678;

            bus.transmission.Manufacturer = "Linda";
            bus.transmission.GearsNumber = 10;
            bus.transmission.Type = "manual";

            Scooter scooter = new Scooter();
            scooter.Model = "Scooter";
            scooter.MaxSpeed = 80;
            scooter.Color = "Red";
            scooter.BrakesType = "Disk";
            scooter.Number = 13;

            scooter.engine.EngineType = "Gas";
            scooter.engine.SerialNumber = 789;
            scooter.engine.Volume = 0.15m;
            scooter.engine.Power = 10;

            scooter.chassis.WheelsNumber = 2;
            scooter.chassis.Load = 200;
            scooter.chassis.SerialNumber = 890;

            scooter.transmission.Manufacturer = "CF";
            scooter.transmission.GearsNumber = 1;
            scooter.transmission.Type = "Variator";

            Console.WriteLine("Car Park\n");

            passengerCar.PropertiesOutput();
            truck.PropertiesOutput();
            bus.PropertiesOutput();
            scooter.PropertiesOutput();
        }
    }
}