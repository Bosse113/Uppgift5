namespace Uppgift5
{
    internal interface IVehicle
    {
        string Color { get; set; }
        int NumberOfWheels { get; set; }
        string RegistrationNumber { get; set; }

        string ToString();
    }
}