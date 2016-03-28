using System;

class BinaryToDecimalNumber_13
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string order = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i < order.Length; i++)
        {
            if ((order[order.Length -1 -i]) != '0')
            {
                sum += (int)(Math.Pow(2, i));
            }
        }
        Console.WriteLine(sum);
    }
}

