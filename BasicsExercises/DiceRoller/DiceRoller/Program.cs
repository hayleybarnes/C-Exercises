using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{

    class program
    {
        static int Main()
        {
            //Write a dice simulator
            Console.WriteLine("Please roll the dice, press any key");
            Console.WriteLine();
            Random rndNumbers = new Random();
            int rndNumber = rndNumbers.Next(0, 7);
            Console.ReadKey();
            Console.WriteLine("Your Number is : {0}", rndNumber);
            Console.ReadKey();
            Console.WriteLine("Done, press any key to finish!");
            Console.ReadKey();
            return 0;
        }
    }
}
