using CardinalToOrdinalConversion.Extentions;
using NUnit.Framework;

namespace CardinalToOrdinalConversion.Tests
{
    [TestFixture, Category("Unit Test")]
    public class NumberExtensionTest
    {
        [Test]
        public void ToOrdinal_Should_Return_String_Type()
        {
            long lngNum = 100;
            int intNUm = 100;
            string stringNum = "Hundred";

            Assert.AreEqual(lngNum.ToOrdinal().GetType().FullName, typeof(string).FullName);
            Assert.AreEqual(intNUm.ToOrdinal().GetType().FullName, typeof(string).FullName);
            Assert.AreEqual(stringNum.ToOrdinal().GetType().FullName, typeof(string).FullName);
        }

        [Test]
        public void ToOrdinal_Should_Return_Ordinal_String_Recieving_Int_Parameter()
        {
            var stringOrdinal = 10.ToOrdinal();

            Assert.AreEqual(stringOrdinal, "10th");
        }

        [Test]
        public void ToOrdinal_Should_Return_Ordinal_String_Recieving_Long_Parameter()
        {
            long num = 10;

            Assert.AreEqual(num.ToOrdinal(), "10th");
        }

        [Test]
        public void ToOrdinal_Should_Return_Ordinal_String_Recieving_String_Parameter()
        {
            string stringNum = "Ten";

            Assert.AreEqual(stringNum.ToOrdinal(), "Tenth");
        }
    }
}
