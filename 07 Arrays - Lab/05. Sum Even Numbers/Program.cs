int sumEvenNums = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .Where(el => el % 2 == 0)
    .Sum();
Console.WriteLine(sumEvenNums);
