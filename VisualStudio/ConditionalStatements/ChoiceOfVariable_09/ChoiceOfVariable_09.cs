using System;

class ChoiceOfVariable_09
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine(@"
1 --> int
2 --> double
3 --> string");

        int type = int.Parse(Console.ReadLine());
       
        switch (type)
        {
            case 1: Console.WriteLine("Enter a number: "); 
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
                break;
            case 2: Console.WriteLine("Enter a number: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b + 1);
                break;
            case 3: Console.WriteLine("Write word");
                string str = Console.ReadLine();
                Console.WriteLine(str+"*");
                break;
            default: Console.WriteLine("Not a digit");
                break;
        }
    }
}

