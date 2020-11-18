using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FizzBuzz;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        private FizzBuzzClass fizzBuzz = new FizzBuzzClass();
        [Fact]
        public void Should_Return_1_Given_Input_1()
        {
            //Given
            var expected = "1";
            //When
            var actual = fizzBuzz.Say(1);
            //Then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_Return_2_Given_Input_2()
        {
            //Given
            var expected = "2";
            //When
            var actual = fizzBuzz.Say(2);
            //Then
            Assert.Equal(actual, expected);
        }
    }
}
