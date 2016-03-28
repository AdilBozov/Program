using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
       char symbol = '\u00A9';
       Console.WriteLine(@"   ©
  © ©
 © © ©
© © © ©");
       Console.WriteLine();
       Console.WriteLine("   {0}",symbol);
       Console.WriteLine("  {0} {0}", symbol);
        Console.WriteLine(" {0} {0} {0}",symbol);
        Console.WriteLine("{0} {0} {0} {0}",symbol);
    }
}

