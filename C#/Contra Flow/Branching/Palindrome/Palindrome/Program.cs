﻿using System;
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
            int number, remainder, sum = 0, temp;
            Console.WriteLine("\n To find if your number is Palindrome or not! ");
            Console.Write("\n Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            while (Convert.ToBoolean(number))
            {
                remainder = number % 10;  
                number = number / 10; 
                sum = sum * 10 + remainder; 
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            if (temp == sum)
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
       