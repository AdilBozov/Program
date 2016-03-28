using System;

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
//((x < 1) || (x > 5) || (y < 1) || (y > 5))
class CircleAndRectangle_10
{
    static void Main()
    {
        Console.Write("x=");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y=");
        double y = double.Parse(Console.ReadLine());
        bool curcle = ((((x-1)*(x-1))+((y -1)*(y-1)))<=1.5*1.5);
        bool rectangle = false;
        
        if ((x<1)||(x>5)||(y<1)||(y >5))
        {
           rectangle = true;
        }
        if ((curcle == true) && (rectangle == false))
	    {
            Console.WriteLine("Yes");
	    }
        else
        {
            Console.WriteLine("No");
        }
    }
}

