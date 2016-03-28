using System;

class CheckForPlayCard_03
{
    static void Main()
    {
        Console.Write("Card face: ");
        string cards = Console.ReadLine();
        if ((cards == "2") || (cards == "3") || (cards == "4") || (cards == "5") || (cards == "6") || (cards == "7") || (cards == "8") || (cards == "9")|| (cards=="10") || (cards == "J") || (cards == "Q") || (cards == "K") || (cards == "A"))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }    
}

