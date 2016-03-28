using System;

class Illuminati
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();
        int sum = 0;
        int sumNum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char items = input[i];

            if (items == 65 || items == 69 || items == 73 || items == 79 || items == 85 )
            {
                sum += items;
                sumNum++;
            }
        }
        Console.WriteLine(sumNum);
        Console.WriteLine(sum);
    }
}

