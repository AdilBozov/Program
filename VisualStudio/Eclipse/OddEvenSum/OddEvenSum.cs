using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        n = n * 2;
        int sumOdd = 0;
        int sumEven = 0;

        for (int i = 0; i < n; i++)
        {
           int input = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                sumEven += input;
            }
            else
            {
                sumOdd  += input;
            }
            
        }

        if (sumEven==sumOdd)
        {
            Console.WriteLine("Yes, sum=" +sumOdd);
        }
        else
        {
            int diff = Math.Abs(sumOdd - sumEven);  // int diff = Math.Max(sumOdd,sumEven) - Math.Min(sumOdd, sumEven);
            Console.WriteLine("No, diff=" + diff);
        }
    }
}