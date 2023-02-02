namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double higth = int.Parse(Console.ReadLine());
            double width = int.Parse(Console.ReadLine());
            double area = GetAreaRectangle(higth, width);
            Console.WriteLine(area);
        }

        private static double GetAreaRectangle(double higth, double width)
        {
            double area = higth * width;
            return area;
        }
    }
}