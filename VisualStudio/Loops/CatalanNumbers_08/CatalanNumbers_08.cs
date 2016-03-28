using System;
using System.Numerics;

class CatalanNumbers_08
{
    static void Main()
    {
        int n;
        Console.Write("n: ");
        while(!int.TryParse(Console.ReadLine(), out n) || n<0 || n>100) Console.WriteLine("Invalid input!!!");

        BigInteger nFa = 1;
        BigInteger n2Fa = 1;
        BigInteger n1Fa = 1;
        BigInteger result = 1;
        
        for (int i = 1; i <= n; i++)
        {
            nFa = nFa * i;
        }

        for (int i = 1; i <= 2*n; i++)
        {
            n2Fa = n2Fa * i;
        }

        for (int i = 1; i <= n+1; i++)
        {
            n1Fa = n1Fa * i;
        }

        Console.WriteLine(result = n2Fa / (n1Fa*nFa));
    }
}

