namespace _06._Strong_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = num;
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                n = n / 10;
                int factorials = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorials *= i;    
                }
                sum += factorials;
            }
            if (sum == num) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}