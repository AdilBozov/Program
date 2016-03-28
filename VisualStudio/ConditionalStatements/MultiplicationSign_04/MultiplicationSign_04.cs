using System;

class MultiplicationSign_04
{
    static void Main()
    {
        Console.Write("Enter a value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for bool: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for c: ");
        double c = double.Parse(Console.ReadLine());

        if ((a==0)||(b==0)||(c==0))
        {
            Console.WriteLine(" 0 ");
        }
        else if ((a>0)&&(b>0)&&(c>0))
        {
            Console.WriteLine(" + ");
        }
        else if ((a<0)&&(b<0)&&(c<0))
        {
            Console.WriteLine(" - ");
        }
        else if (((a<0)&&(b<0))||((a<0)&&(c<0))||((b<0)&&(c<0)))
        {
            Console.WriteLine(" + ");
        }
        else if (((a>0)&&(b>0)&&(c<0))||((a>0)&&(c>0)&&(b<0))||((b>0)&&(c>0)&&(a<0)))
        {
            Console.WriteLine(" - "); 
        }
    }
}

