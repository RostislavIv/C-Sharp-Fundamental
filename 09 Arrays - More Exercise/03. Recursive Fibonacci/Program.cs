
int positionInFibonacciSequence = int.Parse(Console.ReadLine());
if (1 <= positionInFibonacciSequence &&positionInFibonacciSequence <= 50)
{
    long result = FibonachiRecursion(positionInFibonacciSequence);
    Console.WriteLine(result);
    static long FibonachiRecursion(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        return FibonachiRecursion(n - 1) + FibonachiRecursion(n - 2);
    }
}
