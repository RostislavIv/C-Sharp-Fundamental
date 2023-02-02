string[] arr1 = Console.ReadLine().Split();
string[] arr2 = Console.ReadLine().Split();
string[] result = new string[arr1.Length];
for (int i = 0; i < arr2.Length; i++)
{
    if (arr1.Contains(arr2[i]))
        Console.Write(arr2[i] + " ");
}