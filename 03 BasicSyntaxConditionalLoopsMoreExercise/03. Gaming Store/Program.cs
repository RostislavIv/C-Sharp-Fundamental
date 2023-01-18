using System.Data.SqlTypes;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double remaining = money;
            string game = Console.ReadLine();
            while (game != "Game Time")
            {
                double gamePrice = 0;
                switch (game)
                {
                    case "OutFall 4": gamePrice = 39.99; break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                }
                if (gamePrice == 0)
                {
                    Console.WriteLine("Not Found");
                }
                else if (gamePrice > remaining)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    remaining -= gamePrice;
                    Console.WriteLine($"Bought {game}");
                }
                if (remaining == 0.0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                game = Console.ReadLine();
            }
            if (remaining != 0.0) Console.WriteLine($"Total spent: ${money - remaining:f2}. Remaining: ${remaining:f2}");
        }
    }
}