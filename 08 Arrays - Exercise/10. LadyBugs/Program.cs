const string Right = "right";
const string Left = "left";
const string End = "end";
int numOfField = int.Parse(Console.ReadLine());
int[] indexOfBugs = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] field = new int[numOfField]
    .Select(el => 0)
    .ToArray();
foreach (int el in indexOfBugs)
{
    if (0 <= el && el < field.Length)
        field[el] = 1;
}
string command = string.Empty;
while ((command = Console.ReadLine()) != End)
{
    string[] token = command.Split();
    int index = int.Parse(token[0]);
    string direction = token[1];
    int length = int.Parse(token[2]);
    if (direction == Left)
        length *= -1;
    if (0 <= index && index < field.Length 
        && field[index] == 1 
        && (direction == Right || direction == Left))
    {
        field[index] = 0;
        while (true)
        {
            index += length;
            if (0 <= index && index < field.Length)
            {
                if (field[index] == 0)
                {
                    field[index] = 1;
                    break;
                }
            }
            else
                break;
        }
    }
}
Console.WriteLine(string.Join(" ", field));
