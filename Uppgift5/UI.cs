namespace Uppgift5
{
    internal class UI
    {
        
        

        

        public void ShowMainMenu()
        {
            Console.WriteLine($"{Environment.NewLine}====== GARAGE ======");
            Console.WriteLine("1. Skapa garage");
            Console.WriteLine("2. Parkera fordon");
            Console.WriteLine("3. Ta ut fordon från garaget");
            Console.WriteLine("4. Lista fordon");
            Console.WriteLine("5. Sök fordon på registreringsnummer");
            Console.WriteLine("6. Generera fordon i garaget");
            Console.WriteLine("0. Avsluta");
        }
        public string GetStringInput(string message) //ToDo: ordna validering
        {
            Console.WriteLine(message);
            return Console.ReadLine() ?? "";
        }

        public int GetIntInput(string message)
        {
            Console.WriteLine(message);

            int value;

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Felaktigt tal.");
            }

            return value;
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
