using System;

class OddAndEvenProduct_10
{
    static void Main()
    {
        string range = Console.ReadLine();
        string[] numbers = range.Split(new char[] {' '});
        int odd = 1;
        int even = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);
                        
            if (i % 2 == 0)
            {
                odd = odd * number;
            } 
            else
	        {
                even = even * number;	 
	        }
        }

        if (odd == even)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("product = "+odd);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("odd_product = "+odd);
            Console.WriteLine("even_product = "+even);
        }


    }
}

