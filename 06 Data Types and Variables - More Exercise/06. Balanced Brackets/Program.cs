int n = int.Parse(Console.ReadLine());
bool isBalanced = true;
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    if (input == "(")
    {
        if (isBalanced) isBalanced = false;
        else
        {
            isBalanced = false;
            break;
        }
    }
    if (input == ")")
    {
        if (!isBalanced) isBalanced = true;
        else
        {
            isBalanced = false;
            break;
        }
    }
}
if (isBalanced)
    Console.WriteLine("BALANCED");
else
    Console.WriteLine("UNBALANCED");