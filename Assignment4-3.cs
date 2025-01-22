namespace Assignment4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            int wordCount = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count();
            Console.WriteLine($"The total number of words in the string is: {wordCount}");
        }
    }
}