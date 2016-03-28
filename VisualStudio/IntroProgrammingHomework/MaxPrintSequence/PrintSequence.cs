using System;

class PrintSequence
    {
        static void Main()
        {
           for (int i = 1; i <= 1000; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write("; {0}", i);
                }
                else
                {
                    Console.Write("; {0}", -i);
                }
            }
        }
    }

