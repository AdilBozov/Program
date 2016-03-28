using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfPalindromes
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        string[,] matrix =new string[start, end];
       // char print = 'a';

        for (int i = 0; i < start; i++)
        {
            for (int j = 0; j < end; j++)
            {
                matrix[i, j] = "" + (char)('a' + i) + (char)('a' + i + j) + (char)('a' + i);
                Console.Write(" "+matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

