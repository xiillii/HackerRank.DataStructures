using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRank.DataStructures.Arrays.LeftRotation.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void LeftRotationTest()
        {
            // arrange
            var target = new List<int>(new[] {1, 2, 3, 4, 5});
            
            // act
            var result = Result.RotateLeft(4, target);

            // assert
            Assert.Equal("5 1 2 3 4", String.Join(' ', result));
        }

        [Fact]
        public void LimitTime_Test()
        {
            // arrange
            var limitSeconds = 3;
            var target = new List<int>();
            var maxSize = 500000;
            var watch = new System.Diagnostics.Stopwatch();
            var greaterLimit = false;
            
            // act
            for (int i = 0; i < maxSize; i++)
            {
                target.Add(i);
            }
            watch.Start();

            var result = Result.RotateLeft(maxSize - 1, target);

            watch.Stop();
            
            // assert

            if (limitSeconds < watch.ElapsedMilliseconds / 1000.0)
            {
                greaterLimit = true;
            }

            Assert.False(greaterLimit);

        }
    }
}