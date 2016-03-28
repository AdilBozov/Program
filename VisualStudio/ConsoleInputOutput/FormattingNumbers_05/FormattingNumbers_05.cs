using System;

class FormattingNumbers_05
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        if (a <= 0 & a >= 500)
        {
            Console.WriteLine("Invalid input");
        }
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        //Console.Write("|{0,-10:X}",a);
        //Console.Write("|");
        //Console.Write("{0}", Convert.ToString(a, 2).PadLeft(10, '0'));
        //Console.Write("|");
        //Console.Write("{0,10:0.00}",b);
        //Console.Write("|");
        //Console.Write("{0,-10:0.000}|", c);
    }
}
