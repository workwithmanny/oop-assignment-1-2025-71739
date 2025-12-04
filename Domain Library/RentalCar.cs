using System;

namespace Domain
{
    public class RentalCar : Vehicle
    {
         
        public BodyType BodyType { get; set; }
        public string RegistrationNumber { get; set; }
        public double Price { get; set; }
        public bool Borrowed { get; set; }

        
        public RentalCar(string manufacturer, string model, BodyType bodyType, string registrationNumber, double price, bool borrowed)
        {
            Manufacturer = manufacturer;
            Model = model;
            BodyType = bodyType;
            RegistrationNumber = registrationNumber;
            Price = price;
            Borrowed = borrowed;
        }

        
        public RentalCar(string manufacturer, string model, BodyType bodyType, string registrationNumber, double price) 
            : this(manufacturer, model, bodyType, registrationNumber, price, false) { }

        
        public RentalCar(string manufacturer, string model, BodyType bodyType) 
            : this(manufacturer, model, bodyType, "Unknown", 0.0, false) { }

        
        public void Borrow()
        {
            if (Borrowed)
            {
                Console.WriteLine("Error: Car is already on loan.");
            }
            else
            {
                Borrowed = true;
            }
        }

        
        public void ReturnRentalCar()
        {
            Borrowed = false;
        }

        
        public void ChangePrice(double price)
        {
            Price = price;
        }

        
        public override double CheckPrice()
        {
            return Price;
        }

        
        public bool CheckBorrowed()
        {
            return Borrowed;
        }

        
        public override void Display()
        {
            Console.WriteLine("********************************");
            Console.WriteLine($"Manufacturer:    {Manufacturer}");
            Console.WriteLine($"Model:           {Model}");
            Console.WriteLine($"BodyType:        {BodyType}");
            Console.WriteLine($"Registration:    {RegistrationNumber}");
            Console.WriteLine($"Price:           {Price}");
            Console.WriteLine($"Borrowed:        {Borrowed}");
            Console.WriteLine(); 
        }
    }
}