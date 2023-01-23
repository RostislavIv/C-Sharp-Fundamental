int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    int sum = 0;
    int curNum = i;
    while (curNum > 0)
    {
        sum += curNum % 10;
        curNum = curNum / 10;
    }
    bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", i, isSpecial);
}
