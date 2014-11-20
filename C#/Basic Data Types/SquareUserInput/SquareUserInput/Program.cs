using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that squares user's input

            Console.WriteLine("Please put a number in of your choice!");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(number * number);

            Console.WriteLine("Done, press any key to finish!");
            Console.ReadKey();
        }
    }
}
