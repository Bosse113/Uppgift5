using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    internal class Motorcycle:Vehicle
    {
        public int CylinderVolume { get; set; }

        public Motorcycle(
            string regNr,
            string color,
            int wheels,
            int cylinderVolume)
            : base(regNr, color, wheels)
        {
            CylinderVolume = cylinderVolume;
        }
    }
}
