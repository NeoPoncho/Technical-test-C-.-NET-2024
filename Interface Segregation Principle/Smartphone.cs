namespace Interface_Segregation_Principle
{
    public class Smartphone : IDevice, IWiFi, IMakeCall
    {
        public void TurnOn()
        {
            Console.WriteLine("Smartphone is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Smartphone is turned off.");
        }

        public void WiFi(string network)
        {
            Console.WriteLine($"Smartphone connected to WiFi network: {network}");
        }

        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber}...");
        }
    }
}