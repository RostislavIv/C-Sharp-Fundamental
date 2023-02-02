namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pwr = int.Parse(Console.ReadLine());
            double result = MathPwr(num, pwr);
            Console.WriteLine(result);
        }

        private static double MathPwr(double num, int pwr)
        {
            double result = 1;
            for (int i =1; i <= pwr; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}