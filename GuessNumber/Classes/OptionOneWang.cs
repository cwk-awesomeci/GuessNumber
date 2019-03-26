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

        public void PlayGame()
        {
            throw new NotImplementedException();
        }

        public int ReadInputNumber()
        {
            throw new NotImplementedException();
        }

        bool IOption.PlayGame()
        {
            throw new NotImplementedException();
        }
    }
}
