using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    internal class Garage<T> : IEnumerable<T> 
, IGarage<T> where T : Vehicle 
    {
        private readonly T[] vehicles;

        public int Capacity { get; }

        public Garage(int capacity)
        {
            Capacity = capacity;
            vehicles = new T[capacity];
        }
        public int Count { get; private set; }
        public bool IsFull => Count >= Capacity;
        //Lägg till fordon //Kompletterat med koll av regnummer och om garage=fullt. Tillagt efter deadline. Blev påmind av dokumentet för genomgången
        public bool Add(T vehicle)
        {
            if (IsFull)
            {
                return false;
            }

            foreach (T? existingVehicle in vehicles)
            {
                if (existingVehicle != null)//kolla om regnummer redan finns i garaget
                {
                    if (existingVehicle.RegistrationNumber.Equals(
                        vehicle.RegistrationNumber,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    Count++;
                    return true;
                }
            }

            return false;
        }
        //public bool Add(T vehicle)
        //{
        //    for (int i = 0; i < vehicles.Length; i++)
        //    {
        //        if (vehicles[i] == null)
        //        {
        //            vehicles[i] = vehicle;
        //            return true;
        //        }
        //    }

        //    return false;
        //}
        //Ta bort fordon

        public bool Remove(string registrationNumber)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null &&
                    vehicles[i].RegistrationNumber.Equals(
                        registrationNumber,
                        StringComparison.OrdinalIgnoreCase))
                {
                    vehicles[i] = null!;
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
