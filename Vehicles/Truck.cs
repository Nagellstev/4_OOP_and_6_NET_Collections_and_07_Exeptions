using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Vehicles
{
    internal class Truck : Vehicle 
    {
        public int TrackBodyVolume
        { get; set; }

        public override void PropertiesOutput()
        {
            Console.WriteLine($"{Model} Characteristics: ");
            Console.WriteLine($"Track Body Volume: {TrackBodyVolume} m3");
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
