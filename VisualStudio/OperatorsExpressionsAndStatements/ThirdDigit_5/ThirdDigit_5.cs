using System;

//write an expression that checks for given integer if its third digit from right-to-left is 7. examples:
//n	third digit 7?
//5 	    false
//701	    true
//9703	    true
//877	    false
//777877	false
//9999799	true


class ThirdDigit_5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int div = number / 100;
        div = div % 10;
        bool comparison = (div == 7);
        Console.WriteLine("Third digit is 7 - " + comparison);


    }
}

