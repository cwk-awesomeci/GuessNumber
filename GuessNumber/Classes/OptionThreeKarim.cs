using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumber.Interfaces;

/**
 * @classname: OptionThreeKarim
 * @author: Karim Saleh
 * @date: 2019/03/27
 * @description: implement interface IOption to play a GuessNumber game, between
 * 1 and 50.
 */
namespace GuessNumber.Classes
{
    class OptionThreeKarim : IOption
    {
        public int attempt { get; set; }
        public int randomNumber { get; set; }
        public int inputNumber { get; set; }

        /*
         * @Function name: CompareNumber
         * @Parameters: none
         * @Return: [int] 0 means guess and randomNumber are equal, 1 means the guess 
         * is less than randomNumber, 2 means the guess is more than randomNumber
         * @Description: this function will compare the inputNumber and randomNumber
         * and return the result of comparison to be provided to the user
         */
        public int CompareNumber()
        {
            if (inputNumber == randomNumber)
            {
                return 0;
            }

            else if (inputNumber < randomNumber)
            {
                return 1;
            }

            else
            {
                return 2;
            }
        }

        /*
         * @Function name: CreateRandomNumber
         * @Parameters: none
         * @Return: [int] type of a new random number
         * @Description: this function will create a new random number between 1 and 50
         */
        public int CreateRandomNumber()
        {
            //initializing randomNumber variable
            randomNumber = 0;

            //Creating new Random class object
            Random random = new Random();

            //Assigning randomNumber variable
            randomNumber = random.Next(1, 50);
            return randomNumber;
        }

        /*
         * @Function name: PlayAgain
         * @Parameters: none
         * @Return: [bool] true if the user want to play again, false if user
         * doesn't want to play again
         * @Description: this function will ask the user if he/she wants to play again and 
         * return the result
         */
        public bool PlayAgain()
        {
            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            //This loop will check if the user has provided proper choice
            while (true)
            {
                try
                {
                    Console.Write("Your choice: ");

                    int choice = Int16.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        return true;
                    }
                    else if (choice == 2)
                    {
                        return false;
                    }
                    else
                    {
                        throw new Exception("Invalid input. Please choose only 1 or 2.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /**
         * @function name: ReadInputNumber
         * @parameters: nil
         * @return: [int] the number that the user has provided
         * @description: this function will read input number from the user and will return it
         * after validation
         */
        public int ReadInputNumber()
        {
            //This loop will check if the user provided number between 1 and 50 only
            while (true)
            {
                try
                {
                    Console.Write("Your chosen number : ");
                    inputNumber = Int16.Parse(Console.ReadLine());

                    if (inputNumber > 50 || inputNumber < 1)
                    {
                        throw new Exception("Invalid input, please provide number between 1 and 50 only");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return inputNumber;
        }

        /**
         * @function name: PlayGame
         * @parameters: nil
         * @return: [bool] true means that player will play new game, false means
         * that player doesn't want to play new game
         * @description: this function will read input number from user for 3 attempts and will
         * compare it to the randomly generated number and give result 
         */
        public bool PlayGame()
        {
            attempt = 0;
            //Creating new random number
            randomNumber = CreateRandomNumber();

            Console.WriteLine("Please provide a number between 1 and 50");

            bool reAttempt = true;

            //This loop will give the user option to play 3 times (attempts)
            while (reAttempt)
            {
                //incrementing the attempt number
                attempt += 1;

                //Stopping after 3 attempts
                if (attempt > 3)
                {
                    Console.WriteLine("Sorry, you ran out of attempts.");
                    Console.WriteLine("The correct random number was " + randomNumber);
                    reAttempt = false;
                    break;
                }
                Console.WriteLine("This is your attempt number " + attempt);
                inputNumber = ReadInputNumber();
                int result = CompareNumber();

                switch (result)
                {
                    case 0:
                        Console.WriteLine("Wow, that is the correct answer.");
                        reAttempt = false;
                        if (attempt == 1)
                        {
                            Console.WriteLine("You win 100 USD.");
                            break;
                        }
                        else if (attempt == 2)
                        {
                            Console.WriteLine("You win 50 USD.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You win 20 USD.");
                            break;
                        }

                    case 1:
                        Console.WriteLine("Sorry, your guessed number is less than the random" +
                            " number.");
                        break;
                    case 2:
                        Console.WriteLine("Sorry, your guessed number is more than the random" +
                            " number.");
                        break;
                }

            }

            bool playAgain = PlayAgain();
            return playAgain;
        }
    }
}
