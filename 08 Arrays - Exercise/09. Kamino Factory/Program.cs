int n = int.Parse(Console.ReadLine());
int[] bestDNA = new int[n];
int bestLength = -1;
int firstIndex = 0;
int bestSequenceIndex = 0;
int index = 0;
string command = Console.ReadLine();
while (command != "Clone them!")
{
    index++;
    int[] arr = command
        .Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    int curLength = 0;
    int curMaxLen = 0;
    int curFirstInd = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] == 1) 
            curLength++;
        else 
            curLength = 0;
        if (curLength > curMaxLen)
        {
            curMaxLen = curLength;
            curFirstInd = i - curLength + 1;
        }
    }
    bool isBest = false;
    if (curMaxLen > bestLength)
        isBest = true;
    else if (curMaxLen == bestLength)
    {
        if (curFirstInd < firstIndex)
            isBest = true;
        else if (curFirstInd == firstIndex)
        {
            if (arr.Sum() > bestDNA.Sum())
                isBest = true;
        }
    }
    if (isBest)
    {
        bestLength = curMaxLen;
        firstIndex = curFirstInd;
        bestDNA = arr;
        bestSequenceIndex = index;
    }
    command = Console.ReadLine();
}
Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestDNA.Sum()}.");
Console.WriteLine(string.Join(" ", bestDNA));
