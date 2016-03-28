using System;

    class ComparingFloats
    {
        static void Main()
        {
            Console.Write("a =");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b =");
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool c= new bool();
            //Console.WriteLine(c);
            if (a>b)
            {
                if ((a-b)>eps)
                {
                    c = false;
                    Console.WriteLine(c);
                }
                else
                {
                    c = true; 
                    Console.WriteLine(c);
                }
            }
            else if (b>a)
            {
                if ((a-b)>eps)
                {
                    c = false;
                    Console.WriteLine(c);
                }
                else
                {
                    c = true;
                    Console.WriteLine(c);
                }
            }

        }
    }

