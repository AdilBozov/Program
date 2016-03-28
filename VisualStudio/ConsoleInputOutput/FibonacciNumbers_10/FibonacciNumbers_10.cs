using System;

class FibonacciNumbers_10
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        int m = 0;
        int k = 1;
        int s;

        if (n >= 3)
        {
            Console.Write(m + " " + k + " ");
            for (int i = 0; i < n-2; i++)
            {
                s = m;
                m = k;
                k = s + m;
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }
        else if (n == 2)
        {
            Console.WriteLine(m + " " + k);
        }
        else if (n==1)
        {
            Console.WriteLine(m);
        }
    }
}

