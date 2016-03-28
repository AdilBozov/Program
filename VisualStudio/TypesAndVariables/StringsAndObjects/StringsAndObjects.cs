using System;

class StringsAndObjects
{
    static void Main()
    {
        string wordOne = "Hello";
        string wordTwo = "World";
        //string tab = "\t";
        //object word = wordOne + tab + wordTwo;
        object word = wordOne + " " + wordTwo; 
        Console.WriteLine(word);
        string castObject = (string)word;
        Console.WriteLine(castObject);
    }
}
