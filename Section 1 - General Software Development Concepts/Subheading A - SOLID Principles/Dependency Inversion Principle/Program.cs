using Dependency_Inversion_Principle;

class Program
{
    //Dependency Inversion Principle, as the name implies, high-level modules should depend on abstractions instead of classes.

    static void Main(string[] args)
    {
        IMessageService messageService = new EmailService();
        if (messageService != null)
        {
            MessageService emailService = new(messageService);

            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            emailService.Notify(message);
        }
        else
        {
            Console.WriteLine("Invalid service type.");
        }
    }
}
