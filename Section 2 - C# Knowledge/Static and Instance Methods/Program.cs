namespace Static_and_Instance_Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Static methods are used for operations that don't depend on instances

            Console.Write("First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = Calculate.Add(num1, num2);
            Console.WriteLine($"Sum: {sum}");

            // Instance methods make use of the data specific to an object

            Calculate calculate = new();

            Console.Write("First number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            int product = calculate.Multiply(num3, num4);
            Console.WriteLine($"Product: {product}");
        }
    }
}