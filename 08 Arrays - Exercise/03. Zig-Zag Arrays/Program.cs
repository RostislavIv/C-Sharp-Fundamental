int n = int.Parse(Console.ReadLine());
int[] arr1 = new int[n];
int[] arr2 = new int[n];
for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        arr1[i] = int.Parse(Console.ReadLine());
        arr2[i] = int.Parse(Console.ReadLine());
    }
    else
    {
        arr2[i] = int.Parse(Console.ReadLine());
        arr1[i] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine(string.Join(" ", arr1));
Console.WriteLine(string.Join(" ", arr2));