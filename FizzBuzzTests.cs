using System;
using Xunit;
using FluentAssertions;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Should_print_number_if_not_3_or_5() 
        {
            var result = FizzBuzzRunner.Next(1);

            result.Should().Be("1");
        }

        [Fact]
        public void Should_print_fizz_if_number_divisible_by_3()
        {
            var result = FizzBuzzRunner.Next(3);

            result.Should().Be("12Fizz");
        }

        [Fact]
        public void Should_print_buzz_if_number_divisible_by_5()
        {
            var result = FizzBuzzRunner.Next(5);

            result.Should().Be("12Fizz4Buzz");
        }

        [Fact]
        public void Should_print_fizzbuzz_if_divisible_by_3_and_5()
        {
            var result = FizzBuzzRunner.Next(15);

            result.Should().Be("12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz");
        }
    }
}
