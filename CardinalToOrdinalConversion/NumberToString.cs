using System;

namespace CardinalToOrdinalConversion
{
    public class NumberToString
    {
        /// <summary>
        /// Englishes from number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="displaySign">if set to <c>true</c> [display sign].</param>
        /// <returns></returns>
        public static string StringFromNumber(int number, bool displaySign = false)
        {
            return StringFromNumber((long)number, displaySign);
        }

        /// <summary>
        /// Englishes from number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="displaySign">if set to <c>true</c> [display sign].</param>
        /// <returns></returns>
        public static string StringFromNumber(long number, bool displaySign = false)
        {
            if (number == 0)
            {
                return Vectors.OnesMapping[number];
            }

            string sign = "Positive";
            if (number < 0)
            {
                sign = "Negative";
                number = Math.Abs(number);
            }

            string retVal = null;
            int group = 0;
            while (number > 0)
            {
                int numberToProcess = (int)(number % 1000);
                number = number / 1000;

                string groupDescription = ProcessGroup(numberToProcess);
                if (groupDescription != null)
                {
                    if (group > 0)
                    {
                        retVal = Vectors.MultipleMapping[group] + " " + retVal;
                    }
                    retVal = groupDescription + " " + retVal;
                }

                group++;
            }

            return displaySign ? (sign + " " + retVal).TrimEnd() : retVal.TrimEnd();
        }

        /// <summary>
        /// Processes the group.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        private static string ProcessGroup(int number)
        {
            int tens = number % 100;
            int hundreds = number / 100;

            string retVal = null;
            if (hundreds > 0)
            {
                retVal = Vectors.OnesMapping[hundreds] + " " + Vectors.MultipleMapping[0];
            }
            if (tens > 0)
            {
                if (tens < 20)
                {
                    retVal += ((retVal != null) ? " " : "") + Vectors.OnesMapping[tens];
                }
                else
                {
                    int ones = tens % 10;
                    tens = (tens / 10) - 2; 

                    retVal += ((retVal != null) ? " " : "") + Vectors.TensMapping[tens];

                    if (ones > 0)
                    {
                        retVal += ((retVal != null) ? " " : "") + Vectors.OnesMapping[ones];
                    }
                }
            }

            return retVal;
        }
    }
}
