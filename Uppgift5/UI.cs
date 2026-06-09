namespace Uppgift5
{
    internal class UI
    {
        private readonly Handler handler;//för att få metoderna att fungera???

        public UI(Handler handler) //för att få metoderna att fungera???
        {
            this.handler = handler;
        }
        public void Start()
        {
            bool running = true;

            while (running)
            {
                ShowMainMenu();

                Console.Write($"{Environment.NewLine}Välj alternativ: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddGarage();
                        break;

                    case "2":
                        AddVehicle();
                        break;

                    case "3":
                        RemoveVehicle();
                        break;

                    case "4":
                        ListVehicles();
                        break;

                    case "5":
                        FindVehicle();
                        break;

                    case "6":
                        SearchVehicles();
                        break;

                    case "7":
                        GenerateVehicles();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val!");
                        break;
                }

                Console.WriteLine($"{Environment.NewLine}Tryck valfri tangent...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void SearchVehicles()
        {
            throw new NotImplementedException();
        }

        private void GenerateVehicles()
        {
            throw new NotImplementedException();
        }

        private void FindVehicle()
        {
            throw new NotImplementedException();
        }

        private void ListVehicles()
        {
            throw new NotImplementedException();
        }

        private void RemoveVehicle()
        {//ToDo: NullCheck
            Console.Write("Registreringsnummer: ");

            string regNr = Console.ReadLine();

            bool success = handler.RemoveVehicle(regNr);

            Console.WriteLine(
                success
                ? "Fordon borttaget."
                : "Fordon hittades inte.");
            
        }

        private void AddVehicle()
        {
        //ToDo: NullCheck
            Console.WriteLine($"{Environment.NewLine}1. Bil");
            Console.WriteLine("2. Motorcykel");
            Console.WriteLine("3. Flygplan");
            Console.WriteLine("4. Buss");
            Console.WriteLine("5. Båt");

            string type = Console.ReadLine();

            Console.Write("Registreringsnummer: ");
            string regNr = Console.ReadLine();

            Console.Write("Färg: ");
            string color = Console.ReadLine();

            Console.Write("Antal hjul: ");
            int wheels = int.Parse(Console.ReadLine());

            Vehicle vehicle = null;

            switch (type)
            {
                case "1":

                    Console.Write("Bränsletyp: ");
                    string fuel = Console.ReadLine();

                    vehicle = new Car(
                        regNr,
                        color,
                        wheels,
                        fuel);

                    break;

                case "2":

                    Console.Write("Cylindervolym: ");

                    int volume = int.Parse(Console.ReadLine());

                    vehicle = new Motorcycle(
                        regNr,
                        color,
                        wheels,
                        volume);

                    break;

                case "3":

                    Console.Write("Antal motorer: ");

                    int NumOfEngines = int.Parse(Console.ReadLine());

                    vehicle = new Motorcycle(
                        regNr,
                        color,
                        wheels,
                        NumOfEngines);

                    break;

                case "4":

                    Console.Write("Antal sittplatser: ");

                    int numberOfSeats = int.Parse(Console.ReadLine());

                    vehicle = new Motorcycle(
                        regNr,
                        color,
                        wheels,
                        numberOfSeats);

                    break;

                case "5":

                    Console.Write("Längd: ");

                    int length = int.Parse(Console.ReadLine());

                    vehicle = new Motorcycle(
                        regNr,
                        color,
                        wheels,
                        length);

                    break;
            }

            if (vehicle == null)
            {
                Console.WriteLine("Ogiltig fordonstyp.");
                return;
            }

            bool success = handler.ParkVehicle(vehicle);

            Console.WriteLine(
                success
                ? "Fordon parkerat."
                : "Kunde inte parkera fordonet.");//om success 1 annars 2
            
        }

        private void AddGarage()
        {
            Console.Write("Önskad kapacitet: ");

            if (int.TryParse(Console.ReadLine(), out int capacity))
            {
                handler.CreateGarage(capacity);
                Console.WriteLine("Garage skapat.");
            }
            else
            {
                Console.WriteLine("Felaktig inmatning.");
            }
            
        }

        private void ShowMainMenu()
        {
            Console.WriteLine($"{Environment.NewLine}====== GARAGE ======");
            Console.WriteLine("1. Skapa garage");
            Console.WriteLine("2. Parkera fordon");
            Console.WriteLine("3. Ta ut fordon");
            Console.WriteLine("4. Lista fordon");
            Console.WriteLine("5. Hitta fordon");
            Console.WriteLine("6. Sök fordon");
            Console.WriteLine("7. Generera fordon i garaget");
            Console.WriteLine("0. Avsluta");
        }
    }
}
