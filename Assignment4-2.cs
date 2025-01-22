namespace Assignment4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a string: ");
            string input = Console.ReadLine();
            Console.Write("reverse of the string is:");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

        }
    }
}
