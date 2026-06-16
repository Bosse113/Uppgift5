using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    internal class Car:Vehicle
    {
        public string FuelType { get; set; }

        public Car(
            string regNr,
            string color,
            int wheels,
            string fuelType)
            : base(regNr, color, wheels)
        {
            FuelType = fuelType;
        }
        public override string ToString()
        {

            return $"{GetType().Name,10} \t| {RegistrationNumber,6} \t| {Color,10} \t| {NumberOfWheels} \t| {FuelType} som drivmedel";
        }
    }
}
