using System;

class TenYears
{
    static void Main()
    {
        Console.Write("Date of birth ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Month of birth ");
        int month=int.Parse(Console.ReadLine());
        Console.Write("Year of birth ");
        int year=int.Parse(Console.ReadLine());
        DateTime birthDay = new DateTime(year, month, day);
        DateTime todaysData = DateTime.Now;
        int mayAge = todaysData.Year - birthDay.Year;
        Console.WriteLine("I am {0} years old", mayAge);
        int afterTenYears = mayAge + 10;
        Console.WriteLine("My Age in 10 years will be: {0}", afterTenYears);

    }
}

