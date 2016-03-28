using System;

class TheBiggestOf_3_Numbers_05
{
    static void Main()
    {
        Console.Write("Enter a value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for c: ");
        double c = double.Parse(Console.ReadLine());

        if ((a>b) && (a>c))
        {
            Console.WriteLine(a);
        }
        else if ((b>a) && (b>c))
        {
            Console.WriteLine(b);
        }
        else if ((c>a)&& (c>b))
        {
            Console.WriteLine(c);
        }
    }
}

