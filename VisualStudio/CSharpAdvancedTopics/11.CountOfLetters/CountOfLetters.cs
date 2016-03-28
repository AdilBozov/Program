using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CountOfLetters
    {
        static void Main()
        {
            string[] order = Console.ReadLine().Split(' ');
          
            int sum = 0;
            List<string> orderSplit = new List<string>();

            for (int i = 0; i < order.Length; i++)
            {
                orderSplit.Add(order[i]);
            }

            for (int i = 0; i < 26; i++)
            {
                sum = 0;
                for (int j = 0; j < orderSplit.Count ; j++)
                {
                    if (Convert.ToChar(orderSplit[j]) == ((char)('a' + i)))
                    {
                        sum = ++sum;
                    }
                }
                if (sum != 0)
                {
                    Console.WriteLine(((char)('a' + i)) + " --> " + sum);
                }
            }
        }
    }

