using System;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool noNumber = true;

        for (int i = 555; i <= 999; i++)
        {
            int abc = i;
            int def = abc + diff;
            int ghi = def + diff;

            if (ghi > 999)
            {
                break;
            }

            string numbers = "" + abc + def + ghi;

            if (numbers.Contains("0") || numbers.Contains("1") || numbers.Contains("2") || numbers.Contains("3") || numbers.Contains("4"))
            {
                continue;
            }

            int sumNumbers = 0;
            for (int k = 0; k < numbers.Length; k++)
            {
                sumNumbers = sumNumbers + Convert.ToInt32((Convert.ToString(numbers[k])));
            }

            if (sumNumbers == sum)
            {
                Console.WriteLine(numbers);
                noNumber = false;
            }
        }
        if (noNumber)
        {
            Console.WriteLine("No");
        }
    }
}