namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int length = 0;
            foreach (char c in input)
            {
                length++;
            }
            Console.WriteLine($"\nThe length of the string is: {length}");

        }
    }
}
