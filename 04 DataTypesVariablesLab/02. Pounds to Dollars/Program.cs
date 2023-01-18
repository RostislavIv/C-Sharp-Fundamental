decimal dolars = 0;
decimal.TryParse(Console.ReadLine(),out dolars);
decimal pounds = dolars * 1.31m;
Console.WriteLine($"{pounds:f3}");
