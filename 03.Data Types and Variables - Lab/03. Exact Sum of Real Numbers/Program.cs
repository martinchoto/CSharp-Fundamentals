using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0M;
            for (int i = 0; i < num; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                sum += numbers;
            }
            Console.WriteLine(sum);
        }
    }
}
