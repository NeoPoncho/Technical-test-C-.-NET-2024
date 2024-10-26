using Open_Closed_Principle;

class Program
{
    //Open/Closed Principle, where we are able to add new functionality to a class without changing its existing code, they can be extended without the need to be modified.

    static void Main(string[] args)
    {
        Console.Write("width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Shape? shape = new Rectangle(width, height);
        if (shape != null)
        {
            Console.WriteLine($"Area: {shape.Area()}");
        }
        else
        {
            Console.WriteLine("Invalid shape.");
        }
    }
}