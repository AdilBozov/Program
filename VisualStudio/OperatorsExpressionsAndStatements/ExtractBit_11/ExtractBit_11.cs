using System;

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.

class ExtractBit_11
{
    static void Main()
    {
        uint a = uint.Parse(Console.ReadLine());
        //Console.Write("{0} - ",a);
        Console.WriteLine(Convert.ToString(a, 2).PadLeft(16, '0'));
        uint masc = 1;
        //Console.Write("mask {0} - ",masc);
        Console.WriteLine(Convert.ToString(masc, 2).PadLeft(16, '0'));
        a = a >> 3;
        //Console.Write("a>>3 {0} - ", a);
        Console.WriteLine(Convert.ToString(a, 2).PadLeft(16, '0'));
        uint b = masc & a;
        //Console.Write("a>>3 {0} - ", b);
        Console.WriteLine(Convert.ToString(b, 2).PadLeft(16, '0'));
       
        if (b==0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("1");
        }
    }
}

