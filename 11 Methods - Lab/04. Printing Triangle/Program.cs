namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                PrintLine(i);
            }
            for (int i = num -1; i >= 0; i--)
            {
                PrintLine(i);
            }
        }

        private static void PrintLine(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}