namespace Fuel_Efficency_Calculation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Car Brand: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Car Model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Car Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fuel Type: ");
            string fuelType = Console.ReadLine();

            Car car = new(brand, model, year, fuelType);

            Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Fuel Type: {car.FuelType}");

            Console.Write("Distance traveled: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Fuel consumed: ");
            double fuelConsumed = Convert.ToDouble(Console.ReadLine());

            double efficiency = Car.FuelEfficiencyCalculator(distance, fuelConsumed);
            Console.WriteLine($"Fuel Efficiency: {efficiency} km/l");
        }
    }
}