int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int startIndex = 0;
string printLine = string.Empty;
while (startIndex < arr.Length)
{
    int maxvalue = int.MinValue;
    for (int i = startIndex; i < arr.Length; i++)
    {
        if (arr[i] >= maxvalue)
        {
            maxvalue = arr[i];
            startIndex = i + 1;
        }
    }
    printLine += maxvalue + " ";
}
Console.WriteLine(printLine);

