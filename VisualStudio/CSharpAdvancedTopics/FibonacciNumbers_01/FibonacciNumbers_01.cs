using System;
 class FibonacciNumbers_01
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(number));
      
    }

    static int Fib (int n)
    {
        int p = 1;
        int m = 0;
        if (n == 0 || n == 1 || n == 2)
        {
            p = 1;
        }
        else
        {
            for (int i = 3; i <= n; i++)
            {
                m = p - m;
                p = p + m;
            }
        }

       return p;
    }
}

