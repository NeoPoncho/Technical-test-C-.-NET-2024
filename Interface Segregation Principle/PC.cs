namespace Interface_Segregation_Principle
{
    public class PC : IDevice, IWiFi
    {
        public void TurnOn()
        {
            Console.WriteLine("PC is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("PC is turned off.");
        }

        public void WiFi(string network)
        {
            Console.WriteLine($"PC connected to WiFi network: {network}");
        }
    }
}