using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_UpTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pascal Triangle:");
            Console.ReadKey();

            int sizeOfTriangle = 12;

            for (int i = 1; i <= sizeOfTriangle; i++)
            {
                for (int j = 1; j <= sizeOfTriangle - i; j++)
                    Console.Write(" ");
                for (int x = 1; x <= i; x++)
                    Console.Write(" *");
                    Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
