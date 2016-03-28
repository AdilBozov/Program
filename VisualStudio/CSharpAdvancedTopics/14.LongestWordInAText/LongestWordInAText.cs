using System;

class LongestWordInAText
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] size = line.Split( new char[] {' ', '.', ',', '-', ':', ';' }, StringSplitOptions.RemoveEmptyEntries );
        int sumSize = 0;

        for (int i = 0; i < size.Length; i++)
        {
            if (size[i].Length > size[sumSize].Length)
            {
                sumSize = i;
            }
        }
        Console.WriteLine(size[sumSize]);
    }
}

