namespace Single_Responsibility_Class
{
    public class EmailService
    {
        public static void SendEmail(string email, string message)
        {
            Console.WriteLine($"Email sent to {email}: {message}");
        }
    }
}
