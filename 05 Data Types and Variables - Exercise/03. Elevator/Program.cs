int numOfPersones = int.Parse(Console.ReadLine());
int capacyty = int.Parse(Console.ReadLine());
int courses = (int)Math.Ceiling((double)numOfPersones / capacyty);
Console.WriteLine(courses);
