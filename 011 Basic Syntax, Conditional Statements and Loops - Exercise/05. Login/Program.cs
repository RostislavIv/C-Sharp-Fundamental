namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = "";
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }
            int count = 0;
            while (true)
            {
                string input = Console.ReadLine();
                count++;
                if (input == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else if (count < 4) Console.WriteLine("Incorrect password. Try again.");
                else
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
            }
        }
    }
}