int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int magicNum = int.Parse(Console.ReadLine());
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        int sum = arr[i] + arr[j];
        if (sum == magicNum)
            Console.WriteLine($"{arr[i]} {arr[j]}");
    }
}
