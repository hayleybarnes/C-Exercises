using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespondingToLargeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello please select 2 numbers, press enter to continue.");
            Console.ReadLine();

            int large = 0;
            int small = 0;
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                large = number1;
                small = number2;
            }

            if (number1 < number2)
            {
                large = number2;
                small = number1;
            }
            Console.WriteLine("Your smallest number is: " + small);
            Console.WriteLine("Your largest number is: " + large);
            Console.ReadKey();
        }
    }
}
