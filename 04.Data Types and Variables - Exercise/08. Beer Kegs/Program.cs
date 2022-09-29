using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double volume = 0;
            string biggestKeg = string.Empty;
            double biggestVol = double.MinValue;
            for (int i = 0; i < input; i++)
            {
                string keg = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                ulong height = ulong.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > biggestVol)
                {
                    biggestKeg = keg;
                    biggestVol = volume;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
