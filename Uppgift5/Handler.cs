using System.Drawing;


namespace Uppgift5
{
    internal class Handler : IHandler
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

            bool bil = garage!.Add(new Car("CAR456", "Blå", 2, "Diesel"));
            bool mc = garage.Add(new Motorcycle("ABS255", "Gul", 2, 900));
            bool buss = garage.Add(new Bus("TOL652", "Röd", 4, 40));
            bool boat = garage.Add(new Boat("SEA456", "Vit", 0, 8));
            bool plan = garage.Add(new Airplane("AIR747", "Vit", 8, 2));

        }
        public IEnumerable<Vehicle> SearchVehicles(
        string? type,
        string? color,
        int? numberOfWheels)
        {
            List<Vehicle> result = new();

            if (garage == null)
            {
                return result;
            }

            foreach (Vehicle vehicle in garage)
            {
                bool matches = true;
                if (!string.IsNullOrWhiteSpace(type))
                {
                    if (!vehicle.GetType().Name.Equals(
                        type,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        matches = false;
                    }
                }

                if (!string.IsNullOrWhiteSpace(color))
                {
                    if (!vehicle.Color.Equals(
                        color,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        matches = false;
                    }
                }

                if (numberOfWheels.HasValue)
                {
                    if (vehicle.NumberOfWheels != numberOfWheels.Value)
                    {
                        matches = false;
                    }
                }

                if (matches)
                {
                    result.Add(vehicle);
                }
            }

            return result;
        }
        public void ListTypesCount()
        {
            if (garage == null)
            {
                Console.WriteLine("Garaget är tomt."); ;
            }
            else
            {
                var statistics =
                garage.GroupBy(v => v.GetType().Name)
              .Select(g => new
              {
                  Type = g.Key,
                  Count = g.Count()
              });

                foreach (var item in statistics)
                {
                    Console.WriteLine($"{item.Type}: {item.Count}");
                }
            }
        }
        public void SaveGarage(string fileName)
        {
            if (garage == null)
            {
                return;
            }

            using StreamWriter writer = new StreamWriter(fileName);

            foreach (Vehicle vehicle in garage)
            {
                if (vehicle is Car car)
                {
                    writer.WriteLine(
                        $"Car;{car.RegistrationNumber};{car.Color};{car.NumberOfWheels};{car.FuelType}");
                }
                else if (vehicle is Motorcycle motorcycle)
                {
                    writer.WriteLine(
                        $"Motorcycle;{motorcycle.RegistrationNumber};{motorcycle.Color};{motorcycle.NumberOfWheels};{motorcycle.CylinderVolume}");
                }
                else if (vehicle is Bus bus)
                {
                    writer.WriteLine(
                        $"Bus;{bus.RegistrationNumber};{bus.Color};{bus.NumberOfWheels};{bus.NumberOfSeats}");
                }
                else if (vehicle is Boat boat)
                {
                    writer.WriteLine(
                        $"Boat;{boat.RegistrationNumber};{boat.Color};{boat.NumberOfWheels};{boat.Length}");
                }
                else if (vehicle is Airplane airplane)
                {
                    writer.WriteLine(
                        $"Airplane;{airplane.RegistrationNumber};{airplane.Color};{airplane.NumberOfWheels};{airplane.NumberOfEngines}");
                }
            }
        }
        
        public void LoadGarage(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return;
            }

            string[] lines = File.ReadAllLines(fileName);

            garage = new Garage<Vehicle>(lines.Length + 10);//lägg på 10 platser mer än antalet fordon i filen.

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');//delar varje inputrad efter ; 

                if (parts.Length < 4)
                {
                    continue;
                }

                string vehicleType = parts[0];
                string regNr = parts[1];
                string color = parts[2];
                int wheels = int.Parse(parts[3]);

                Vehicle? vehicle = null;

                switch (vehicleType)
                {
                    case "Car":
                        vehicle = new Car(
                            regNr,
                            color,
                            wheels,
                            parts[4]);
                        break;

                    case "Motorcycle":
                        vehicle = new Motorcycle(
                            regNr,
                            color,
                            wheels,
                            int.Parse(parts[4]));
                        break;

                    case "Bus":
                        vehicle = new Bus(
                            regNr,
                            color,
                            wheels,
                            int.Parse(parts[4]));
                        break;

                    case "Boat":
                        vehicle = new Boat(
                            regNr,
                            color,
                            wheels,
                            int.Parse(parts[4]));
                        break;

                    case "Airplane":
                        vehicle = new Airplane(
                            regNr,
                            color,
                            wheels,
                            int.Parse(parts[4]));
                        break;
                }

                if (vehicle != null)
                {
                    garage.Add(vehicle);
                }
            }
        }

    }
}
