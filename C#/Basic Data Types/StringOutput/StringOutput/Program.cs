using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please answer some questions about yourself");
            Console.WriteLine();

            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            String age = Console.ReadLine();

            Console.WriteLine("What is your gender?");
            String gender = Console.ReadLine(); 
   
            Console.WriteLine("Hello {0}, your age is {1}, and gender is {2}", name, age, gender);
            Console.ReadLine();
        }
    }
}
