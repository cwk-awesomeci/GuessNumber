using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumber.Interfaces;

namespace GuessNumber.Classes
{
    class OptionTwoCheng : IOption
    {
        public int attempt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int randomNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int inputNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CompareNumber()
        {
            throw new NotImplementedException();
        }

        public int CreateRandomNumber()
        {
            throw new NotImplementedException();
        }

        public bool PlayAgain()
        {
            throw new NotImplementedException();
        }

        public bool PlayGame()
        {
            return true;
        }

        public int ReadInputNumber()
        {
            throw new NotImplementedException();
        }
    }
}
