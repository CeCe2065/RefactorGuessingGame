using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorGuessingGame
{
    class Program {

        public static void SayEureka() {
        Console.WriteLine("Say Eureka!");

        }

        public static bool CheckAnswer(int randomnumber,  int userentry)
        {
            
            if (userentry > randomnumber)
            {
                Console.WriteLine($"You entered {userentry}. That's too high. Try againg.");

                
            }

            else if (userentry < randomnumber && randomnumber > 0)
            {
                Console.WriteLine($"You entered {userentry}. That's too low.Try again.");
                
            }

            else if (userentry == randomnumber)
            {
                Console.WriteLine($"You entered {userentry}. That's right.Good job.");
                return true;    
            }

            else if (userentry == 0)
            {
                Console.WriteLine("That is not a valid number.");
            }
            return false;

        }


        static void Main(string[] args)
        {
            Program.SayEureka();

            //Refactor your number guessing game so that it uses 3 or more method(s), 
            //at least 2 of them should have arguments passed in and 
            //2 should return something other than void.

            
            int numberOfTries = 0;
            bool keepGoing = true;
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 100);


            int[] allGuesses = new int[5];


            while (keepGoing)
            {
                //pick a number, display guessed number
                Console.Write("Guess any integer between 1 and 100: ");
                int userentry = 0;
                int.TryParse(Console.ReadLine(), out userentry);
                allGuesses[numberOfTries] = userentry;


                if (numberOfTries == 4)

                {
                    Console.WriteLine($"You've already tried 5 times. You lose.");
                    keepGoing = false;
                }

                else if (CheckAnswer(randomnumber, userentry)) {

                    break;


                }
                numberOfTries++;


            }



            for (int i = 0; i < allGuesses.Length; i++)
            {
                CheckAnswer(randomnumber, allGuesses[i]);
            }
        }

    }
}
