const string Vowel = "aeiouAEIOU";
//const string Consonant = "bcdfghjklmnpqrstvwxyz";
int n = int.Parse(Console.ReadLine());
int[] result = new int[n];
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    for (int j = 0; j < name.Length; j++)
    {
        if (Vowel.Contains(name[j]))
        {
            result[i] += name[j] * name.Length;
        }

        else //if (Consonant.Contains(name[j].ToString().ToLower()))
        {
            result[i] += name[j] / name.Length;
        }
    }
}
Array.Sort(result);
foreach (int el in result)
    Console.WriteLine(el);