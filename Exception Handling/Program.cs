using System.Diagnostics;

namespace Exception_Handling
{
    //Excetion Handling allows the code to continue running without it failing or crashing the program. It also helps with debugging, by logging the related error messages.

    public class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            string? input = null;

            while (input == null)
            {
                try
                {
                    DisplayLength(input);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("String cannot be null.");
                    Debug.WriteLine("Error: The input cannot be null.");
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        public static void DisplayLength(string stg)
        {
            if (stg == null)
            {
                throw new ArgumentNullException(nameof(stg), "String cannot be null.");
            }

            Debug.WriteLine($"Length: {stg.Length}");
        }
    }
}