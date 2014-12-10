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
            Console.WriteLine("Enter a number:");
            int numberChoice = Int32.Parse(Console.ReadLine());
        
            for (int i = 0; i <= numberChoice; i++)
            {
                for (int j = 0; j < i; j++)
                Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}