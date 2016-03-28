using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountingAWordInAText
{
    static void Main()
    {
        string searchTerm = Console.ReadLine().ToUpper();
        string inputText = Console.ReadLine().ToUpper();
        string[] text = inputText.Split(new char[] {' ', '"', '.', ',','!','(',')',':', '/', '.','@'}, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == searchTerm)
            {
                sum++;
            }
        }
        Console.WriteLine(sum);
    }
}

