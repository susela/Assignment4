namespace Assignment4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input string 1
            Console.Write("enter the first string: ");
            string str1 = Console.ReadLine();
            //input string 2
            Console.Write("enter the second string: ");
            string str2 = Console.ReadLine();
            //comparison
            bool areEqual = CompareStrings(str1, str2);
            if (areEqual)
            {
                Console.WriteLine("  strings are equal.");
            }
            else
            {
                Console.WriteLine("  strings are not equal.");
            }
        }
        //comparing the length of the strings
        static bool CompareStrings(string str1, string str2)
        {
            if (GetLength(str1) != GetLength(str2))
            {
                return false;
            }
            for (int i = 0; i < GetLength(str1); i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }

            return true;
        }

        static int GetLength(string str)
        {
            int length = 0;
            foreach (char c in str)
            {
                length++;
            }
            return length;
        }



    }
}
