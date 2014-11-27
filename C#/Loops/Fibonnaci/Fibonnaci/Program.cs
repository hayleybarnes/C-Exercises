using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 1;
            int sumNumber = 1;
            Console.WriteLine("Press enter for the first 100 number in 'Fibonnaci Number Sequence':");
            Console.ReadKey();
            while (number1 < 100)
            {
                sumNumber = number1 + number2;
                number1 = number2;
                number2 = sumNumber;
                Console.WriteLine(number2); 
            }
            Console.ReadLine();
            Console.WriteLine("Press any key to quit the program");
            Console.ReadLine();
        }
    }
}
