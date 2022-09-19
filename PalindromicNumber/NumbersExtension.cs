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
            int digitnum = (int)Math.Log10(number) + 1;
            if (number < 0)
            {
                throw new ArgumentException("number cannot be less than zero");
            }

            if (number < 10 & number >= 0)
            {
                return true;
            }
            else if (number % 10 == number / (int)Math.Pow(10, digitnum - 1))
            {
                number = number - (number / (int)Math.Pow(10, digitnum - 1) * (int)Math.Pow(10, digitnum - 1));
                number /= 10;
                return IsPalindromicNumber(number);
            }
            else
            {
                return false;
            }
        }
    }
}
