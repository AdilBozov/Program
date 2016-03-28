using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower(); 
        int oddJump = int.Parse(Console.ReadLine()); 
        int evenJump = int.Parse(Console.ReadLine());
        BigInteger sumOdd = 0;
        BigInteger sumEven = 0;
        int indexSum = 0;
        int sumEve = 0;
        List<char> inputChar = new List<char>();
        List<char> oddlist = new List<char>();
        List<char> evenList = new List<char>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                continue;
            }
            else
            {
                inputChar.Add(input[i]);
            }
        }

        for (int i = 0; i < inputChar.Count; i++)
        {
            if (i % 2 == 0)
            {
                oddlist.Add(inputChar[i]);
            }
            else
            {
                evenList.Add(inputChar[i]);
            }
        }

        for (int i = 0; i < oddlist.Count; i++)
        {
            indexSum++;
            if (indexSum % oddJump == 0 && i != 0 && i != 1)
            {
                sumOdd = sumOdd * oddlist[i];
            }
            else
            {
                sumOdd += oddlist[i];
            }

            if (indexSum == oddJump)
            {
                indexSum = 0;
            }
        }

        for (int i = 0; i < evenList.Count; i++)
        {
            sumEve++;
            if (sumEve % evenJump == 0 && i != 0)
            {
                sumEven = sumEven * evenList[i];
            }
            else
            {
                sumEven += evenList[i];
            }

            if (sumEve == evenJump)
            {
                sumEve = 0;
            }
        }

        for (int i = 0; i < 2; i++)
        {
            BigInteger dec = 0;
            if (i==0)
            {
                dec = sumOdd;
            }
            else
            {
                dec = sumEven;
            }

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
            if (i==0)
            {
                Console.WriteLine("Odd: "+printConsole);
            }
            else
            {
                Console.WriteLine("Even: "+printConsole);
            }
        }
    }

}