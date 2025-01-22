namespace Assignment4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input string
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            int alphabetCount = 0, digitCount = 0, specialCharCount = 0;
            foreach (char c in inputString)
            {
                if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine($"\nTotal number of alphabets: {alphabetCount}");
            Console.WriteLine($"Total number of digits: {digitCount}");
            Console.WriteLine($"Total number of special characters: {specialCharCount}");
        }
    }
}
