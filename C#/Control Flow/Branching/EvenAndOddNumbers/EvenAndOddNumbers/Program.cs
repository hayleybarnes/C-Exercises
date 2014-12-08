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
            Console.WriteLine("Please enter your number: ");
            var userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Your number {0} is even", userNumber);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your number {0} is odd", userNumber);
                Console.ReadKey();
            }
            Console.WriteLine("Done");
        }
    }
}



