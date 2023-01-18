int mtrs = 0;
int.TryParse(Console.ReadLine(), out mtrs);
double kms = mtrs / 1000.0;
Console.WriteLine($"{kms:f2}");