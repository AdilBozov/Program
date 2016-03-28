using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Trapezoids_9
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = (((a + b) / 2) * h);
        Console.WriteLine(area);

    }
}

