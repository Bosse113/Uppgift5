using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using Uppgift5;
namespace Uppgift5.Tests
{
    public class GarageTest
    {
        [Fact]
        
        public void Add_ValidVehicle_ReturnsTrue()
        {
            // Arrange
            
            Garage<Vehicle> garage =
                new Garage<Vehicle>(5);

            Vehicle car =
                new Car(
                    "ABC123",
                    "Red",
                    4,
                    "Gasoline");

            // Act
            bool result = garage.Add(car);

            // Assert
            Assert.True(result);
        }


    }
}

