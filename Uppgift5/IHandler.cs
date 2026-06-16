namespace Uppgift5
{
    internal interface IHandler
    {
        void AddVehiclesToGarage();
        void CreateGarage(int capacity);
        Vehicle? FindVehicle(string registrationNumber);
        IEnumerable<Vehicle> GetAllVehicles();
        void ListTypesCount();
        bool ParkVehicle(Vehicle vehicle);
        bool RemoveVehicle(string regNr);
        IEnumerable<Vehicle> SearchVehicles(string? type, string? color, int? numberOfWheels);
        void SaveGarage(string fileName);
        void LoadGarage(string fileName);
    }
}