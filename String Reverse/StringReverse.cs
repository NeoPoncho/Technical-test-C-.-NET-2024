namespace String_Reverse
{
    public class StringReverse
    {
        public static string ReverseString(string stg)
        {
            char[] charArray = stg.ToCharArray();

            int stringLeft = 0;
            int stringRight = charArray.Length - 1;

            while (stringLeft < stringRight)
            {
                (charArray[stringRight], charArray[stringLeft]) = (charArray[stringLeft], charArray[stringRight]);
                stringLeft++;
                stringRight--;
            }

            return new string(charArray);
        }
    }
}
