using System;
using Xunit;
using FluentAssertions;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(11)]
        [InlineData(19)]
        [InlineData(26)]
        [InlineData(58)]
        [InlineData(94)]
        public void Should_print_number_if_not_3_or_5(int value) 
        {
            var result = FizzBuzzRunner.Next(value);

            result.Should().Be(value);
        }

        [Fact]
        public void Should_print_fizz_if_number_divisible_by_3()
        {
            var result = FizzBuzzRunner.Next(3);

            result.Should().Be("Fizz");
        }

        [Fact]
        public void Should_print_buzz_if_number_divisible_by_5()
        {
            var result = FizzBuzzRunner.Next(5);

            result.Should().Be("Buzz");
        }

        [Fact]
        public void Should_print_fizzbuzz_if_divisible_by_3_and_5()
        {
            var result = FizzBuzzRunner.Next(15);

            result.Should().Be("FizzBuzz");
        }
    }
}
