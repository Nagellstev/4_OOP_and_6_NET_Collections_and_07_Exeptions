﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Vehicles
{
    internal class Scooter : Vehicle
    {
        public string BrakesType
        { get; set; }

        public override void PropertiesOutput()
        {
            Console.WriteLine($"{Model} Characteristics: ");
            Console.WriteLine($"Brakes Type: {BrakesType}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Max Speed: {maxSpeed} km/h");
            Console.WriteLine($"Power: {Power} hp");
            Console.WriteLine($"Max Load: {MaxLoad} kg\n");

            engine.Output();
            chassis.Output();
            transmission.Output();

            Console.WriteLine("\n");
        }
    }
}
