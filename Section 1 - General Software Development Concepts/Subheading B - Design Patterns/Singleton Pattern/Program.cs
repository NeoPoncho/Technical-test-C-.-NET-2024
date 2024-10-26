using Singleton_Pattern;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a value: ");
        string userInput = Console.ReadLine();

        SingletonManager singletonManager = SingletonManager.Instance;
        singletonManager.Singleton = userInput;

        Console.WriteLine($"Value: {singletonManager.Singleton}");

        SingletonManager singletonManager2 = SingletonManager.Instance;
        Console.WriteLine($"Value from another instance: {singletonManager2.Singleton}");
    }
}