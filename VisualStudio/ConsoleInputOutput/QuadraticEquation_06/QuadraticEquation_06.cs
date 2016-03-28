using System;


class QuadraticEquation_06
{
    static void Main()
    {
        Console.Write("Enter a value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for c :");
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - 4 * a * c;
        if (d>0)
        {
            double x1=((- b- (Math.Sqrt(d)))/(2*a));
            double x2 = ((-b + (Math.Sqrt(d))) / (2 * a));
            Console.WriteLine("X1= {0}; X2={1}",x1,x2);
        }
        else if (d==0)
        {
            double x1 = ((-b ) / (2 * a));
            Console.WriteLine("X1=X2 = {0}", x1);

        }
        Console.WriteLine("No real roots"); 
    }
}

