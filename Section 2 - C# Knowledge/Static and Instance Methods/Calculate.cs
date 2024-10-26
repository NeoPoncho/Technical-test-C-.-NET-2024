namespace Static_and_Instance_Methods
{
    public class Calculate
    {
        // Static methods are used for operations that don't depend on instances
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        // Instance methods make use of the data specific to an object
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
