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

        [Fact]
        public void Should_Return_Fizz_Given_Input_Mutiple_Of_3()
        {
            //Given
            var expected = "Fizz";
            //When
            var actual = fizzBuzz.Say(3);
            //Then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_Return_Buzz_Given_Input_Mutiple_Of_5()
        {
            //Given
            var expected = "Buzz";
            //When
            var actual = fizzBuzz.Say(5);
            //Then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_Return_Buzz_Given_Input_Mutiple_Of_7()
        {
            //Given
            var expected = "Whizz";
            //When
            var actual = fizzBuzz.Say(7);
            //Then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_Return_FizzBuzz_Given_Input_Mutiple_Of_3_And_Mutiple_Of_5()
        {
            //Given
            var expected = "FizzBuzz";
            //When
            var actual = fizzBuzz.Say(15);
            //Then
            Assert.Equal(actual, expected);
        }

        public void Should_Return_BuzzWhizz_Given_Input_Mutiple_Of_5_And_Mutiple_Of_7()
        {
            //Given
            var expected = "BuzzWhizz";
            //When
            var actual = fizzBuzz.Say(15);
            //Then
            Assert.Equal(actual, expected);
        }

        public void Should_Return_FizzBuzzWhizz_Given_Input_Mutiple_Of_5_And_Mutiple_Of_7()
        {
            //Given
            var expected = "FizzBuzzWhizz";
            //When
            var actual = fizzBuzz.Say(15);
            //Then
            Assert.Equal(actual, expected);
        }
    }
}
