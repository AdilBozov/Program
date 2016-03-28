using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.Write(" ");
        string[] oneRow = Console.ReadLine().Split(' ');
        Console.WriteLine(" ");
        string[] secondOne = Console.ReadLine().Split(' ');
        List<string> name = new List<string>();

        for (int i = 0; i < oneRow.Length; i++)
        {
            name.Add(oneRow[i]);
            for (int j = 0; j < secondOne.Length; j++)
            {
                if (oneRow[i] == secondOne[j])
                {
                    name.Remove(oneRow[i]);
                }
            }
        }

        foreach (var print in name)
        {
            Console.Write(print+" ");
        }
        Console.WriteLine();
    }
}

