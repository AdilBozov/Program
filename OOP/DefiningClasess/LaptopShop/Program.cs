using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop("Toshiba Satellite L850-13R", 200);
            Console.WriteLine(laptop1.ToString());
        }
    }
}
