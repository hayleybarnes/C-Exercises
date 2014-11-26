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
        int i, numberChosen, factorialNumber;
            Console.WriteLine("Pick a number you want to find the factorial of...");
            numberChosen= int.Parse(Console.ReadLine());
            factorialNumber = numberChosen;
            for (i = numberChosen - 1; i >=1; i --)
            {
                factorialNumber = factorialNumber * i;
            }
            Console.WriteLine("\n Factorial of your number is: " +factorialNumber);
            Console.ReadLine();
        }
    }
}


         





