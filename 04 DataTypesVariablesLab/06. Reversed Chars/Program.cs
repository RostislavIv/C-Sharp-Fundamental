string input = "";
for (int i = 0; i < 3; i++)
{
    input += char.Parse(Console.ReadLine());
}
string result = "";
for (int i = input.Length - 1; i >= 0; i--)
{
    result += input[i] + " ";
}
Console.WriteLine(result);