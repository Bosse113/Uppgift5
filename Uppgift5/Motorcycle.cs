using Microsoft.VisualBasic.FileIO;
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
        public override string ToString()
        {

            return $"{GetType().Name,10} \t| {RegistrationNumber,6} \t| {Color,10} \t| {NumberOfWheels} \t| {CylinderVolume} kubikcentimeter";
        }
    }
}
