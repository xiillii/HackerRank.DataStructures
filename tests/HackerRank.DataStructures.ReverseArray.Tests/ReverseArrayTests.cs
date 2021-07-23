using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using HackerRank.DataStructures.ReverseArray;

namespace HackerRank.DataStructures.ReverseArray.Tests
{
    public class ReverseArrayTests
    {
        [Fact]
        public void Test_Reverse()
        {
            // arrange
            var array = new List<int>(new[] {1, 2, 4, 5});
            // act
            var result = Result.ReverseArray(array);

            // assert
            Assert.NotEmpty(result);
            Assert.Equal("5 4 2 1", string.Join(' ', result));
        }
    }
}
