using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{

    class program
    {
        static void Main()
        {

            //Write a dice simulator
            Console.WriteLine("Please roll the dice, press any key");
            Console.WriteLine();
            
            for (int i = 0; i <= 100; i++ )
            {
                Random diceNumbers = new Random();
                int diceThrow = diceNumbers.Next(1, 7);
                Console.WriteLine(diceThrow);
                Console.ReadLine();
                diceThrow = diceNumbers.Next(1, 7);
                
            }
        }
    }
}