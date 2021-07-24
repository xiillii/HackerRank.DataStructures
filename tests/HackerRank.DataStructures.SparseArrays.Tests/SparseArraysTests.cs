using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRank.DataStructures.SparseArrays.Tests
{
    public class SparseArraysTests
    {
        [Fact]
        public void MatchingStrings_Test()
        {
            // arrange
            var arrStrings = new List<string>(new[]
            {
                "abcde",
                "sdaklfj",
                "asdjf",
                "na",
                "basdn",
                "sdaklfj",
                "asdjf",
                "na",
                "asdjf",
                "na",
                "basdn",
                "sdaklfj",
                "asdjf",
            });
            var arrQueries = new List<string>(new[]
            {
                "abcde",
                "sdaklfj",
                "asdjf",
                "na",
                "basdn",
                "1"
            });
            // act

            var target = Result.MatchingStrings(arrStrings, arrQueries);

            // assert
            Assert.Equal("1 3 4 3 2 0", string.Join(' ', target));
        }
    }
}