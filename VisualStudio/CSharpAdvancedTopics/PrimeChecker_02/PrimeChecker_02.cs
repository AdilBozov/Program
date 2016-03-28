using System;
using System.Numerics;

class PrimeChecker_02
{
    static void Main()
    {
        Console.Write("Enter number: ");
        BigInteger inNumber = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(inNumber));
    }
    static bool IsPrime (BigInteger number)
    {
        BigInteger m = 0;
        bool isPrime = false;
        for (BigInteger i = 1; i <= number; i++)
        {
            if( number == 0 || number == 1)
            {
                continue;
            }
            else if (number%i==0)
            {
                m = m + 1;
            }
        }
        if (m <= 2 && m!=0)
        {
            isPrime = true;
        }
        return isPrime;
    }
}

