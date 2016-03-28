using System;

class MinMaxSumAndAverageOf_N_Numbers_03
{
    static void Main()
    {
        Console.WriteLine("Enter the number of numbers");
        int n = int.Parse(Console.ReadLine());
        int sum = 0, max = 0, min = 0, num = 0;
        double avg;
        Console.WriteLine("Enter your {0} numbers", n);
        for (int i = 1; i <=n; i++)
        {
            int beforeNum = num;
            num = int.Parse(Console.ReadLine());
            sum = sum + num;
            if (num >= beforeNum)
            {
                max = num;
            }
            else if (num <= beforeNum)
            {
                min = num; 
            }
        }
        Console.WriteLine("Max: "+max);
        Console.WriteLine("Min: "+min);
        Console.WriteLine("Sum: "+sum);
        avg = (double)sum / (double)n;
        Console.WriteLine("Avg: {0:0.00}",avg);
    }
}

