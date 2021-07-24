using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRank.DataStructures.DynamicArray.LastAnswer.Tests
{
    public class DynamicArrayLastAnswerTests
    {
        [Fact]
        public void LastAnswer_Test()
        {
            // arrange
            var target = new List<List<int>>
            {
                new(new[] {1, 0, 5}),
                new(new[] {1, 1, 7}),
                new(new[] {1, 0, 3}),
                new(new[] {2, 1, 0}),
                new(new[] {2, 1, 1}),
            };
            
            // act
            var result = Result.DynamicArray(2, target);

            // assert
            Assert.Equal("7 3", string.Join(' ', result));
        }
    }
}