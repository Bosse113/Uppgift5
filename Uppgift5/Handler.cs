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
        public bool FindByRegNumber(string RegNr)
        {
            if (garage == null)
            { return false; }
            else if (garage.Find(RegNr) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return garage.Find(RegNr);
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            if (garage == null)
                return new List<Vehicle>();

            return garage;//ToDo: FIX and code GetAllVehicles
        }
        public void AddVehiclesToGarage() 
        {
           Vehicle bil=new Car("CAR123", "Röd", 4, "Bensin");
           Vehicle mc= new Motorcycle("BIK999", "Svart", 2, 900);
           Vehicle buss=new Bus("BUS001", "Blå", 6, 55);
           Vehicle boat=new Boat("SEA123", "Vit", 0, 12);
           Vehicle plan=new Airplane("AIR777", "Silver", 8, 2);
        }

    }
}
