using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    internal class Boat:Vehicle
    {
        public int Length { get; set; }

        public Boat(
            string regNr,
            string color,
            int wheels,
            int length)
            : base(regNr, color, wheels)
        {
            Length = length;
        }
    }
}
