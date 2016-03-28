using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {
            Console.Write("Counting numbers: ");
            int index = int.Parse(Console.ReadLine());
            int[] sortMas = new int[index];
            Console.WriteLine("Numbers: ");
            for (int i = 0; i < index; i++)
            {
                sortMas[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sortMas);
            for (int i = 0; i < sortMas.Length; i++)
            {
                Console.WriteLine(sortMas[i]);
            }
            Console.WriteLine();
        }
    }

}
