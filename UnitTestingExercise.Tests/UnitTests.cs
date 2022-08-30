using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]//Add test data <-------
        [InlineData(1, 5, 5, 11)]
        [InlineData(4, 7, 4, 15)]
        [InlineData(8, 3, 6, 17)]

        
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var instance = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = instance.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 1, 4)]//Add test data <-------
        [InlineData(2, 3, -1)]
        [InlineData(1, 5, -4)]
        [InlineData(7, 4, 3)]
        [InlineData(8, 3, 5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var instance = new Calculator();

            //Act
            var actual = instance.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 1, 5)]//Add test data <-------
        [InlineData(2, 3, 6)]
        [InlineData(6, 5, 30)]
        [InlineData(7, 4, 28)]
        [InlineData(8, 3, 24)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var instance = new Calculator();

            //Act
            var actual = instance.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(5, 1, 5)]//Add test data <-------
        [InlineData(6, 3, 2)]
        [InlineData(30, 5, 6)]
        [InlineData(28, 4, 7)]
        [InlineData(24, 3, 8)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var instance = new Calculator();

            //Act
            var actual = instance.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
