string[] arr = Console.ReadLine()
    .Split()
    .Reverse()
    .ToArray();
Console.WriteLine(string.Join(" ", arr));
