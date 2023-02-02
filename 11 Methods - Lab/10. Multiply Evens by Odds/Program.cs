namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int result = SumEvans(num) * SumOdds(num);
            Console.WriteLine(result);
        }

        private static int SumOdds(string num)
        {
            if (num[0] == '-') num = num.Substring(1);
            int sum = num.ToCharArray()
                .Select(x => int.Parse(x.ToString()))
                .Where(x => x % 2 != 0)
                .Sum();
            return sum;
        }

        private static int SumEvans(string num)
        {
            if (num[0] == '-') num = num.Substring(1);
            int sum = num.ToCharArray()
                .Select(x => int.Parse(x.ToString()))
                .Where(x => x % 2 == 0)
                .Sum();
            return sum;
        }
    }
}