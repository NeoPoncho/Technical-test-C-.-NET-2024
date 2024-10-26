using Single_Responsibility_Class;

class Program
{
    //Single Responsibility Class, where the purpose of a classe is singular, meaning it has only one job.

    static void Main(string[] args)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter email: ");
        string email = Console.ReadLine();

        User user = new() { Name = name, Email = email };

        EmailService.SendEmail(user.Email, $"Welcome, {user.Name}!");
    }
}