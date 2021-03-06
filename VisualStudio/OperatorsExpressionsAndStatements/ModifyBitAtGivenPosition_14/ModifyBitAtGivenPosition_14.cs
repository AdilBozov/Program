﻿using System;

//We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n

    class ModifyBitAtGivenPosition_14
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("v = ");
            byte v = byte.Parse(Console.ReadLine());
            int mask = 1;
            
            if (v==0)
            {
                mask = mask << p;
                mask = ~mask;
                n = n & mask;
            }
            else
            {
                mask = mask << p;
                n = n | mask;
            }
            Console.WriteLine(n);
        }
    }

