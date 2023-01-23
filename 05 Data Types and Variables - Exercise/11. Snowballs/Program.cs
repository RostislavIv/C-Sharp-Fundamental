using System.Numerics;

int n = int.Parse(Console.ReadLine());
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;
BigInteger bestValue = 0;
for (int i = 0; i< n; i++)
{
    int snow = int.Parse(Console.ReadLine());
    int time = int.Parse(Console.ReadLine());
    int quality = int.Parse(Console.ReadLine());
    BigInteger value = BigInteger.Pow(snow / time, quality);
    if (value > bestValue)
    {
        bestValue = value;
        bestQuality = quality;
        bestTime = time;
        bestSnow = snow;
    }
}
Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
