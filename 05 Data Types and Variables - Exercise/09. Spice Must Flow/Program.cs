int yield = int.Parse(Console.ReadLine());
int spice = 0;
int days = 0;
while (yield >= 100)
{
    days++;
    spice += yield;
    if (spice > 26)
        spice -= 26;
    else
        spice = 0;
    yield -= 10;
}
if (spice > 26)
    spice -= 26;
else
    spice = 0;
Console.WriteLine(days);
Console.WriteLine(spice);
