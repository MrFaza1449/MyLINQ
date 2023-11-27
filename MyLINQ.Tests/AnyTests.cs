using MyLinq;
using Xunit;

namespace MyLINQ.Tests
{
    public class AnyTests
    {
        [Fact]
        public void EmptyCollection_Any_ReturnFalse()
        {
            var arr = new int[] { };
            Assert.False(arr.Any());
        }
        [Fact]
        public void EmptyCollection_AnyWithCriterion_ReturnFalse()
        {
            var arr = new int[] { 1, 2, 3, 4, 3 };
            Assert.True(arr.Any(x => x == 3));
        }
    }
}
