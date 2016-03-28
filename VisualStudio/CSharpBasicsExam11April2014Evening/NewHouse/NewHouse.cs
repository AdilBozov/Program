using System;
class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i += 2)
        {
            string star = new string('*',i);
            string dash = new string('-', (n-i)/2);

            Console.WriteLine("{1}{0}{1}", star, dash);
        }

        for (int i = 1; i <= n; i++)
        {
            string star = new string('*',n-2);
            string line = new string('|',1);

            Console.WriteLine("{1}{0}{1}",star, line);
        }
    }
}