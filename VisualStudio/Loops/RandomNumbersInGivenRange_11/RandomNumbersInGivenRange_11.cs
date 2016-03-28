using System;

class RandomNumbersInGivenRange_11
{
    static void Main()
    {
        Console.Write("Enter a value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for max: ");
        int max = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for min: ");
        int min = int.Parse(Console.ReadLine());
        Random numRandom = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(numRandom.Next(min, max+1)+" ");
        }
        Console.WriteLine();
    }
}
