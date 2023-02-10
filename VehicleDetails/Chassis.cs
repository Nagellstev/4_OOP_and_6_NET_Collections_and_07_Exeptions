using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.VehicleDetails
{
    internal class Chassis
    {
        public int WheelsNumber;
        public int SerialNumber;
        public decimal Load;

        public void Output()
        {
            Console.WriteLine("Chassis Characteristics: ");
            Console.WriteLine($"Wheels Number: {WheelsNumber}");
            Console.WriteLine($"Serial Number: {SerialNumber}");
            Console.WriteLine($"Load: {Load} kg\n");
        }
    }
}
