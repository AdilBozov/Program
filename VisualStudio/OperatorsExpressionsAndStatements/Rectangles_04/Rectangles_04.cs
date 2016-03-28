using System;

//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
//width	height	perimeter	area
//3	    4 	14	 12
//2.5	3	11	 7.5
//5 	5	20   25


class Rectangles_04
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = (2*width)+(2*height);
        double area = width * height;
        Console.WriteLine("Perimerte = "+perimeter);
        Console.WriteLine("Area = "+area);
    }
}

