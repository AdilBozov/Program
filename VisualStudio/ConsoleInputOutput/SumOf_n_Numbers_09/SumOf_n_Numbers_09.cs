using System;

class SumOf_n_Numbers_09
{
    static void Main()
    {
        Console.Write("Enter the number of integers: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers: ");
        double m = 0;
        for (int i = 0; i < n; i++)
        {
            double p = double.Parse(Console.ReadLine());
            m = m + p;
        }
        Console.WriteLine(m);
    }
}

