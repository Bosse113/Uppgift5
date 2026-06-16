using Microsoft.VisualBasic.FileIO;
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
        public override string ToString()
        {

            return $"{GetType().Name,10} \t| {RegistrationNumber,6} \t| {Color,10} \t| {NumberOfWheels} \t| {NumberOfSeats} sittplatser";
        }
    }
}
