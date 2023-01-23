int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    int sumDigit = 0;
    int curDigit = i;
    while (curDigit > 0)
    {
        sumDigit += curDigit % 10;
        curDigit /= 10;
    }
    if (sumDigit == 5 || sumDigit == 7 || sumDigit == 11)
        Console.WriteLine($"{i} -> True");
    else 
        Console.WriteLine($"{i} -> False");
}
