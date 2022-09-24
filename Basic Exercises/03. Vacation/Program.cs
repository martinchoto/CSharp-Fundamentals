using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePerPerson = 0;
            double totalPrice = 0;
            if (type == "Students" && day == "Friday")
            {
                pricePerPerson = 8.45;
            }
            else if (type == "Students" && day == "Saturday")
            {
                pricePerPerson = 9.80;
            }
            else if (type == "Students" && day == "Sunday")
            {
                pricePerPerson = 10.46;
            }
            else if (type == "Business" && day == "Friday")
            {
                pricePerPerson = 10.90;
            }
            else if (type == "Business" && day == "Saturday")
            {
                pricePerPerson = 15.60;
            }
            else if (type == "Business" && day == "Sunday")
            {
                pricePerPerson = 16;
            }
            else if (type == "Regular" && day == "Friday")
            {
                pricePerPerson = 15;
            }
            else if (type == "Regular" && day == "Saturday")
            {
                pricePerPerson = 20;
            }
            else if (type == "Regular" && day == "Sunday")
            {
                pricePerPerson = 22.50;
            }
            totalPrice = people * pricePerPerson;
            if (type == "Students" && people >= 30)
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (type == "Business" && people >= 100)
            {
                totalPrice = totalPrice - (pricePerPerson * 10);
            }
            else if (type == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice = totalPrice * 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");


        }
    }
}