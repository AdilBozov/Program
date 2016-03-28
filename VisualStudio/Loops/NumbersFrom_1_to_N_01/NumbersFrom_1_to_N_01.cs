using System;

class NumbersFrom_1_to_N_01
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <=n; i++)
        {
            Console.Write(" "+i);
        }
        Console.WriteLine();
    }
}

