using System.Collections.Generic;
using Xunit;

namespace HackerRank.DataStructures.HourGlassSum.Tests
{
    public class HourGlassSumTests
    {
        [Fact]
        public void Test_Get3x3()
        {
            // arrange
            var target = new List<List<int>>
            {
                new(new[] {-9, -9, -9, 1, 1, 1}),
                new(new[] {0, -9, 0, 4, 3, 2}),
                new(new[] {-9, -9, -9, 1, 2, 3}),
                new(new[] {0, 0, 8, 6, 6, 0}),
                new(new[] {0, 0, 0, -2, 0, 0}),
                new(new[] {0, 0, 1, 2, 4, 0})
            };

            // act
            var result = Result.Get3x3Array(target, 0, 0);
            var result2 = Result.Get3x3Array(target, 2, 1);
            var result3 = Result.Get3x3Array(target, 1, 3);

            // assert
            Assert.Equal("-9 -9 -9", string.Join(' ', result[0]));
            Assert.Equal("0 -9 0", string.Join(' ', result[1]));
            Assert.Equal("-9 -9 -9", string.Join(' ', result[2]));
            
            Assert.Equal("-9 -9 1", string.Join(' ', result2[0]));
            Assert.Equal("0 8 6", string.Join(' ', result2[1]));
            Assert.Equal("0 0 -2", string.Join(' ', result2[2]));
            
            Assert.Equal("4 3 2", string.Join(' ', result3[0]));
            Assert.Equal("1 2 3", string.Join(' ', result3[1]));
            Assert.Equal("6 6 0", string.Join(' ', result3[2]));
        }

        [Fact]
        public void Sum_Test()
        {
            
            // arrange
            var myArray = new List<List<int>>
            {
                new(new[] {-9, -9, -9, 1, 1, 1}),
                new(new[] {0, -9, 0, 4, 3, 2}),
                new(new[] {-9, -9, -9, 1, 2, 3}),
                new(new[] {0, 0, 8, 6, 6, 0}),
                new(new[] {0, 0, 0, -2, 0, 0}),
                new(new[] {0, 0, 1, 2, 4, 0})
            };

            // act
            var target = Result.Get3x3Array(myArray, 0, 0);
            var result = Result.SumHourGlass3x3(target);
            
            target = Result.Get3x3Array(myArray, 2, 1);
            var result2 = Result.SumHourGlass3x3(target);
            
            target = Result.Get3x3Array(myArray, 1, 3);
            var result3 = Result.SumHourGlass3x3(target);

            // assert
            Assert.Equal(-63, result);
            Assert.Equal(-11, result2);
            Assert.Equal(23, result3);
        }

        [Fact]
        private void SumHourGlassTest()
        {
            // arrange
            var myArray = new List<List<int>>
            {
                new(new[] {-9, -9, -9, 1, 1, 1}),
                new(new[] {0, -9, 0, 4, 3, 2}),
                new(new[] {-9, -9, -9, 1, 2, 3}),
                new(new[] {0, 0, 8, 6, 6, 0}),
                new(new[] {0, 0, 0, -2, 0, 0}),
                new(new[] {0, 0, 1, 2, 4, 0})
            };
            
            // act
            var target = Result.HourglassSum(myArray);
            
            // assert
            Assert.Equal(28, target);
        }
    }
}