using System;

    class SumOf5Numbers_7
    {
        static void Main()
        {
            string[] order = Console.ReadLine().Split(' ');
            double a = double.Parse(order[0]);
            double b = double.Parse(order[1]);
            double c = double.Parse(order[2]);
            double d = double.Parse(order[3]);
            double e = double.Parse(order[4]);
            Console.WriteLine("Result: {0}", a+b+c+d+e);
        }
    }

