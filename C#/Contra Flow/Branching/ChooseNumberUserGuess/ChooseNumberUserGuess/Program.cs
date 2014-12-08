using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            //Write a program where the computer chooses a number and the user guesses
            Console.WriteLine("Guess a number from 1-10?");

            int playerNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Random randomNumber = new Random();
            int numberToGuess = randomNumber.Next(1, 10);

            if (playerNumber == numberToGuess)
            {
                Console.WriteLine("Well done. You've won the game!");        
            }
            Console.WriteLine("Never guessed the right number, press any key to finish!");
            Console.ReadKey();
        }

    }
}
