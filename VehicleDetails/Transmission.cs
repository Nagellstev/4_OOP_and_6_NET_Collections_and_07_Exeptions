using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.VehicleDetails
{
    internal class Transmission
    {
        public string Type;
        public string Manufacturer;
        public int GearsNumber;

        public void Output()
        {
            Console.WriteLine("Transmission Characteristics: ");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"GearsNumber: {GearsNumber}\n");
        }
    }
}
