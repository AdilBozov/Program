using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PersonsMain
{
    static void Main()
    {
        //console.writeline("enter name: ");
        //string name = console.readline();
        //console.writeline("enter age: ");
        //int age = int.parse(console.readline());
        //console.writeline("enter email: ");
        //string email = console.readline();

        string name = "adil";
        int age = 25;
        string email1 = "";

        Persons p = new Persons(name, age, email1);
        Console.WriteLine(p);
    }
}
