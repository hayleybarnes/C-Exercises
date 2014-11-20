using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static int Main()
        {
            //Write a program where the computer chooses a number and the user guesses
            Console.WriteLine("Guess a number from 1-100?");
            Console.WriteLine("What is your number?");
            String number = Console.ReadLine();
            Console.WriteLine("Your number is," + number);
            Console.WriteLine();
            Random rndNumbers = new Random();
            int rndNumber = rndNumbers.Next(1, 100);
            Console.ReadKey();
            Console.WriteLine("Computer number is, {0}", rndNumber);
            Console.ReadKey();

            Console.WriteLine("Done, press any key to finish!");
            Console.ReadKey();
            return 0;
        }
    }
}