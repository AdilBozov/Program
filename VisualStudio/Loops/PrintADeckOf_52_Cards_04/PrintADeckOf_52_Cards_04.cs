using System;

class PrintADeckOf_52_Cards_04
{
    static void Main()
    {
        string[] sign = {"2", "3","4","5","6","7","8","9","10","A","K","Q","J"};
        char[] symbol = {'\u2663','\u2666','\u2665','\u2660'};
       
        foreach (var outSign in sign)
        {
            foreach (var outSymbol in symbol)
            {
                Console.Write(" {0}{1}",outSign, outSymbol);
            }
            Console.WriteLine();
        }
    }
}

