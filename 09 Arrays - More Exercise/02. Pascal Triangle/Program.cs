using System.Globalization;

int n = int.Parse(Console.ReadLine());
int cur = 0;
int[] arr1 = {};
for (int i = 0; i < n; i++)
{
    int[] arr2 = new int[i+1];
    Array.Fill(arr2, 1);
    for (int j = 1; j < i; j++)
    {
        arr2[j] = arr1[j - 1] + arr1[j];
    }
    Console.Write(string.Join(" ", arr2));
    Console.WriteLine();
    arr1 = arr2;
}
