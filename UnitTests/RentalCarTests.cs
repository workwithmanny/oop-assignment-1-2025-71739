using NUnit.Framework;
using Domain;

namespace UnitTests
{
    public class RentalCarTests
    {
        private RentalCar _car;

        [SetUp]
        public void Setup()
        {
            _car = new RentalCar("Test", "Car", BodyType.Saloon, "123", 50.0, false);
        }

        [Test]
        public void Borrow_SetsBorrowedTrue()
        {
            _car.Borrow();
            Assert.IsTrue(_car.CheckBorrowed());
        }

        [Test]
        public void ReturnRentalCar_SetsBorrowedFalse()
        {
            _car.Borrow(); // Set to true first
            _car.ReturnRentalCar();
            Assert.IsFalse(_car.CheckBorrowed());
        }

        [Test]
        public void ChangePrice_UpdatesValue()
        {
            _car.ChangePrice(100.0);
            Assert.AreEqual(100.0, _car.CheckPrice());
        }

        [Test]
        public void Constructor_SetsAttributesCorrectly()
        {
            Assert.AreEqual("Test", _car.Manufacturer);
            Assert.AreEqual(50.0, _car.Price);
        }
    }
}