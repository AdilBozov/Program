using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class PrimesInGivenRange_03
{
    static void Main()
    {
        Console.Write("Enter the start of the interval: ");
        int signIn = int.Parse(Console.ReadLine());
        int entEnd;
        Console.Write("Enter the end of the interval: ");
        while (int.TryParse((Console.ReadLine()), out entEnd) && signIn > entEnd) Console.WriteLine("Empty list");

        List<int> sheet = FindPrimesInRange(signIn, entEnd);

        for (int i = 0; i < sheet.Count; i++)
        {
            Console.Write(sheet[i]+", ");
        }
        Console.WriteLine();
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> listInt = new List<int>();

        if (startNum < 2)
        {
            startNum = 2;
        }
  
        for (int i = startNum; i <= endNum; i++)
        {
            int m = 0;
            for (int j = 2; j <= i ; j++)
            {
                if (i % j == 0)
                {
                    m = ++m;
                }
            }
            if (m <= 1)
            {
                listInt.Add(i);
            }
        }
        return listInt;
    }
}
