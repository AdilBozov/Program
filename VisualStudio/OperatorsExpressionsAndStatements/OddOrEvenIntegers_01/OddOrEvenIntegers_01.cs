using System;

        // Write an expression that checks if given integer is odd or even. Examples:
        //n	Odd?
        //3	true
        //2	false
        //-2 false
        //-1 true
        //0	false
 

class OddOrEvenIntegers_01
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool b = (n % 2) == 1;
        Console.WriteLine("The number is not even - " + b);



    }
}

