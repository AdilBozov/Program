using System;

class ExchangeIfGreater_01
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());

        if (a<b)
        {
            Console.WriteLine("{0} {1}", a, b);
        }
        else
        {
            double c = a;
            a = b;
            b = c;
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
