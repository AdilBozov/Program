using System;

class TheBiggestOfFiveNumbers_06
{
    static void Main()
    {
        Console.Write("Enter a value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for e: ");
        double e = double.Parse(Console.ReadLine());

        if (a>=b && a>=c && a>=d && a>=e)
        {
            Console.WriteLine(a);
        }
        else if (b>=a && b>=c && b>=d && b>=e)
        {
            Console.WriteLine(b);
        }
        else if (c>=a && c>=b && c>=d && c>=e)
        {
            Console.WriteLine(c);
        }
        else if (d>=a && d>=b && d>=c && d>=e)
        {
            Console.WriteLine(d);
        }
        else if (e>=a && e>=b && e>=c && e>=d)
        {
            Console.WriteLine(e);
        }
    }
}
