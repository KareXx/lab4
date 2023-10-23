using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3Ternavsky
{
    internal class Vehicle
    {
        public int Speed { get; set; }
        public int Size { get; set; }
        public VehicleType Type { get; set; }

        public Vehicle(int seed, int size, VehicleType type) {
            Speed = seed;
            Size = size;
            Type = type;
        }
    }
}
