int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sumOddNums = arr
    .Where(el => el % 2 != 0)
    .Sum();
int sumEvenNums = arr
    .Where(el => el % 2 == 0)
    .Sum();
int result = sumEvenNums - sumOddNums;
Console.WriteLine(result);
