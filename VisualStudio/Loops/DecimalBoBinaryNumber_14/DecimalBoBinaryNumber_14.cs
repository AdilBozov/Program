using System;

class DecimalBoBinaryNumber_14
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int dec = int.Parse(Console.ReadLine());
        int res = 0;
        string bin = string.Empty;

        while (dec>0)
        {
            res = dec % 2;
            dec = dec / 2;
            bin = res.ToString() + bin; 
        }
        Console.WriteLine(bin);
    }
}

