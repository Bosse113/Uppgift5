using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using Uppgift5;
namespace Uppgift5.Tests
{
    public class GarageTest
    {
//        
//Om du behöver komma åt internal så får du lägga till i csproj filen i programmet du vill testa i ditt fall GarageProjektet
//Dubbelklicka på projekt-filen och lägg till:
//  < ItemGroup >
//    < InternalsVisibleTo Include="Uppgift5.Tests"/>
//  </ItemGroup>

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
                    "Bensin");

            // Act
            bool result = garage.Add(car);

            // Assert
            Assert.True(result);
        }


        [Fact]
        public void Add_GarageFull_ReturnsFalse()
        {
            // Arrange
            var garage =
                new Garage<Vehicle>(1);

            garage.Add(
                new Car(
                    "ABC123",
                    "Red",
                    4,
                    "Bensin"));

            // Act
            bool result =
                garage.Add(
                    new Car(
                        "DEF456",
                        "Blue",
                        4,
                        "Diesel"));

            // Assert
            Assert.False(result);
        }


        [Fact]
        public void Find_ExistingVehicle_ReturnsVehicle()
        {
            // Arrange
            var garage =
                new Garage<Vehicle>(5);

            garage.Add(
                new Car(
                    "ABC123",
                    "Red",
                    4,
                    "Bensin"));

            // Act
            Vehicle? result =
                garage.Find("ABC123");

            // Assert
            Assert.NotNull(result);
        }


        [Fact]
        public void Remove_ExistingVehicle_ReturnsTrue()
        {
            // Arrange
            var garage =
                new Garage<Vehicle>(5);

            garage.Add(
                new Car(
                    "ABC123",
                    "Red",
                    4,
                    "Bensin"));

            // Act
            bool result =
                garage.Remove("ABC123");

            // Assert
            Assert.True(result);
        }
        [Fact]
        public void Find_NonExistingVehicle_ReturnsNull()
        {
            // Arrange
            var garage =
                new Garage<Vehicle>(5);

            // Act
            Vehicle? result =
                garage.Find("XYZ999");

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void Add_DuplicateRegistrationNumber_ReturnsFalse()
        {
            // Arrange
            var garage = new Garage<Vehicle>(5);

            garage.Add(
                new Car(
                    "ABC123",
                    "Red",
                    4,
                    "Gasoline"));

            // Act
            bool result =
                garage.Add(
                    new Car(
                        "abc123",
                        "Blue",
                        4,
                        "Diesel"));

            // Assert
            Assert.False(result);
        }
    }
}

