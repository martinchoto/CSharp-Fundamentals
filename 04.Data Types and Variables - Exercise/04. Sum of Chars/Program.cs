using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfChars = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numOfChars; i++)
            {
                char alphabet = char.Parse(Console.ReadLine());
                sum += (int)alphabet;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
