using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace Uppgift5
{
    internal class Handler
    {
        Garage<Vehicle>? garage;

        public void CreateGarage(int capacity)
        { //ToDo:
            garage = new Garage<Vehicle>(capacity);
        }
        public bool ParkVehicle(Vehicle vehicle)
        {//ToDo:

        }
        public bool RemoveVehicle(string registrationNumber)
        {//ToDo:

        }
        public Vehicle FindVehicle(string registrationNumber)
        {//ToDo:

        }

    }
}
