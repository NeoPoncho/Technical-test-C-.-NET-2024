namespace String_Reverse
{
    public class Program
    {


        public static void Main()
        {
            Console.Write("Enter a string to reverse: ");
            string stg = Console.ReadLine();

            string reversed = StringReverse.ReverseString(stg);

            Console.WriteLine($"{reversed}");
        }
    }
}