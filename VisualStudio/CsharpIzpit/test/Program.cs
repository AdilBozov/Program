using System;
using System.Numerics;

class DecimalToHexadecimalNumber_16
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        BigInteger dec = BigInteger.Parse(Console.ReadLine());
        BigInteger res;
        string printConsole = string.Empty;

        while (dec > 0)
        {
            res = dec % 16;
            dec = dec / 16;
            string print = string.Empty;
            if (res >= 10 && 15 >= res)
            {
                switch ((int)res)
                {
                    case 10: print = "A";
                        break;
                    case 11: print = "B";
                        break;
                    case 12: print = "C";
                        break;
                    case 13: print = "D";
                        break;
                    case 14: print = "E";
                        break;
                    case 15: print = "F";
                        break;
                    default:
                        break;
                }
                printConsole = print + printConsole;
            }
            else
            {
                printConsole = res.ToString() + printConsole;
            }
        }
        Console.WriteLine(printConsole);
    }
}
