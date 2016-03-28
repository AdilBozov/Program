using System;

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1.

class ExtractBitFromInteger_12
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1;
        bool bit = false;
        if (((n >> p) & mask) == 0)
        {
            bit = false;
        }
        else
        {
            bit = true;
        }
        Console.WriteLine(bit);
    }
}


