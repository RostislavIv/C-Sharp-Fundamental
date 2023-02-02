const string Clone = "Clone them!";
int lengthDNA = int.Parse(Console.ReadLine());
int[] bestDNA = new int[lengthDNA];
int indexBestDNA = 0;
int lengthBestDNA = -1;
int numberBestDNA = 0;
int numberCurDNA = 0;
string command = string.Empty;
while ((command = Console.ReadLine()) != Clone)
{
    numberCurDNA++;
    int[] curDNA = command
        .Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    int indexCurDNA = 0;
    int lengthCurDNA = 0;
    int counter = 0;
    for (int i = 0; i < curDNA.Length; i++)
    {
        if (curDNA[i] == 1)
        {
            counter++;
            if (counter > lengthCurDNA)
            {
                lengthCurDNA = counter;
                indexCurDNA = i - counter;
            }
        }
        else
            counter = 0;
    }
    bool isBest = false;
    if (lengthCurDNA > lengthBestDNA)
        isBest = true;
    else if (lengthCurDNA == lengthBestDNA)
    {
        if (indexCurDNA < indexBestDNA)
            isBest = true;
        else if (indexCurDNA == indexBestDNA)
        {
            if (curDNA.Sum() > bestDNA.Sum())
                isBest = true;
        }
    }
    if (isBest)
    {
        bestDNA = curDNA;
        lengthBestDNA = lengthCurDNA;
        indexBestDNA = indexCurDNA;
        numberBestDNA = numberCurDNA;
    }
}
Console.WriteLine($"Best DNA sample {numberBestDNA} with sum: {bestDNA.Sum()}.");
Console.WriteLine(string.Join(" ", bestDNA));