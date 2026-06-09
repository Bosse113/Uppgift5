using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    internal class Bus:Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Bus(
            string regNr,
            string color,
            int wheels,
            int numberOfSeats)
            : base(regNr, color, wheels)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}
