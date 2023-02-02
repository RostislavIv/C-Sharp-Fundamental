int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
for (int i = arr.Length -1;i>0; i--)
{
    for (int j =0; j < i; j++)
    {
        arr[j] += arr[j + 1];
    }
}
Console.WriteLine(arr[0]);

