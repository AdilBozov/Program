using System;

class Calculate_N_Del_K_06
{
    static void Main()
    {
        Console.Write("Enter a value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for k: ");
        int k = int.Parse(Console.ReadLine());
        double factorial_n=1;
        double factorial_k=1;
        double divFactorial=1;
        
        while (n<1 || n>100)
        {
            Console.WriteLine("Invalid number");
            Console.Write("Enter a value for n: ");
            n = int.Parse(Console.ReadLine());
        }

        while (k<1 || k>n)
        {
            Console.WriteLine("Invalid number");
            Console.Write("Enter a value for k: ");
            k = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= n; i++)
        {
            factorial_n = factorial_n * i;
        }

        for (int p = 1; p <= k; p++)
        {
            factorial_k = factorial_k * p;
        }
        divFactorial = factorial_n / factorial_k;
        Console.WriteLine(divFactorial);
    }
}

