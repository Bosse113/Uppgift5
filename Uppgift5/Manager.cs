using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Text;

namespace Uppgift5
{
    internal class Manager
    {//Todo: manager och vad den ska göra
        private readonly UI ui;
        private readonly Handler handler;
       

        public Manager()
        {
            handler = new Handler();
            ui = new UI();
        }

        public void Run()
        {
            bool running = true;

            while (running)
            {
                ui.ShowMainMenu();

                int choice = ui.GetIntInput("Välj : ");
                switch (choice)
                {
                    case 1:
                        CreateGarage();
                        break;

                    case 2:
                        AddVehicle();
                        break;

                    case 3:
                        RemoveVehicle();
                        break;

                    case 4:
                        ListVehicles();
                        break;

                    case 5:
                        SearchVehicles();//Todo: Search
                        break;

                    case 6:
                        GenerateVehicles();//ToDo:Generate
                        break;

                    case 0:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val!");
                        break;
                }

            }
        }

        private void CreateGarage()
        {
            int capacity = ui.GetIntInput(
                "Ange garagekapacitet:");

            handler.CreateGarage(capacity);

            ui.ShowMessage("Garaget skapades.");
        }

        private void AddVehicle()
        {
            //ToDo: NullCheck
            Console.WriteLine($"{Environment.NewLine}1. Bil");
            Console.WriteLine("2. Motorcykel");
            Console.WriteLine("3. Flygplan");
            Console.WriteLine("4. Buss");
            Console.WriteLine("5. Båt");

            string type = Console.ReadLine();//ToDo: ändra till ui-variant

            Console.Write("Registreringsnummer: ");
            string regNr = Console.ReadLine();//ToDo: ändra till ui-variant

            Console.Write("Färg: ");
            string color = Console.ReadLine();//ToDo: ändra till ui-variant

            Console.Write("Antal hjul: ");
            int wheels = int.Parse(Console.ReadLine());//ToDo: ändra till ui-variant

            Vehicle vehicle = null;

            switch (type)
            {
                case "1":

                    Console.Write("Bränsletyp: ");
                    string fuel = Console.ReadLine();//ToDo: ändra till ui-variant

                    vehicle = new Car(
                        regNr,
                        color,
                        wheels,
                        fuel);

                    break;

                case "2":

                    Console.Write("Cylindervolym: ");

                    int volume = int.Parse(Console.ReadLine());//ToDo: ändra till ui-variant

                    vehicle = new Motorcycle(
                        regNr,
                        color,
                        wheels,
                        volume);

                    break;

                case "3":

                    Console.Write("Antal motorer: ");

                    int NumOfEngines = int.Parse(Console.ReadLine());//ToDo: ändra till ui-variant

                    vehicle = new Motorcycle(
                        regNr,
                        color,
                        wheels,
                        NumOfEngines);

                    break;

                case "4":

                    Console.Write("Antal sittplatser: ");

                    int numberOfSeats = int.Parse(Console.ReadLine());//ToDo: ändra till ui-variant
                 
                    vehicle = new Motorcycle(
                        regNr,
                        color,
                        wheels,
                        numberOfSeats);

                    break;

                case "5":

                    Console.Write("Längd: ");

                    int length = int.Parse(Console.ReadLine());//ToDo: ändra till ui-variant

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

        private void RemoveVehicle()
        {
            string regNr =
                ui.GetStringInput("Registreringsnummer:");

            bool success =
                handler.RemoveVehicle(regNr);

            if (success)
            {
                ui.ShowMessage("Fordon borttaget.");
            }
            else
            {
                ui.ShowMessage("Fordon hittades inte.");
            }
        }

        private void ListVehicles() 
        {
            IEnumerable<Vehicle> vehicles =
                handler.GetAllVehicles();

            foreach (Vehicle vehicle in vehicles)
            {
                ui.ShowMessage(vehicle.ToString());
            }
        }
        private void SearchVehicles()
        {
            string regNr =
                ui.GetStringInput("Registreringsnummer du vill söka efter:");
            Vehicle? vehicle = handler.FindVehicle(regNr);

            if (vehicle == null)
            {
                ui.ShowMessage("Fordonet hittades inte.");//ToDo: visas även om vi fått träff
            }
            else
            {
                ui.ShowMessage(vehicle.ToString());
            }
            

        }


        private void GenerateVehicles()
        {//Todo: GenerateVehicles
            handler.AddVehiclesToGarage();
           
        }

        
        
    }
   

}

