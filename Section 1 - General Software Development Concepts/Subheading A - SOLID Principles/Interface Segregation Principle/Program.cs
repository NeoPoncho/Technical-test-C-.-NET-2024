namespace Interface_Segregation_Principle
{
    class Program
    {
        //Interface Segregation Principle, where the code should not implement methods it won't be using.

        static void Main(string[] args)
        {
            Console.Write("Choose device (pc/smartphone): ");
            string deviceType = Console.ReadLine();

            IDevice device;

            if (deviceType.Equals("pc", StringComparison.OrdinalIgnoreCase))
            {
                PC pc = new();
                device = pc;

                pc.TurnOn();

                Console.Write("Enter WiFi network for PC: ");
                string network = Console.ReadLine();

                pc.WiFi(network);
            }
            else if (deviceType.Equals("smartphone", StringComparison.OrdinalIgnoreCase))
            {
                Smartphone smartphone = new();
                device = smartphone;

                smartphone.TurnOn();

                Console.Write("Enter WiFi network for Smartphone: ");
                string network = Console.ReadLine();

                smartphone.WiFi(network);

                Console.Write("Enter phone number to call: ");
                string phoneNumber = Console.ReadLine();

                smartphone.MakeCall(phoneNumber);
            }
            else
            {
                Console.WriteLine("Invalid device.");
                return;
            }

            device?.TurnOff();
        }
    }
}