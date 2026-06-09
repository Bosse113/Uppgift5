using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    internal class Garage<T> 
        where T : Vehicle //ToDo tror detta ska vara här
    {
        private readonly T[] vehicles;

        public int Capacity { get; }

        public Garage(int capacity)
        {
            Capacity = capacity;
            vehicles = new T[capacity];
        }
        //Lägg till fordon
        public bool Add(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
            }

            return false;
        }
        //Ta bort fordon
        //ToDo : nullcheck
        public bool Remove(string registrationNumber)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null &&
                    vehicles[i].RegistrationNumber.Equals(
                        registrationNumber,
                        StringComparison.OrdinalIgnoreCase))
                {
                    vehicles[i] = null;
                    return true;
                }
            }

            return false;
        }

        //Hitta fordon
        public T FindByRegistrationNumber(string regNr)//ToDo: kan returnera fel/null
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null &&
                    vehicle.RegistrationNumber.Equals(
                        regNr,
                        StringComparison.OrdinalIgnoreCase))
                {
                    return vehicle;
                }
            }

        }
        
    }
}
