int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
arr = arr.Select(el => el = int.Parse(Console.ReadLine()))
    .ToArray();
Console.WriteLine(string.Join(" ", arr));
Console.WriteLine(arr.Sum());