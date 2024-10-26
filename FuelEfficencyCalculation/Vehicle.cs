namespace Fuel_Efficency_Calculation
{
    public class Vehicle(string brand, string model, int year)
    {
        public string Brand { get; set; } = brand;
        public string Model { get; set; } = model;
        public int Year { get; set; } = year;
    }
}
