using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    public class Car:Vehicle
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
    }
}
