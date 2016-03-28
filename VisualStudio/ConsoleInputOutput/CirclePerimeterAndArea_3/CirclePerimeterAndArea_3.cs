using System;

class CirclePerimeterAndArea_3
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle K = ");
        double r = double.Parse(Console.ReadLine());
        double pi = 3.141592;
        double perimeter = 2 * pi * r;
        double area = pi * r * r;
        Console.WriteLine("Perimeter is: {0:0.00}", perimeter);
        Console.WriteLine("Area is: {0:0.00}",area);
     }
}

