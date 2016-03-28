using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JoinLists
{
    static void Main()
    {
        string[] oneRow = Console.ReadLine().Split(' ');
        string[] lineTwo = Console.ReadLine().Split(' ');
        List<int> oneRowList = new List<int>();
        List<int> lineTwoList = new List<int>();
   
        Input(oneRow, oneRowList);
        Input(lineTwo, lineTwoList);
       
        oneRowList.Add(100);
        for (int i = 0; i < oneRowList.Count; i++)
        {
            for (int j = 0; j < lineTwoList.Count; j++)
            {
                if ((lineTwoList[j] > oneRowList[i]) && (lineTwoList[j] < oneRowList[i + 1]))
                {
                    oneRowList.Insert(i+1,lineTwoList[j]);
                    lineTwoList.Remove(lineTwoList[j]);
                }
            }
        }
        oneRowList.Remove(100);
        oneRowList.Sort();
        foreach (var print in oneRowList)
        {
            Console.Write(print + " ");
        }
        Console.WriteLine();
    }

    static void  Input (string[] input, List<int> inputList)
    {
        for (int i = 0; i < input.Length; i++)
        {
            inputList.Add((Convert.ToInt32(input[i])));
        }
        
        inputList.Sort();

        for (int i = 0; i < inputList.Count; i++)
        {
            for (int j = 1; j < inputList.Count; j++)
            {
                if ((inputList[i] == inputList[j]) && (i != j))
                {
                    inputList.Remove(inputList[i]);
                }
            }
            
        }
        inputList.Sort();
    }
}

