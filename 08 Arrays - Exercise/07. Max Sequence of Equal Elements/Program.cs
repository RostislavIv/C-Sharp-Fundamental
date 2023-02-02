int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int bestSequence = 1;
int bestValue = arr[0];
int counter = 1;
for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] == arr[i + 1])
    {
        counter++;
    }
    else
    {
        counter = 1;
    }
    if (counter > bestSequence)
    {
        bestSequence = counter;
        bestValue = arr[i];
    }
}
int[] result = new int[bestSequence]
    .Select(el => bestValue)
    .ToArray();
Console.WriteLine(string.Join(" ", result));



//int maxLength = 1;
//int curLength = 1;
//int maxValue = arr[0];
//for (int i = 1;i< arr.Length; i++)
//{
//    int cur = arr[i];
//    int last = arr[i - 1];
//    if (cur == last)
//    {
//        curLength++;
//        if (i == arr.Length - 1 && curLength > maxLength)
//        {
//            maxLength = curLength;
//            maxValue = cur;
//        }
//    }
//    else
//    {
//        if (curLength > maxLength)
//        {
//            maxLength = curLength;
//            maxValue = last;
//        }
//        curLength = 1;
//    }
//}
//int[] result = new int[maxLength]
//    .Select(el => maxValue)
//    .ToArray();
//Console.WriteLine (string.Join(" ", result));
