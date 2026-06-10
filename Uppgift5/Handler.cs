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
        
        public Vehicle? FindVehicle(string registrationNumber)
        {
            if (garage == null)
            {
                return null;
            }

            return garage.Find(registrationNumber);
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            if (garage == null)
                return new List<Vehicle>();

            return garage;
        }
        public void AddVehiclesToGarage()
        {
            
           bool bil=garage.Add(new Car("CAR123", "Röd", 4, "Bensin"));
           bool mc=garage.Add(new Motorcycle("BIK999", "Svart", 2, 900));
           bool buss=garage.Add(new Bus("BUS001", "Blå", 6, 55));
           bool boat=garage.Add(new Boat("SEA123", "Vit", 0, 12));
           bool plan=garage.Add(new Airplane("AIR777", "Silver", 8, 2));
            
        }

    }
}
