using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace HackerRank.DataStructures.ArrayManipulation.Tests
{
    public class ArrayManipulationTests
    {
        [Fact]
        public void Largest_Test()
        {
            // arrange
            var queries = new List<List<int>>
            {
                new(new[] {1, 2, 100}),
                new(new[] {2, 5, 100}),
                new(new[] {3, 4, 100}),
            };
            // act
            var result = Result.ArrayManipulation(5, queries);

            // assert
            Assert.Equal(200, result);
        }
        
        [Fact]
        public void Largest_Test_2()
        {
            // arrange
            var queries = new List<List<int>>
            {
                new(new[] {2, 6, 8}),
                new(new[] {3, 5, 7}),
                new(new[] {1, 8, 1}),
                new(new[] {5, 9, 15}),
            };
            // act
            var result = Result.ArrayManipulation(10, queries);

            // assert
            Assert.Equal(31, result);
        }
        
        [Fact]
        public void Largest_Test_3()
        {
            // arrange
            var queries = new List<List<int>>
            {
                new(new[] {1, 5, 3}),
                new(new[] {4, 8, 7}),
                new(new[] {6, 9, 1}),
            };
            // act
            var result = Result.ArrayManipulation(10, queries);

            // assert
            Assert.Equal(10, result);
        }
        
        [Fact]
        public void Largest_Test_4()
        {
            // arrange

            var dataLines = File.ReadLines("dataFile1.csv")
                .Skip(1)
                .ToList();
            var queries = dataLines.Select(line => line.Split(',')).Select(arr =>
                    new List<int>(new[] {Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[2])}))
                .ToList();

            // act
            var result = Result.ArrayManipulation(4000, queries);

            // assert
            Assert.Equal(7515267971, result);
        }
        
        [Fact]
        public void Largest_Test_5()
        {
            // arrange

            var dataLines = File.ReadLines("dataFile2.csv")
                .Skip(1)
                .ToList();
            var queries = dataLines.Select(line => line.Split(',')).Select(arr =>
                    new List<int>(new[] {Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[2])}))
                .ToList();

            // act
            var result = Result.ArrayManipulation(10000000, queries);

            // assert
            Assert.Equal(2490686975, result);
        }
    }
}