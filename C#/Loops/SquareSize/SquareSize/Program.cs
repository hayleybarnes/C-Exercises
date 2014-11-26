using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main()
        {
            int outputSize;

            while (true)
            {
                Console.Write("Please enter the size you would like your square to be: ");
                int.TryParse(Console.ReadLine(), out outputSize);
                if (outputSize > 0) break;

            }

            OutputSquare(outputSize);

            Console.ReadKey();
        }

        static void OutputSquare(int outputSize)
        {
            for (int i = 0; i < outputSize; i++)
            {
                for (int j = 0; j < outputSize; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Congrats with your square. Press any key to quit program!");
            Console.ReadKey();
        }
    }
}


