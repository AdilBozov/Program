using System;

//Write an expression that extracts from given integer n the value of given bit at index p.

class ExtractBitFromInteger_12
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1;
        if (((n>>p)&mask)==0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("1");
        }
    }
}

