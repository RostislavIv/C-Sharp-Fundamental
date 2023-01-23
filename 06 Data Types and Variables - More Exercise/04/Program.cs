int key = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
string result = "";
for (int i = 0;i< n; i++)
{
    char chr = char.Parse(Console.ReadLine());
    result+= (char)(chr + key);
}
Console.WriteLine(result);