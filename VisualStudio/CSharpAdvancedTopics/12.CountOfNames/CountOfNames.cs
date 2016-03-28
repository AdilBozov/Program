using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountOfNames
{
    static void Main()
    {
        string[] order = Console.ReadLine().Split(' ');
        List<string> name = new List<string>();
        int sum = 0;
        for (int i = 0; i < order.Length; i++)
        {
            name.Add(order[i]);
        }

        name.Sort();
        name.Insert(0,"ABC");
        for (int i = 1; i < name.Count; i++)
        {
            if (name[i] == name[i - 1])
            {
                continue;
            }
            else
            {
                sum = 0;
                for (int j = 0; j < name.Count; j++)
                {
                    if (name[i] == name[j])
                    {
                        sum = ++sum;
                    }
                }
                Console.WriteLine(name[i] + " > " + sum);
            }
         }
      }
}
