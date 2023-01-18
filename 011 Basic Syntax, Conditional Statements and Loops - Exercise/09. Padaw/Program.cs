namespace _09._Padaw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            lightsabersPrice *= students + Math.Ceiling(students * 0.1);
            robesPrice *= students;
            int numOfBelt = students - students / 6;
            beltsPrice *= numOfBelt;
            double price = lightsabersPrice + robesPrice + beltsPrice;
            if (money >= price) Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            else Console.WriteLine($" John will need {(price - money):f2}lv more.");
        }
    }
}