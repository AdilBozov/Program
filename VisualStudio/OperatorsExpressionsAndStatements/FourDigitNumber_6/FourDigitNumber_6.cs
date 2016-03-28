using System;

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:
//n	sum of digits	reversed	last digit in front	second and third digits exchanged
//2011	4	1102	1201	2101
//3333	12	3333	3333	3333
//9876	30	6789	6987	9786


class FourDigitNumber_6
{
    static void Main()
    {
        Console.WriteLine("Enter the four-digit number that does not begin with 0");
        int number = int.Parse(Console.ReadLine());
        while (number <= 999)
        {
            Console.WriteLine("Your number starts with 0 ");
            Console.WriteLine("Enter a number that does not begin with 0");
            number = int.Parse(Console.ReadLine());
        }
        int d = number % 10;
        number = number / 10;
        int c = number % 10;
        number = number / 10;
        int b = number % 10;
        number = number / 10;
        int a = number % 10;
        int sum = a + b + c + d;
        Console.WriteLine("Total - " + sum);
        Console.WriteLine("In reverse order - {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("First position - {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Third digits - {0}{1}{2}{3}", a, c, b, d);
    }
}

