using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne_Tests
{
    public class CarStoreTests
    {
        public void AddCar_AddBMW_ListContainObject()
        {
            // Arrange
            CarStore carStore = new CarStore();
            BMW car = new BMW();

            // Act
            carStore.AddCar(car);

            //Assert
            Assert.NotEmpty(carStore.cars);
            Assert.Single(carStore.cars);
            Assert.Contains<Car>(car, carStore.cars);
            Assert.DoesNotContain<Car>(carStore.cars, c => c.drivingMode == DrivingMode.Backward);
        }
    }
}
