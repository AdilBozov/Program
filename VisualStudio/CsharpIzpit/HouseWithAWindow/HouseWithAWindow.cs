using System;

class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (i==0 || i ==1)
            {
                m = 0;
            }
            else
	        {
                m++;
	        }

            string asterisk = new string('*',1);
            string dot = new string('.',n-(i+1));
            string point = new string('.',(i+m));
          
            if (i==0)
            {
                Console.WriteLine("{0}{1}{0}", dot, asterisk, point);
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", dot, asterisk, point);
            }
        }
        string star = new string('*', (n * 2) - 1);
        Console.WriteLine(star);

        for (int i = 0; i < (n/4); i++)
        {
            string asterisk = new string('*',1);
            string dot = new string('.', (2*n)-3);
            Console.WriteLine("{0}{1}{0}",asterisk,dot);
        }

        for (int i = 0; i < n/2; i++)
        {
            string asterisk = new string('*', n - 3);
            string dot = new string('.', n / 2);
            string stars = new string('*', 1);
            Console.WriteLine("{0}{1}{2}{1}{0}",stars,dot,asterisk);

        }
        for (int i = 0; i < (n / 4); i++)
        {
            string asterisk = new string('*', 1);
            string dot = new string('.', (2 * n) - 3);
            Console.WriteLine("{0}{1}{0}", asterisk, dot);
        }
        Console.WriteLine(star);
    }
}