using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surrname = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{name}{delimiter}{surrname}");
        }
    }
}
