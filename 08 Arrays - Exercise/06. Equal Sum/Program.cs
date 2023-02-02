int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
bool isFound = false;
for (int i = 0;i< arr.Length; i++)
{
    int sumLeft = 0;
    for (int j = 0; j < i; j++)
    {
        sumLeft += arr[j];
    }
    int sumRight = 0;
    for (int k = i + 1; k < arr.Length; k++)
    {
        sumRight += arr[k];
    }
    if (sumLeft == sumRight)
    {
        isFound = true;
        Console.WriteLine(i);
        break;
    }
}
if (!isFound)
    Console.WriteLine("no");
