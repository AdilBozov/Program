using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = a + 25;
        b = b + 253.25;
        Console.WriteLine("Integer null sum -"+a);
        Console.WriteLine("Double null sum - "+b);
        a = 25;
        b = 253.25;
        Console.WriteLine(a);
        Console.WriteLine(b);


 
    }
}

