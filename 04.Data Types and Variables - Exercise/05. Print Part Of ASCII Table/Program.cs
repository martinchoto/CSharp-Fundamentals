using System;
using System.Transactions;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstRound = int.Parse(Console.ReadLine());
            int secondRound = int.Parse(Console.ReadLine());
            for (int i = firstRound; i <= secondRound; i++)
            {
                char Char = (char)i;
                Console.Write(Char + " ");
            }
        }
    }
}
