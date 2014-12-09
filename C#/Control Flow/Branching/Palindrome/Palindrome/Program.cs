using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\n To find if your number is Palindrome or not! ");
            Console.Write("\n Enter a number: ");
            int number

            int numberUserChoice = int.Parse(Console.ReadLine());
            int digitsToProcess = numberUserChoice;            
            int reversedNumber = 0;

            while (numberUserChoice > 0)
            {
                int remainderNumber = numberUserChoice % 10;
                numberUserChoice = numberUserChoice / 10;
                reversedNumber = reversedNumber * 10 + remainderNumber;
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", reversedNumber);
            if (digitsToProcess == reversedNumber)
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();
        }
    }

}
