﻿byte n = byte.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            string result = $"{(char)('a' + i)}{(char)('a' + j)}{(char)('a' + k)}";
            Console.WriteLine(result);
        }
    }
}
