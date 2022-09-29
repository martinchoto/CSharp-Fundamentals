using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double courses = double.Parse(Console.ReadLine());
            double people = double.Parse(Console.ReadLine());
            double output = Math.Ceiling(courses / people);
            Console.WriteLine(output);

        }
    }
}
