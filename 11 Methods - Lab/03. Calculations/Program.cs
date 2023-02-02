namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            switch (operation)
            {
                case "add":Add(num1, num2);break;
                case "multiply": Multiply(num1, num2);break;
                case "subtract": Subtract(num1, num2);break;
                case "divide": Divide(num1, num2);break;
            }
        }

        private static void Divide(double num1, double num2)
        {
            double result = num1/ num2;
            Console.WriteLine(result);
        }

        private static void Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine(result);
        }

        private static void Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine(result);
        }

        private static void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine(result);
        }
    }
}