namespace Fuel_Efficency_Calculation
{
    public class Car(string brand, string model, int year, string fuelType) : Vehicle(brand, model, year)
    {
        public string FuelType { get; set; } = fuelType;

        public static double FuelEfficiencyCalculator(double distance, double fuelConsumed)
        {
            return distance / fuelConsumed;
        }
    }
}
