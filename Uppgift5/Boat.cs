using Microsoft.VisualBasic.FileIO;
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
        public override string ToString()
        {

            return $"{GetType().Name,10} \t| {RegistrationNumber,6} \t| {Color,10} \t| {NumberOfWheels} \t| {Length} meter";
        }
    }
}
