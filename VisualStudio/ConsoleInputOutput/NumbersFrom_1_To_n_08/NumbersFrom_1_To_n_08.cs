using System;

class NumbersFrom_1_To_n_08
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int n = int.Parse(Console.ReadLine());
        int m = 0;
        for (int i = 0; i < n; i++)
        {
             m = m + 1;
            Console.WriteLine(m);
        }
    }
}

