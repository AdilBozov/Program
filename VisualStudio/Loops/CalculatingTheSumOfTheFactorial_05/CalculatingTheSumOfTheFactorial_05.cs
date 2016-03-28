using System;
//1 + 1!/X + 2!/X2 + … + N!/XN
class CalculatingTheSumOfTheFactorial_05
{
    static void Main()
    {
        Console.Write("Enter a value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for x: ");
        int x = int.Parse(Console.ReadLine());
        double m = 1;
        double s = 0;
        double sum=1;

        for (int i = 1; i <=n; i++)
        {
            m = 1;
            for (int p = 1; p <= i; p++)
            {
                m = m * p;
                s = Math.Pow(x, p);
            }
            sum = sum + (m / s);
        }
        Console.WriteLine("{0:0.00000}",sum);
    }
}

