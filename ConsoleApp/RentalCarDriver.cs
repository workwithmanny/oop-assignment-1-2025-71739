using System;
using Domain;

namespace ConsoleApp
{
    class RentalCarDriver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student ID: 71739 - Rental Car System");

            
            RentalCar car1 = new RentalCar("Toyota", "Corolla", BodyType.Saloon, "241-D-555", 60.00, false);
            RentalCar car2 = new RentalCar("Ford", "Fiesta", BodyType.HatchBack, "231-D-300", 45.00);
            RentalCar car3 = new RentalCar("Honda", "CR-V", BodyType.CrossOver);
            RentalCar car4 = new RentalCar("Nissan", "Leaf", BodyType.HatchBack, "242-D-100", 55.00, true);

            
            Console.WriteLine("\n--- Fleet Display ---");
            car1.Display();
            car2.Display();
            car3.Display();
            car4.Display();

            
            Console.WriteLine("--- Testing Methods ---");
            
           
            Console.WriteLine($"Borrowing {car1.Model}...");
            car1.Borrow();
            Console.WriteLine($"Checking borrowed status: {car1.CheckBorrowed()}");

            
            Console.WriteLine($"Returning {car4.Model}...");
            car4.ReturnRentalCar();
            
           
            Console.WriteLine($"Old Price of {car2.Model}: {car2.CheckPrice()}");
            car2.ChangePrice(99.99);
            Console.WriteLine($"New Price of {car2.Model}: {car2.CheckPrice()}");

            Console.ReadLine();
        }
    }
}