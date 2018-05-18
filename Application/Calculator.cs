using System;

namespace Application
{
    public class Calculator
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public bool IsOddNumber(int number)
        {
            return number % 2 == 1;
        }

    }
}
