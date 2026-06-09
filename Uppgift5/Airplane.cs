using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    internal class Airplane: Vehicle
    {
        public int NumberOfEngines { get; set; }

        public Airplane(
            string regNr,
            string color,
            int wheels,
            int numberOfEngines)
            : base(regNr, color, wheels)
        {
            NumberOfEngines = numberOfEngines;
        }
    }
}
