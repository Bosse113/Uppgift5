using Microsoft.VisualBasic.FileIO;
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
        public override string ToString()
        {

            return $"{GetType().Name,10} \t| {RegistrationNumber,6} \t| {Color,10} \t| {NumberOfWheels} \t| {NumberOfEngines} motorer";
        }
    }
}
