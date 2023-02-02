int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int length = input.Length;
int[] arr1 = new int[length / 4];
int[] arr2 = new int[length / 2];
int[] arr3 = new int[length / 4];


Array.Copy(input, 0, arr1, 0, input.Length / 4);
Array.Copy(input, length / 4, arr2, 0, input.Length / 2);
Array.Copy(input, length * 3 / 4, arr3, 0, input.Length / 4);
Array.Reverse(arr1);
Array.Reverse(arr3);
Array.Resize(ref arr1, length / 2);
Array.Copy(arr3, 0, arr1, length / 4, length / 4);
for (int i = 0;i< length / 2; i++)
{
    arr1[i] += arr2[i];
}
Console.WriteLine(string.Join(" ", arr1));

;

