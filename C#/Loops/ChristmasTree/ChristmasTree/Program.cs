using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Christmas Tree");
            Console.ReadKey();

            int sizeOfTriangle = 6;

            for (int i = 1; i <= sizeOfTriangle; i++)
            {
                for (int j = 1; j <= sizeOfTriangle - i; j++)
                    Console.Write(" ");
                for (int x = 1; x <= i; x++)
                    Console.Write(" *");
                Console.WriteLine("");
            }
            for (int baseTriangle = 0; baseTriangle < 2; baseTriangle++)
            {
                Console.Write("      !");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}





       


   