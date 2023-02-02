string[] daysOfWeek =  { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
int numOfDay = int.Parse(Console.ReadLine());
if (1 <= numOfDay && numOfDay <= 7)
    Console.WriteLine(daysOfWeek[numOfDay - 1]);
else
    Console.WriteLine("Invalid day!");
