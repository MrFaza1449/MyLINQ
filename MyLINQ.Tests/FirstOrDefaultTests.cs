using MyLinq;
using System;
using Xunit;

namespace MyLINQ.Tests
{
    public class FirstOrDefaultTests
    {
        [Fact]
        public void EmptyCollection_GetFirstOrDefault_ReturnDefault()
        {
            var array = Array.Empty<int>();
            var result = array.FirstOrDefault();
            Assert.Equal(0, result);
        }
        [Fact]
        public void NotEmptyCollection_GetFirstOrDefault_ReturnFirst()
        {
            var array = new int[] { 1, 2, 3 };
            var result = array.FirstOrDefault();
            Assert.Equal(1, result);
        }
        [Fact]
        public void NotEmptyCollection_GetFirstOrDefaultWithCriterion_Succes()
        {
            var array = new int[] { 1, 2, 3 };

            var result = array.FirstOrDefault(array => array == 3);

            Assert.Equal(3, result);
        }

        [Fact]
        public void NotEmptyCollection_GetFirstOrDefaultWithCriterionNotElement_ReturnDefault()
        {
            var array = new int[] { 1, 2, 3 };

            var result = array.FirstOrDefault(array => array == 33);

            Assert.Equal(0, result);
        }
    }
}
