namespace Assignment4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input string
            Console.Write("Enter the string: ");
            string mainString = Console.ReadLine();
            Console.Write("Enter the starting position (0-based index): ");
            int startPosition = int.Parse(Console.ReadLine());
            Console.Write("Enter the length of the substring: ");
            int length = int.Parse(Console.ReadLine());
            string extractedSubstring = ExtractSubstring(mainString, startPosition, length);
            Console.WriteLine("\nExtracted Substring: " + extractedSubstring);
        }

        static string ExtractSubstring(string str, int start, int length)
        {
            if (start < 0 || start >= str.Length || start + length > str.Length || length < 0)
            {
                return "Invalid range for substring.";
            }

            char[] substring = new char[length];
            for (int i = 0; i < length; i++)
            {
                substring[i] = str[start + i];
            }

            return new string(substring);
        }
    }


}