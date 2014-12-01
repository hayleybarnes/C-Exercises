using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers 1-100");
            Console.WriteLine();
            Console.ReadLine();

            for (int i = 1; i <= 100; i++)
            {
                bool fizzOutput = i % 3 == 0;
                bool buzzOutput = i % 5 == 0;
                if (fizzOutput && buzzOutput)
                    Console.WriteLine("Fizz Buzz");
                else if (fizzOutput)
                    Console.WriteLine("Fizz");
                else if (buzzOutput)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}




