using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CardinalToOrdinalConversion.Extentions
{
    public static class NumberExtensions
    {
        /// <summary>
        /// To the ordinal.
        /// </summary>
        /// <param name="cardinal">The cardinal.</param>
        /// <returns></returns>
        public static string ToOrdinal(this long cardinal)
        {
            if (cardinal < 0) return cardinal.ToString(CultureInfo.InvariantCulture);

            long lastTwoDigits = cardinal%100;
            long lastDigit = lastTwoDigits%10;

            string suffix;

            switch (lastDigit)
            {
                case 1:
                    suffix = "st";
                    break;
                case 2:
                    suffix = "nd";
                    break;
                case 3:
                    suffix = "rd";
                    break;
                default:
                    suffix = "th";
                    break;
            }

            if (lastTwoDigits >= 11 && lastTwoDigits <= 13)
                suffix = "th";

            return string.Format("{0}{1}", cardinal, suffix);
        }

        /// <summary>
        /// To the ordinal.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public static string ToOrdinal(this int number)
        {
            return ((long) number).ToOrdinal();
        }

        /// <summary>
        /// To the ordinal.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">number</exception>
        public static string ToOrdinal(this string number)
        {
            if (String.IsNullOrEmpty(number)) throw new ArgumentNullException("number");

            var pairs = Vectors.NumericPairs;

            PreCheckToOrdinalArgument(number, pairs);

            // extract last word
            number = number.TrimEnd().TrimEnd('-');
            int index = number.LastIndexOfAny(new char[] {' ', '-'});
            string last = number.Substring(index + 1);
            // make replacement and maintain original capitalization
            if (last == last.ToLower())
            {
                last = pairs[last];
            }
            else if (last == last.ToUpper())
            {
                last = pairs[last.ToLower()].ToUpper();
            }
            else
            {
                last = last.ToLower();
                last = Char.ToUpper(pairs[last][0]) + pairs[last].Substring(1);
            }
            return number.Substring(0, index + 1) + last;
        }

        /// <summary>
        /// Pres the check to ordinal argument.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="pairs">The pairs.</param>
        /// <exception cref="System.IO.InvalidDataException">number is not valid</exception>
        private static void PreCheckToOrdinalArgument(string number, Dictionary<string, string> pairs)
        {
            // Check if number is valid
            string temp = number.ToLower().Trim().Replace(" and ", " ");
            string[] words = temp.Split(new char[] {' ', '-'}, StringSplitOptions.RemoveEmptyEntries);
            if (words.Any(word => !pairs.ContainsKey(word)))
            {
                throw new InvalidDataException("number is not valid");
            }
        }
    }
}
