using CarFactoryLibrary;

namespace LabOne_tests
{
    public class CarTests
    {
        [Fact]
        public void Equals_SameVelocityandDrivingMode_True()
        {
            // Arrange
            Car car1 = new Toyota() { velocity = 10, drivingMode = DrivingMode.Forward };
            Car car2 = new BMW() { velocity = 10, drivingMode = DrivingMode.Forward };
            // Act
            car1.Equals(car2);
            //Assert
            Assert.True(car1.Equals(car2));
        }

        [Fact]
        public void Equals_DifferentVelocityandDrivingMode_False()
        {
            // Arrange
            Car car1 = new Toyota() { velocity = 10, drivingMode = DrivingMode.Forward };
            Car car2 = new Toyota() { velocity = 20, drivingMode = DrivingMode.Backward};
            // Act
            car1.Equals(car2);
            //Assert
            Assert.False(car1.Equals(car2));
        }

        
    }
}