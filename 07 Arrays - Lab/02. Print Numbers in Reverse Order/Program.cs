int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
arr = arr
    .Select(el => el = int.Parse(Console.ReadLine())).ToArray()
    .Reverse().ToArray();
Console.WriteLine(string.Join(" ",arr));
//foreach (int el in arr)
//{
//    Console.Write(el + " ");
//}

//for (int i = 0;i< n; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0;i< n/2; i++)
//{
//    int temp = arr[i];
//    arr[i]= arr[arr.Length-1 - i];
//    arr[arr.Length-1-i]= temp;
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}
