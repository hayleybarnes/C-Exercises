using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that outputs the current date and time
            Console.WriteLine("Click to see date and time!");
            Console.ReadKey();
            DateTime thisDay = DateTime.Now;
            Console.WriteLine(thisDay.ToString());
            Console.ReadKey();
            Console.WriteLine("Done, press any key to finish!");
            Console.ReadKey();

        }
    }
}
