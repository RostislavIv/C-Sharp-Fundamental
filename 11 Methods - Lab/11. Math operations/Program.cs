namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double result = GetCalculate(a,@operator,b);
            Console.WriteLine(result);
        }

        private static double GetCalculate(int a, string? @operator, int b)
        {
            double result = 0;
            switch (@operator)
            {
                case "+": result = (double)(a+b); break;
                case "-": result = (double)(a - b); break;
                case "*": result = (double)(a * b); break;
                case "/": result = (double)a / b; break;
            }
            return result;

        }
    }
}