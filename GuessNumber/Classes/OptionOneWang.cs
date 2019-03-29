/**
 * @classname: OptionOneWang
 * @author: Ben Wang
 * @date: 2019/03/27
 * @description: implement interface, play GuessNumber games.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumber.Interfaces;

namespace GuessNumber.Classes
{
    class OptionOneWang : IOption
    {
        // try attemps, max number is 3
        public int attempt { get; set; }
        // generated random number, from 1 to 10
        public int randomNumber { get; set; }
        // user current input number
        public int inputNumber { get; set; }

        /**
         * @function name: CompareNumber
         * @parameters: nil
         * @return: [int] 0 means qual, 1 means random number greater than input number, -1 mean random nubmer less than input number
         * @description: compare random number and input number
         */
        public int CompareNumber()
        {
            if (randomNumber > inputNumber)
            {
                Console.WriteLine("Your input is greater than the random number!");
                return 1;
            }
            else if (randomNumber < inputNumber)
            {
                Console.WriteLine("Your input is less than the random number!");
                return -1;
            }
            else
            {
                int dollar = attempt == 1 ? 10 : (attempt == 2 ? 5 : 2);
                Console.WriteLine("Bingo! It is your " + attempt + " attempts! Here is " + Convert.ToString(dollar) + "dollars for you!");
                return 0;
            }
        }

        /**
        * @function name: CreateRandomNumber
        * @parameters: nil
        * @return: [int] the created random number
        * @description: create a random number for 3 rounds of the game.
        */
        public int CreateRandomNumber()
        {
            if (randomNumber == 0) {
                Random ran = new Random();
                randomNumber = ran.Next(1, 10);
            }
            return randomNumber;
        }

        /**
        * @function name: PlayAgain
        * @parameters: nil
        * @return: [bool] if the user want to play again
        * @description: get the users' input and return a bool value
        */
        public bool PlayAgain()
        {
            while ( true ) { 
                Console.WriteLine("Do you want to play again? [yes/no]");
                string input = Console.ReadLine();
                if (input.Equals("yes"))
                {
                    return true;
                }
                else if (input.Equals("no"))
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
        }

        /**
        * @function name: PlayGame
        * @parameters: nil
        * @return: void
        * @description: main logic of the guess game
        */
        public Boolean PlayGame()
        {
            while (true)
            { 
                attempt += 1;
                if (attempt > 3)
                {
                    Console.WriteLine("Sorry, you did not guess the right number. The correct number is " + Convert.ToString(randomNumber) );
                    clear();
                    return PlayAgain();
                }
                ReadInputNumber();
                CreateRandomNumber();
                if (CompareNumber() == 0)
                {
                    clear();
                    return PlayAgain();
                }
            }
        }

        /**
        * @function name: ReadInputNumber
        * @parameters: nil
        * @return: [int] the current user input number
        * @description: get every round user input number
        */
        public int ReadInputNumber()
        {
            Console.WriteLine("round " + attempt + ", please guess: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            return inputNumber;
        }

        /**
        * @function name: clear
        * @parameters: nil
        * @return: void
        * @description: clear last time game information.
        */
        public void clear() {
            randomNumber = 0;
            attempt = 0;
        }
    }
}
