namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSing(num);
        }

        private static void PrintSing(int number)
        {
            int sing = Math.Sign(number);
            switch (sing)
            {
                case -1: Console.WriteLine($"The number {number} is negative."); break;
                case 0: Console.WriteLine($"The number {number} is zero."); break;
                case 1: Console.WriteLine($"The number {number} is positive."); break;
            }
        }
    }
}