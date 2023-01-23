using System.Reflection.Metadata.Ecma335;

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string left = input.Split(" ")[0];
    string right = input.Split(" ")[1];
    int sumLeft = 0;
    for (int j = 0; j < left.Length; j++)
    {
        int digit = 0;
        if (int.TryParse(left[j].ToString(), out digit))
            sumLeft+= digit;
    }
    int sumRight = 0;
    for (int j = 0; j < right.Length; j++)
    {
        int digit = 0;
        if (int.TryParse(right[j].ToString(), out digit))
            sumRight += digit;
    }



    //long left = Math.Abs(long.Parse(input.Split(" ")[0]));
    //long right = Math.Abs(long.Parse(input.Split(" ")[1]));
    //long sumLeft = 0;
    //while (left > 0)
    //{
    //    sumLeft += (int)(left % 10);
    //    left /= 10;
    //}
    //int sumRight = 0;
    //while (right > 0)
    //{
    //    sumRight += (int)(right % 10);
    //    right /= 10;
    //}
    if (double.Parse(left) > double.Parse(right))
        Console.WriteLine(sumLeft);
    else
        Console.WriteLine(sumRight);
}
