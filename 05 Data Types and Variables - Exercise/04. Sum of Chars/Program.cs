int n = int.Parse(Console.ReadLine());
int sumChars = 0;
for (int i = 0; i < n; i++)
{
    sumChars += char.Parse(Console.ReadLine());
}
Console.WriteLine($"The sum equals: {sumChars}");