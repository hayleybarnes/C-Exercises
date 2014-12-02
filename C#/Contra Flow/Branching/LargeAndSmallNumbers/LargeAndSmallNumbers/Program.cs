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
            Console.Write("Hello please select 2 numbers, press enter to continue...");
            Console.ReadLine();

            int large = 0;
            int small = 0;
            Console.Write("Enter first number: ");
            int firstChoice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondChoice = Convert.ToInt32(Console.ReadLine());
            if (firstChoice > secondChoice)
            {
                large = firstChoice;
            }

            if (firstChoice < secondChoice)
            {
                large = secondChoice;
                
            }
            Console.WriteLine("Your largest number is: " + large);
            Console.ReadKey();
        }
    }
}
