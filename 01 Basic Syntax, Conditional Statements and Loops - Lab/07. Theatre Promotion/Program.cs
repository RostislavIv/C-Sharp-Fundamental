using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            bool isValidAge = true;
            if (typeOfDay == "Weekday")
            {
                if (0 <= age && age <= 18) price = 12;
                else if (18 < age && age <= 64) price = 18;
                else if (64 < age && age <= 122) price = 12;
                else isValidAge = false;
            }
            else if (typeOfDay == "Weekend")
            {
                if (0 <= age && age <= 18) price = 15;
                else if (18 < age && age <= 64) price = 20;
                else if (64 < age && age <= 122) price = 15;
                else isValidAge = false;
            }
            else if (typeOfDay == "Holiday")
            {
                if (0 <= age && age <= 18) price = 5;
                else if (18 < age && age <= 64) price = 12;
                else if (64 < age && age <= 122) price = 10;
                else isValidAge = false;
            }
            if (isValidAge) Console.WriteLine($"{price}$");
            else Console.WriteLine("Error!");
        }
    }
}
