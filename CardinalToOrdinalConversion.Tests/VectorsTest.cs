using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CardinalToOrdinalConversion.Tests
{
    [TestFixture, Category("Unit Test")]
    public class VectorsTest
    {
        [Test]
        public void Vectors_Should_Not_Be_Empty()
        {
            var onesMappinglength = Vectors.OnesMapping.Length;
            var tensMappinglength = Vectors.TensMapping.Length;
            var multipleMappinglenght = Vectors.MultipleMapping.Length;
            var parisLength = Vectors.NumericPairs.Count;

            Assert.AreEqual(onesMappinglength, 20);
            Assert.AreEqual(tensMappinglength, 8);
            Assert.AreEqual(multipleMappinglenght, 5);
            Assert.AreEqual(parisLength, 36);
        }
    }
}
