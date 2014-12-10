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
            Console.WriteLine("Enter a number:");
            int numberChoice = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= numberChoice; i++)
            {
                for (int j = 1; j <= numberChoice - i; j++)
                    Console.Write(" ");
                for (int x = 1; x <= i; x++)
                    Console.Write(" *");
                    Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
