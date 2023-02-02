double[] arr = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToArray();
foreach(double el in arr)
{
    int result = (int)Math.Round(el, MidpointRounding.AwayFromZero);
    Console.WriteLine($"{el} => {result}");
}