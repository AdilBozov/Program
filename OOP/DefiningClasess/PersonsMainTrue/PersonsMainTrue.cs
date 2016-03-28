using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsMainTrue
{
    class PersonsMainTrue
    {
        static void Main(string[] args)
        {
            //console.writeline("enter name: ");
            //string name = console.readline();
            //console.writeline("enter age: ");
            //int age = int.parse(console.readline());
            //console.writeline("enter email: ");
            //string email = console.readline();

            string name = "cfdsgfdg";
            int age = 25;
            string email1 = null;

            PersonsTrue p = new PersonsTrue(name, age, email1);
            Console.WriteLine(p);
        }
    }
}
