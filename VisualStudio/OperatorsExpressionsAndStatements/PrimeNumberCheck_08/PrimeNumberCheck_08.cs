using System;

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1)

class PrimeNumberCheck_08
{
    static void Main()
    {
        Console.Write("Enter a number from 1 to 100 - ");
        int num = int.Parse(Console.ReadLine());
        bool input = true;
        if (num >= 1)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    input = false;
                }
            }
            Console.WriteLine(input);
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

