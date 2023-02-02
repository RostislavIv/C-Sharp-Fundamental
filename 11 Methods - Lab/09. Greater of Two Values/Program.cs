namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string result = GetMax(str1, str2);
                Console.WriteLine(result);
            }
            else if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int result = GetMax(num1, num2);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char chr1 = char.Parse(Console.ReadLine());
                char chr2 = char.Parse(Console.ReadLine());
                char result = GetMax(chr1, chr2);
                Console.WriteLine(result);
            }

        }

        private static string GetMax(string? str1, string? str2)
        {
            int compare = string.Compare(str1, str2);
            if (compare == 1)
                return str1;
            else
                return str2;
        }

        private static int GetMax(int num1, int num2)
        {
            if (num1 > num2) 
                return num1;
            else 
                return num2;
        }

        private static char GetMax(char chr1, char chr2)
        {
            if (chr1 > chr2) 
                return chr1;
            else 
                return chr2;
        }
    }
}