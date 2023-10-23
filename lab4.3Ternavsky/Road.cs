using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3Ternavsky
{
    internal class Road
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int LaneQuantity { get; set; }
        public int CurrentTrafficLevel { get; set; }

        public Road(double length, double width, int laneQuantity, int currentTrafficLevel) 
        {
            Length = length;
            Width = width;
            LaneQuantity = laneQuantity;
            CurrentTrafficLevel = currentTrafficLevel;
        }
    }
}
