using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    /*
     using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
static void Main()
{
    var startDate = DateTime.ParseExact(Console.ReadLine(),
        "dd.m.yyyy", CultureInfo.InvariantCulture);
    var endDate = DateTime.ParseExact(Console.ReadLine(),
        "dd.m.yyyy", CultureInfo.InvariantCulture);
    var holidaysCount = 0;
    for (var date = startDate; date <= endDate; date.AddDays(1))
        if (date.DayOfWeek == DayOfWeek.Saturday &&
            date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
    Console.WriteLine(holidaysCount);
}
}

     */
    {
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
           "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        }

        Console.WriteLine(holidaysCount);
    }
}
