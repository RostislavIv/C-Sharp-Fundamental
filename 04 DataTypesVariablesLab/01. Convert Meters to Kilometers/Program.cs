int mtrs = 0;
int.TryParse(Console.ReadLine(), out mtrs);
double kms = mtrs / 1000.000;
Console.WriteLine($"{kms:f2}");