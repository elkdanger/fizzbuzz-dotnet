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

            result.Should().Be(1);
        }

        [Fact]
        public void Should_print_fizz_if_number_divisible_by_3()
        {
            var result = FizzBuzzRunner.Next(3);

            result.Should().Be("Fizz");
        }
    }
}
