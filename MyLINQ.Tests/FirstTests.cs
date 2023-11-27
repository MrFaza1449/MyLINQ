using MyLinq;
using System;
using Xunit;

namespace MyLINQ.Tests
{
    public class FirstTests
    {
        [Fact]
        public void NotEmptyCollection_GetFirstElement_Success()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 10, 20 };
            Assert.NotNull(array.First());
        }
        [Fact]
        public void EmptyCollection_GetFirst_Throws()
        {
            var array = Array.Empty<int>();
            Assert.Throws<InvalidOperationException>(() => array.First());
        }
        [Fact]
        public void EmptyCollection_GetFirstWithCriterion_Throws()
        {
            var array = Array.Empty<int>();



            Assert.Throws<InvalidOperationException>(() => array.First(array => array == 3));
        }
    }
}
