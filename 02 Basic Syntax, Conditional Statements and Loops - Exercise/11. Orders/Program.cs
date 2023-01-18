namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int numOfOrder = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numOfOrder; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                double sum = days * capsules * price;
                total+= sum;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}