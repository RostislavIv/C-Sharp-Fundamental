
using System.Linq;

int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] longest = { arr[0] };
for (int i = 1;i< arr.Length; i++)
{
    string result = arr[i - 1].ToString() + " ";
    int prev = arr[i - 1];
    int index = i;
    while (index < arr.Length)
    {
        int cur = int.MaxValue;
        bool isFound = false;
        for (int j = index; j < arr.Length; j++)
        {
            if (arr[j] > prev && arr[j] < cur)
            {
                cur = arr[j];
                index = j;
                isFound = true;
            }
        }
        if (isFound)
        {
            result += cur.ToString() + " ";
            prev = cur;
        }
        index++;
    }
    int[] curResult = result.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    if (curResult.Length > longest.Length) { longest = curResult; }
}
Console.WriteLine(string.Join(" ",longest));