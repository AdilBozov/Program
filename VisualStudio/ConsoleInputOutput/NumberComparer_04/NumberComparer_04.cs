using System;

class NumberComparer_04
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        double c = Math.Max(a,b);
        Console.WriteLine("Max number: "+c);
    }
}

