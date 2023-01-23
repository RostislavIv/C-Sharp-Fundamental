int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int count = 0;
int originalPower = n;
while (n >= m)
{
    count++;
    n -= m;
    if (originalPower % 2 == 0 && originalPower / 2 == n)
        n /= y;
}
Console.WriteLine(n);
Console.WriteLine(count);

