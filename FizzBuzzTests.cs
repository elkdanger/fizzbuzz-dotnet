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
    }
}
