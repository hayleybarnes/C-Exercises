using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which divides two numbers a user provides

            Console.WriteLine("Please write your first number to divide");
            int FirstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please write your second number to divide");
            int SecondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine(FirstNumber / SecondNumber);

            Console.WriteLine("Done, press any key to finish!");
            Console.ReadKey();
        }
    }
}
