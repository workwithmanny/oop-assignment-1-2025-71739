namespace Domain
{
    public abstract class Vehicle : IVehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public abstract void Display();
        public abstract double CheckPrice();
    }
}