using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOdd = true;
            while (isOdd)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    isOdd = false;
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
