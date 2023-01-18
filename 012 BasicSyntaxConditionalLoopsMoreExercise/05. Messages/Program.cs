namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alf = " abcdefghijklmnopqrstuvwxyz";
            string message = "";
            int messageLength = int.Parse(Console.ReadLine());
            for (int i = 1; i <= messageLength; i++) 
            {
                string num = Console.ReadLine();
                switch (num[0])
                {
                    case '0': message += alf[0].ToString(); break;
                    case '2': message += alf[0 + num.Length].ToString(); break;
                    case '3': message += alf[3 + num.Length].ToString(); break;
                    case '4': message += alf[6 + num.Length].ToString(); break;
                    case '5': message += alf[9 + num.Length].ToString(); break;
                    case '6': message += alf[12 + num.Length].ToString(); break;
                    case '7': message += alf[15 + num.Length].ToString(); break;
                    case '8': message += alf[19 + num.Length].ToString(); break;
                    case '9': message += alf[22 + num.Length].ToString(); break;
                }
            }
            Console.WriteLine(message);
        }
    }
}