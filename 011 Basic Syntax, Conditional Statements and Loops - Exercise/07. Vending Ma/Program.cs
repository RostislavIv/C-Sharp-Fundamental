using System;

namespace _07._Vending_Ma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 0.0;
            string input = Console.ReadLine();
            while (input != "Start")
            {
                double coin = double.Parse(input);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1.0 || coin == 2.0)
                    money += coin;
                else Console.WriteLine($"Cannot accept {coin}");
                input = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                double price = 0;
                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (price > 0)
                {
                    if (money >= price)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        money -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {money:N2}");
        }
    }
}