using System;

//Write a program that reads 3 real numbers from the console and prints their sum

class SumNumbers_01
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("a + b +c = "+sum);
    }
}

