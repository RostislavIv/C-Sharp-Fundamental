namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            string result = RepeatingString(str, repeat);
            Console.WriteLine(result);
        }

        private static string RepeatingString(string? str, int count)
        {
            string result = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                result += str;
            }
            return result;
        }
    }
}