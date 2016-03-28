using System;

//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
//x	y	inside	 
//0 	  1	    true	
//-2	  0	    true	
//-1	  2	    false	
//1.5    -1	    true	
//-1.5	-1.5	false	
//100	-30	    false	
//0    	  0	    true	
//0.2	-0.8 	true	
//0.9	-1.93	false	
//1	     1.655	true	


class PointCircle_07
{
    static void Main()
    {
        Console.Write("Enter a value for x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for y = ");
        double y = double.Parse(Console.ReadLine());
        bool circle = (((x*x)+(y*y))<=(2*2));
        Console.WriteLine("Point in circle - " + circle);
    }
}

