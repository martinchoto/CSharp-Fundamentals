using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            long sum = num1 + num2;
            long devision = sum / num3;
            long multiply = devision * num4;
            Console.WriteLine(multiply);
        }
    }
}
