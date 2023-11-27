using MyLinq;
using Xunit;

namespace MyLINQ.Tests
{
    public class SelectTests
    {
        [Fact]
        public void CollectionWithElements_SelectStrings_Success()
        {
            //Arrange
            var item = new int[] { 1, 2, 3 };
            //Act
            var results = item.Select(o => o + 1);
            //Assert
            Assert.Equal(new int[] { 2, 3, 4 }, results);
        }
        [Fact]
        public void CollectionWithElements_SelectConverterToString_Success()
        {
            //Arrange
            var item = new int[] { 1, 2, 3 };
            //Act
            var results = item.Select(o => o.ToString() + "\tпривет");
            //Assert
            Assert.Equal(new string[] { "1\tпривет", "2\tпривет", "3\tпривет" }, results);
        }
    }
}
