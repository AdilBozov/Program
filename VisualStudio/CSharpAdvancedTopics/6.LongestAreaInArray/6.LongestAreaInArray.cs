using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestAreaInArray
{
    static void Main()
    {
        Console.Write(" ");
        int strLength = int.Parse(Console.ReadLine());
        string[] value = new string[strLength];
        int[] lengString = new int[strLength];
        int max = lengString.Max();
        string str = "a";

        for (int i = 0; i < value.Length; i++)
        {
            value[i] = Console.ReadLine();

        }
       // Array.Sort(value);

        for (int i = 0; i < value.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < value.Length; j++)
            {
                if (value[i] == value[j])
                {
                    sum = ++sum;
                }

            }
            lengString[i] = sum;
        }
        max = lengString.Max();
        Console.WriteLine(max);
        for (int i = 0; i < strLength; i++)
        {
             if(lengString[i]==max)
                {
                    str = value[i];
                    strLength = 0;
                }
        }

        for (int i = 0; i < lengString.Length; i++)
        {
            if (lengString[i] == max && (str == value[i]))
            {
                Console.WriteLine(value[i]);
            }
        }
    }
}

