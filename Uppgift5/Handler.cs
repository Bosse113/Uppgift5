namespace Uppgift5
{
    internal class Handler
    {
        private Garage<Vehicle>? garage;

        public void CreateGarage(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            if (garage == null)
                return false;

            return garage.Add(vehicle);
        }

        public bool RemoveVehicle(string regNr)
        {
            if (garage == null)
                return false;

            return garage.Remove(regNr);
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            if (garage == null)
                return new List<Vehicle>();

            return garage;//ToDo: FIX and code
        }

    }
}
