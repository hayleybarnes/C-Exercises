using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to see it's prime numbers:");
            int number = int.Parse(Console.ReadLine());
            bool current = false;
            for (int i = 2; i <= number; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        current = true;
                    }
                }
                if (current == false)
                {
                    Console.WriteLine("{0} is a prime number of {1}", i, number);
                }
                else
                    current = false;
            }
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}

