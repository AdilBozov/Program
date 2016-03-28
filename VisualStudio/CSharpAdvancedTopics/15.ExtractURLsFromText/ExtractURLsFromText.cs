using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractURLsFromText
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] textSplit = text.Split(new char[] { ' ', '.', ',', '-', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> textURL = new List<string>();

        foreach (var name in textSplit)
        {
            if (!textURL.Contains(name) && textURL.Count > 6)
            {
                if (name.Substring(0,7) == "http://" || name.Substring(0,3) == "www")
                {
                    textURL.Add(name);
                }
            }
        }
        foreach (var printURL in textURL)
        {
            Console.WriteLine(printURL);
        }
    }
}

