namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;
            double totalPrice = 0.0;
            if (type == "Students" && day == "Friday") price = 8.45;
            else if (type == "Students" && day == "Saturday") price = 9.80;
            else if (type == "Students" && day == "Sunday") price = 10.46;
            else if (type == "Business" && day == "Friday") price = 10.90;
            else if (type == "Business" && day == "Saturday") price = 15.60;
            else if (type == "Business" && day == "Sunday") price = 16.00;
            else if (type == "Regular" && day == "Friday") price = 15.00;
            else if (type == "Regular" && day == "Saturday") price = 20.00;
            else if (type == "Regular" && day == "Sunday") price = 22.50;
            totalPrice= price * group;
            if (type == "Students" && group >= 30) totalPrice *= 0.85;
            if (type == "Business" && group >= 100) totalPrice -= 10 * price;
            if (type == "Regular" && 10 <= group && group <= 20) totalPrice *= 0.95;
            Console.WriteLine($"Total price: {totalPrice:f2}");
         }
    }
}