﻿namespace _10._Rage_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headset = games / 2;
            int mouse = games / 3;
            int keyboard = games / 6;
            int display = keyboard / 2;
            double total = headset * headsetPrice + mouse * mousePrice + keyboard * keyboardPrice + display * displayPrice;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}