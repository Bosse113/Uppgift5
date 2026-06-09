using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift5
{
    internal class UI
    {
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
                        CreateGarage();
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

                Console.WriteLine("\nTryck valfri tangent...");
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
        {
            throw new NotImplementedException();
        }

        private void AddVehicle()
        {
            throw new NotImplementedException();
        }

        private void CreateGarage()
        {
            throw new NotImplementedException();
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
