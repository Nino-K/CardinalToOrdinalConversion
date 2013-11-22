using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CardinalToOrdinalConversion.Tests
{
    [TestFixture, Category("Unit Test")]
    public class NumberToStringTest
    {
        [Test]
        public void EnglishFromNumber_Should_Return_String_Recieving_Int_Argument()
        {
            int testNum1 = 22;
            int testNum2 = 387;

            string testString1 = NumberToString.StringFromNumber(testNum1);
            string testString2 = NumberToString.StringFromNumber(testNum2);

            Assert.AreEqual(testString1.GetType().FullName, typeof (string).FullName);
            Assert.AreEqual(testString2.GetType().FullName, typeof (string).FullName);
        }

        [Test]
        public void EnglishFromNumber_Should_Return_String_Recieving_Long_Argument()
        {
            long testNum1 = 100000001;
            long testNum2 = 3000000000003;

            string testString1 = NumberToString.StringFromNumber(testNum1);
            string testString2 = NumberToString.StringFromNumber(testNum2);

            Assert.AreEqual(testString1.GetType().FullName, typeof(string).FullName);
            Assert.AreEqual(testString2.GetType().FullName, typeof(string).FullName);
        }

        [Test]
        public void EnglishFromNumber_Should_Return_Correct_Ordinal_Number_In_String()
        {
            int testNum1 = 22;
            int testNum2 = 387;

            string testString1 = NumberToString.StringFromNumber(testNum1);
            string testString2 = NumberToString.StringFromNumber(testNum2);

            Assert.AreEqual(testString1, "Twenty Two");
            Assert.AreEqual(testString2, "Three Hundred Eighty Seven");
        }

        [Test]
        public void EnglishFromNumber_Should_Return_Correct_Ordinal_Number_Sign()
        {
            long testNum1 = 22;
            int testNum2 = -387;

            string testString1 = NumberToString.StringFromNumber(testNum1, true);
            string testString2 = NumberToString.StringFromNumber(testNum2, true);

            Assert.AreEqual(testString1, "Positive Twenty Two");
            Assert.AreEqual(testString2, "Negative Three Hundred Eighty Seven");
        }
    }
}
