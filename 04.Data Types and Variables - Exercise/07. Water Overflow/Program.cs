using System;
using System.Diagnostics;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                sum += litres;
                if (sum > 255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    sum -= litres;
                    continue;
                }
            }
            Console.WriteLine(sum);
         
        }
    }
}
