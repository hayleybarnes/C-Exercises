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
            //Write a program that outputs the current date 
            Console.WriteLine("Date:");
            Console.WriteLine(DateTime.Today.ToString("M/d/yyyy"));
            Console.ReadKey();

            //current time
            Console.WriteLine("Time:");
            Console.WriteLine(DateTime.Now.ToString("H:mm"));
            Console.ReadKey();

            Console.WriteLine("Done, press any key to finish!");
            Console.ReadKey();
        }
    }
}
