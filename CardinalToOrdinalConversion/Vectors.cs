using System.Collections.Generic;

namespace CardinalToOrdinalConversion
{
    public static class Vectors
    {
       public static string[] OnesMapping =
            new string[]
                {
                    "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                    "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen",
                    "Nineteen"
                };

        public static string[] TensMapping =
            new string[]
                {
                    "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
                };

        public static string[] MultipleMapping =
            new string[]
                {
                    "Hundred", "Thousand", "Million", "Billion", "Trillion"
                };

        public static Dictionary<string, string> NumericPairs = new Dictionary<string, string>
                {
                    {"zero", "zeroth"},
                    {"nought", "noughth"},
                    {"one", "first"},
                    {"two", "second"},
                    {"three", "third"},
                    {"four", "fourth"},
                    {"five", "fifth"},
                    {"six", "sixth"},
                    {"seven", "seventh"},
                    {"eight", "eighth"},
                    {"nine", "ninth"},
                    {"ten", "tenth"},
                    {"eleven", "eleventh"},
                    {"twelve", "twelfth"},
                    {"thirteen", "thirteenth"},
                    {"fourteen", "fourteenth"},
                    {"fifteen", "fifteenth"},
                    {"sixteen", "sixteenth"},
                    {"seventeen", "seventeenth"},
                    {"eighteen", "eighteenth"},
                    {"nineteen", "nineteenth"},
                    {"twenty", "twentieth"},
                    {"thirty", "thirtieth"},
                    {"forty", "fortieth"},
                    {"fifty", "fiftieth"},
                    {"sixty", "sixtieth"},
                    {"seventy", "seventieth"},
                    {"eighty", "eightieth"},
                    {"ninety", "ninetieth"},
                    {"hundred", "hundredth"},
                    {"thousand", "thousandth"},
                    {"million", "millionth"},
                    {"billion", "billionth"},
                    {"trillion", "trillionth"},
                    {"quadrillion", "quadrillionth"},
                    {"quintillion", "quintillionth"}
                };
    }
}
