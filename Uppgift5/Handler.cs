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
            if (garage == null)
                return false;

            // Kontrollera unikt registreringsnummer
            foreach (var v in garage)//ToDo: GetEnumerator fixa!!!IENumerable
            {
                if (v.RegistrationNumber.Equals(
                    vehicle.RegistrationNumber,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            return garage.Add(vehicle);
            return true;//test
        }
        public bool RemoveVehicle(string registrationNumber)
        {//ToDo:

            if (garage == null)
                return false;

            return garage.Remove(registrationNumber);
           
        }
        public Vehicle FindVehicle(string registrationNumber)
        {//ToDo:
            return null;//Test
        }

    }
}
