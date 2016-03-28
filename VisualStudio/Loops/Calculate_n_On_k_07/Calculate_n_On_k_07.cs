using System;
using System.Numerics;
//N! / (K! * (N-K)!)
class Calculate_n_On_k_07
{
    static void Main()
    {
        int n;
        Console.Write("n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 100) Console.WriteLine("Invalid input!!!");
        int k;
        Console.Write("k: ");
        while (!int.TryParse(Console.ReadLine(), out k) || k < 0 || k > n) Console.WriteLine("Invalid input!!!");

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nkfactorial = 1;
        BigInteger result = 1; ;
        
        for (int i =1; i <=n; i++)
        {
            nFactorial = nFactorial * i;
        }

        for (int i = 1; i <=k; i++)
        {
            kFactorial = kFactorial * i;
        }

        for (int i = 1; i <= n-k; i++)
        {
            nkfactorial = nkfactorial * i;
        }
        //N! / (K! * (N-K)!)
        Console.WriteLine(result = nFactorial / (kFactorial * nkfactorial));
    }

}

