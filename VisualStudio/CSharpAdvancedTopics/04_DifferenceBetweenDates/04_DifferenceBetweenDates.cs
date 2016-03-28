using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Enter first date: ");
        DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Enter second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine()); 

        int days = Days(firstDate, secondDate);
        Console.Write("Days between dates: " + days);
        Console.WriteLine();
    }

    static int Days (DateTime start, DateTime end)
    {
        TimeSpan interval = end - start;
        int result = (int)(interval.TotalDays);

        return result;
    }
}

