using System;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:
//n	Divided by 7 and 5?
//3	    false
//0 	false
//5	    false
//7 	false
//35	true
//140	true


class Divide_03
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        bool b = (( a % 5) == 0) && (( a % 7 ) == 0 && (a != 0));
        Console.WriteLine(b);

    }
}

