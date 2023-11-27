using MyLinq;
using System;
using System.Collections.Generic;
using Xunit;

namespace MyLINQ.Tests
{
    public class WhereTest
    {
        [Fact]
        public void NotEmptyCollection_GetElementsMorehanFive_Success()
        {
            //Arrange.
            var array = new int[] { 1, 2, 3, 4, 5, 10, 20 };
            var expected = new[] { 10, 20 };
            //Act.
            var result = array.Where(o => o > 5);
            //Assert.
            Assert.Equal(expected, result);
        }
        [Fact]
        public void NullSource_Throws()
        {
            //Arrange.
            int[] array = null;
            var expected = new[] { 10, 20 };
            //Act+Assert.
            Assert.Throws<InvalidOperationException>(() => array.Where(o => o > 0));
        }
        [Fact]
        public void NotEmptyColletcion_TryToGetNotFitCollection_EmptyResult()
        {
            //Arrange.
            var array = new int[] { 1, 2, 3, 4, 5, 10, 20 };
            //Act.
            var result = array.Where(o => o < 0);
            //Assert.
            Assert.Empty(result);
        }
        [Fact]
        public void ColectionWithTupels_GetSpecificOne_Success()
        {
            var array = new List<(int Grade, double Salary)>
            {
                (Grade:5,Salary:1200 ),
                (Grade:10, Salary:2400)
            };
            var result = array.Where(o => o.Grade == 10);

            Assert.Single(result);
        }




        //метод Any, без критерия или с ним , добавить в таблицу ссылку на акк в гите
    }
}
