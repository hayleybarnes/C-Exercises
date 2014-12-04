using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Click to see your isosceles triangle");
            Console.ReadKey();
            int i;
            int j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < i; j++)
                Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}