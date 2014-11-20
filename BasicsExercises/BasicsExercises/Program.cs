using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basics
            //write a program to output "hello world"
            Console.WriteLine("hello world!");

            //write a program that outputs what is your name, waits for user to type their name, outputs "hello name" 
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("hello" + name);
            Console.WriteLine("Done- press any key");
            Console.ReadKey();

        }
    }
}
