using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class AverageLoadTimeCalculator
    {
        static void Main()
        {
            string line = Console.ReadLine();

            Dictionary<string, double> sumTime = new Dictionary<string, double>();
            Dictionary<string, int> sumRepet = new Dictionary<string, int>();

            while (line != string.Empty)
            {
                string[] lineSplit = line.Split(' ');
                string link = lineSplit[2];
                double time = double.Parse(lineSplit[3], CultureInfo.InvariantCulture);

                if (!sumTime.Keys.Contains(link))
                {
                    sumTime[link] = time;
                    sumRepet[link] = 1;
                }
                else
                {
                    sumTime[link] = sumTime[link] + time;
                    sumRepet[link] = sumRepet[link] + 1;
                }
                line = Console.ReadLine();
            }

            foreach (string PrintResult in sumTime.Keys)
            {
                Console.WriteLine(PrintResult + " --> " + sumTime[PrintResult]/sumRepet[PrintResult]);
            }
        }
    }

