using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;

namespace Uppgift5
{
    internal class Manager
    {
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
                        SearchVehiclesByNumberPlate();
                        break;
                    case 6:
                        SearchVehicles();
                        break;
                    case 7:
                        ListTypes();
                        break;
                    case 9:
                        GenerateVehicles();
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

        private void ListTypes()
        {
            handler.ListTypesCount(); 
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
           
            Console.WriteLine($"{Environment.NewLine}1. Bil");
            Console.WriteLine("2. Motorcykel");
            Console.WriteLine("3. Flygplan");
            Console.WriteLine("4. Buss");
            Console.WriteLine("5. Båt");

            ui.ShowMessage("Skriv in efter kolon.");
            string type=ui.GetVerifiedStringInput("Fordonstyp:");
            string regNr=ui.GetVerifiedStringInput("Registreringsnummer: ");
            string color=ui.GetVerifiedStringInput("Färg: ");

            int wheels=ui.GetVerifiedIntInput("Antal hjul: ");

            Vehicle vehicle = null!;

            switch (type)
            {
                case "1":
                    string fuel = ui.GetVerifiedStringInput("Bränsletyp: ");

                    vehicle = new Car(
                        regNr,
                        color,
                        wheels,
                        fuel);

                    break;

                case "2":
                    int volume = ui.GetVerifiedIntInput("Cylindervolym:");

                    vehicle = new Motorcycle(
                        regNr,
                        color,
                        wheels,
                        volume);

                    break;

                case "3":
                    int NumOfEngines = ui.GetVerifiedIntInput("Antal motorer:");

                    vehicle = new Motorcycle(
                        regNr,
                        color,
                        wheels,
                        NumOfEngines);

                    break;

                case "4":
                    int numberOfSeats = ui.GetVerifiedIntInput("Antal sittplatser:");
                 
                    vehicle = new Motorcycle(
                        regNr,
                        color,
                        wheels,
                        numberOfSeats);

                    break;

                case "5":
                    int length = ui.GetVerifiedIntInput("Längd:");

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
            ui.ShowMessage("Skriv in registrerings nummer för fordon som ska tas bort ur garaget.");
            string regNr =
                ui.GetVerifiedStringInput("Registreringsnummer:");

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
            
            Console.WriteLine("Hittade följande:");
        
            foreach (Vehicle vehicle in vehicles)
            {
                ui.ShowMessage(vehicle.ToString());
            }
        }
        private void SearchVehiclesByNumberPlate()
        {
            string regNr = ui.GetVerifiedStringInput("Registreringsnummer du vill söka efter:");
            Vehicle? vehicle = handler.FindVehicle(regNr);

            if (vehicle == null)
            {
                ui.ShowMessage("Fordonet hittades inte.");
            }
            else
            {
                ui.ShowMessage("Hittade följande:");
                ui.ShowMessage(vehicle.ToString());
            }
            

        }


        private void GenerateVehicles()
        {
            handler.AddVehiclesToGarage();
           
        }

        private void SearchVehicles()//ska inte använda verified-metoderna p.g.a. tomt är ok
        {
            string color =
                ui.GetStringInput(
                    "Färg (tomt = alla):");

            string wheelInput =
                ui.GetStringInput(
                    "Antal hjul (tomt = alla):");
            Console.WriteLine("Fordonstyper: Car,Motorcycle,Boat,Bus,Airplane.");
            string typeInput =
               ui.GetStringInput(
                   "Fordonstyp (tomt = alla):");

            int? wheels = null;

            if (!string.IsNullOrWhiteSpace(wheelInput))
            {
                wheels = int.Parse(wheelInput);//gör om input till Int.
            }

            IEnumerable<Vehicle> result =
                handler.SearchVehicles(
                    typeInput,
                    color,
                    wheels);

            foreach (Vehicle vehicle in result)
            {
                ui.ShowMessage(vehicle.ToString());
            }
        }


    }
   

}

