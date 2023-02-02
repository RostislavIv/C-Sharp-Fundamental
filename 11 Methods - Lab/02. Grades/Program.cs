namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }

        private static void PrintGrade(double grade)
        {
            if (2 <= grade && grade < 3) Console.WriteLine("Fail");
            if (3 <= grade && grade < 3.5) Console.WriteLine("Poor");
            if (3.5 <= grade && grade < 4.5) Console.WriteLine("Good");
            if (4.5 <= grade && grade < 5.5) Console.WriteLine("Very good");
            if (5.5 <= grade && grade <= 6) Console.WriteLine("Excellent");
        }
    }
}