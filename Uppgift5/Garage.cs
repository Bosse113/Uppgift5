using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    internal class Garage<T> : IEnumerable<T> // ToDO:IEnummerable kolla exakt vad det gör
        where T : Vehicle //ToDo: tror detta ska vara här kolla varför
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
        public T? Find(string registrationNumber)
        {
            foreach (T? vehicle in vehicles)
            {
                if (vehicle != null &&
                    vehicle.RegistrationNumber.Equals(
                        registrationNumber,
                        StringComparison.OrdinalIgnoreCase))
                {
                    return vehicle;
                }
            }

            return null;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    yield return vehicle;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        

    }
}
