using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        double floors = double.Parse(Console.ReadLine());
        double flast = double.Parse(Console.ReadLine());
        DateTime time = DateTime.Parse(Console.ReadLine());
        int hh = time.Hour;
        int mm = time.Minute;
        double lamps = 100.53;
        double comp = 125.90;
        double rum = flast * floors;
        double sumWatts = 0;
        int rezult = 0;

        if (hh >= 14 && hh <= 18)
        {
            if (mm >= 00 && mm <= 59)
            {
                sumWatts = 2 * lamps + 2 * comp;
            }
        }
        else if (hh >= 19 && hh <= 23)
        {
            if (mm >= 00 && mm <= 59)
            {
                sumWatts = 7 * lamps + 6 * comp;
            }
        }
        else if (hh >= 00 && hh <= 08)
        {
            if (mm >= 00 && mm <= 59)
            {
                sumWatts = 1 * lamps + 8 * comp;
            }
        }

        rezult = (int)(rum * sumWatts);
        Console.WriteLine(rezult+" Watts");  
    }
}