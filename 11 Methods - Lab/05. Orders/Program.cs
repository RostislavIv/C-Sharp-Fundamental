namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double coffeePrice = 1.5;
            const double waterPrice = 1;
            const double cokePrice = 1.4;
            const double snacksPrice = 2;
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee": PrintCheck(quantity, coffeePrice); break;
                case "water": PrintCheck(quantity, waterPrice); break;
                case "coke": PrintCheck(quantity, cokePrice); break;
                case "snacks": PrintCheck(quantity, snacksPrice); break;
            }

        }
        private static void PrintCheck(int quantity, double price)
        {
            double check = quantity * price;
            Console.WriteLine($"{check:f2}");
        }
    }
}