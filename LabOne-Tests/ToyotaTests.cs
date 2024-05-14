using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne_tests
{
    public class ToyotaTests
    {
        [Fact]
        public void TimeToCoverDistance_Velocity60andDistance100km_1_67hours()
        {
            //Arrange
            Toyota car = new Toyota() { velocity = 60 };
            double expectedTime = 1.67;
            //Act
            double actualTime = car.TimeToCoverDistance(100);
            //Assert
            Assert.Equal(expectedTime, actualTime, precision: 2);
        }

        [Fact]
        public void FuelConsumption_FuelEffeciency25mpgAndDistance170mile_Range()
        {
            //Arrange
            Toyota car = new Toyota() { fuelEffeciency = 25 };

            //Act
            double actualFuelConsumption = car.FuelConsumption(170);
            double lowerBound = 6.79;
            double upperBound = 6.81;
            //Assert
            Assert.InRange(actualFuelConsumption, lowerBound, upperBound);


        }

        [Fact]
        public void GetDirection_BackwardDirection_Backward()
        {
            //Arrange
            Toyota car = new Toyota() { drivingMode = DrivingMode.Backward };
            var expectedDirectioin = "Backward";
            //Act
            string direction = car.GetDirection();

            //Assert
            Assert.Equal(expectedDirectioin, direction);
            Assert.StartsWith("B", direction);
            Assert.EndsWith("ward", direction);
           
        }

        [Fact]
        public void GetDirection_StoppedDirection_Stopped()
        {
            //Arrange
            Toyota car = new Toyota() { drivingMode = DrivingMode.Stopped };

            //Act
            string direction = car.GetDirection();

            //Assert
            Assert.Matches("S[a-z]{5}d", direction);
            

        }


    }
}
