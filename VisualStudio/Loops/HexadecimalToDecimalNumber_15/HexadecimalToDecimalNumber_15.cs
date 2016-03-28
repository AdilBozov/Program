using System;
using System.Numerics;

class HexadecimalToDecimalNumber_15
{
    static void Main()
    {
        Console.Write("Enter the hexadecimal number: ");
        string order = Console.ReadLine();
        BigInteger dec = 0;
        BigInteger sum = 0;
        for (int i = 0; i < order.Length; i++)
        {
            BigInteger value = 1;
            char c = order[i];
            if ((c >= 'a' && 'f' <= c)||c == 'A' || c == 'B' || c=='C' || c=='D' || c=='E' || c=='F' )
            {
                switch (order[i])
                {
                    case 'a': value = 10;
                        break;
                    case 'A': value = 10;
                        break;
                    case 'b': value = 11;
                        break;
                    case 'B': value = 11;
                        break;
                    case 'c': value = 12;
                        break;
                    case 'C': value = 12;
                        break;
                    case 'd': value = 13;
                        break;
                    case 'D': value = 13;
                        break;
                    case 'e': value = 14;
                        break;
                    case 'E': value = 14;
                        break;
                    case 'f': value = 15;
                        break;
                    case 'F': value = 15;
                        break;
                    default:
                        break;
                }
                dec = value * (BigInteger)(Math.Pow(16, order.Length -1 -i));
            }
            else
            {
                BigInteger a = Convert.ToInt64(order[i].ToString());
                dec = a * (BigInteger)(Math.Pow(16, order.Length - 1 - i));
            }
            sum += dec;
        }
        Console.WriteLine(sum);
    }
}

