using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number:");
            int numberChosen= int.Parse(Console.ReadLine());
            int factorialNumber = numberChosen;
            for (int i = numberChosen - 1; i >=1; i--)
            {
                factorialNumber = factorialNumber * i;
            }
            Console.WriteLine("Factorial of your number is: " +factorialNumber);
            Console.ReadLine();
        }
    }
}


         





