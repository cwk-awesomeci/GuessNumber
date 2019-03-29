using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Interfaces
{
    interface IOption
    {
        int attempt { get; set; }
        int randomNumber { get; set; }
        int inputNumber { get; set; }

        int CreateRandomNumber();
        int ReadInputNumber();
        int CompareNumber();
        bool PlayGame();
        bool PlayAgain();
    }
}
