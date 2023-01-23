int n = int.Parse(Console.ReadLine());
int capacity = 255;
int availableWater = 0;
for (int i = 0; i < n; i++)
{
    int receiveWater = int.Parse(Console.ReadLine());
    if (availableWater + receiveWater > capacity)
        Console.WriteLine("Insufficient capacity!");
    else availableWater += receiveWater;
}
Console.WriteLine(availableWater);
