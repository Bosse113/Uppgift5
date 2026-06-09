using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    internal class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

        public Vehicle(string registrationNumber,string color,int numberOfWheels)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }

        public override string ToString()
        {
        //ToDo:fundera på om detta behövs
            return $"{GetType().Name} | {RegistrationNumber} | {Color} | {NumberOfWheels}";
        }
    }
}
