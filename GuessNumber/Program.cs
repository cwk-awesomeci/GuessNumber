using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumber;
using GuessNumber.Classes;
using GuessNumber.Interfaces;

namespace GuessNumber
{

    class Program
    {
        static void Main(string[] args)
        {
            bool xxx = true;
            while (xxx) { 
                Console.WriteLine("Welcome to Guess a Number game");
                Console.WriteLine("Please choose the range you want to guess");
                Console.WriteLine("1- From 1 to 10");
                Console.WriteLine("2- From 1 to 20");
                Console.WriteLine("3- From 1 to 50");
                Console.Write("Your choice: ");

                int choice = Int16.Parse(Console.ReadLine());

                Console.WriteLine(choice);
                IOption handler = null;

                if (!choice.Equals(1) && !choice.Equals(2) && !choice.Equals(3))
                {
                    Console.WriteLine("Sorry, this is not a valid choice");
                    Console.WriteLine("");
                    continue;
                }
                else if (choice == 1)
                {
                    handler = new OptionOneWang();
                }
                else if (choice == 2)
                {
                    handler = new OptionTwoCheng();
                }
                else if (choice == 3)
                {
                    handler = new OptionThreeKarim();
                }
                if (handler.PlayGame()) {
                    continue;
                }

                break;               
        }
        }
    }
}
