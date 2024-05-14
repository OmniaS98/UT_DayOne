using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne_Tests
{
    public class CarFactoryTests
    {

        [Fact]
        public void NewCar_AskForToyota_Toyota()
        {
            // Act
            Car? car = CarFactory.NewCar(CarTypes.Toyota);

            //Assert
            Assert.IsType<Toyota>(car);
            Assert.IsAssignableFrom<Car>(car);
        }


        [Fact]
        public void NewCar_AskForAudi_Null()
        {
            // Act
            Car? car = CarFactory.NewCar(CarTypes.Audi);

            //Assert
            Assert.Null(car);
           
        }

        [Fact]
        public void NewCar_AskForHonda_NotImplementedException()
        {
            //Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                Car? car = CarFactory.NewCar(CarTypes.Honda);
            });

        }


    }
}
