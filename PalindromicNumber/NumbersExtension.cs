using System;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("number cannot be less than zero");
            }

            return IsPalindromicNumberLocalFun(number);
            bool IsPalindromicNumberLocalFun(int numbeR)
            {
                int digitnum = (int)Math.Log10(numbeR) + 1;
                if (numbeR < 10 & numbeR >= 0)
                  {
                      return true;
                  }
                  else if (numbeR % 10 == numbeR / (int)Math.Pow(10, digitnum - 1))
                  {
                      numbeR = numbeR % (int)Math.Pow(10, digitnum - 1);
                      numbeR /= 10;
                      return IsPalindromicNumberLocalFun(numbeR);
                  }
                  else
                  {
                      return false;
                  }
            }
        }
    }
}
