using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOddNumbers
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter your number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(number1 % 2 == 0 ? "Your number ({0}) is even." : "Your number ({0}) is odd.", number1);
            Console.ReadKey();
            Console.Write("Done, press any key to escape program.");
            Console.ReadKey();
        }
    }
}



