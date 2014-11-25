using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMax
{
    class Program
    {
        static void Main()
     {
         int currentMaxValue = Int32.MinValue;
         int currentMinValue = Int32.MaxValue;
         for (int i = 0; i < 10; i++)
         {
             Console.WriteLine("Your number is:");
             string userNumberText = Console.ReadLine();
             int userNumber = int.Parse(userNumberText);

             if (userNumber > currentMaxValue)
             {
                 currentMaxValue = userNumber;
             }

             if (userNumber < currentMinValue)
             {
                 currentMinValue = userNumber;
             }
         }

             Console.WriteLine("Large Number: {0} Smallest Number: {1}", currentMaxValue, currentMinValue);

             Console.ReadKey();
         
        }
    }
}

