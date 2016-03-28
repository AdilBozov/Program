using System;

class RandomizeTheNumbers_1_To_N_12
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Random randomNumber = new Random();
        int number = randomNumber.Next(n);
        string[] num = new string[n];
        num[0]= Convert.ToString(number);
        Console.Write(num[0]);

        

            for (int i = 0; i <= n ; i++)
            {

                if (Convert.ToString(number) == num[0])
                {
                    number = randomNumber.Next(n);
                    i = 0;
                }

                if (Convert.ToString(number) == num[i])
                {
                    number = randomNumber.Next(n);
                    i = 0;
                }
                else if (num[i] == null)
                {
                    num[i] = Convert.ToString(number);
                    Console.Write(" " + num[i]);
                    i = 0;
                    number = randomNumber.Next(n);
                }
                else
                {
                    continue;
                }
           }
            Console.WriteLine();
    }
}

