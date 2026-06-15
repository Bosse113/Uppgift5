namespace Uppgift5Tests
{
    public class GarageTest
    {

        //Kontrollera att ett fordon läggs till.
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
    

