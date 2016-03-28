using System;

    class MatrixOfNumbers_09
    {
        static void Main()
        {
            int n;
            Console.Write("n: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 20) Console.WriteLine("Invalid input!!!");

            for (int i = 0; i < n; i++)
            {
                int m = i;
                for (int p = 1; p <= n; p++)
                {
                    m++;
                    Console.Write(" "+m);
                }
                Console.WriteLine();
            }
        }
    }

