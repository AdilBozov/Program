using System;

class Trapezoids_9
{
    static void Main()
    {
        int r = 1;
        int n = 25; // nterval
        //int s = 0;
        int k = 3; // k broi deliteli
        for (int i = 1; i <= n; i++)
        {
            int m = 0;

            for (int p = 2; p < n; p++)
            {
                if (i % p == 0)
                {
                    m = m + 1;
                }
            }
            if (((m - 1) >= k) && ((r - 1) == k))
            {
                r = r + 1;
                Console.WriteLine(i);
            }
            m = 0;
        }
    }
}