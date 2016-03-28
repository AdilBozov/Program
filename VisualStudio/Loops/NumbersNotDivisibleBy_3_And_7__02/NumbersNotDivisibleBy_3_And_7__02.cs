using System;

class NumbersNotDivisibleBy_3_And_7__02
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (double i = 1; i <= n; i++)
        {
            if ((i%3!=0)&&(i%7!=0))
            {
                Console.Write(" "+i);
            }
        }
        Console.WriteLine();
    }
}

