﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace C9
{
    public class FooBarQix2Test_Say
    {
        private FooBarQix _fooBarQix;

        public FooBarQix2Test_Say()
        {
            this._fooBarQix = new FooBarQix();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void NumberNotDivisible_ReturnNumber(int number)
        {
            // Arrange
            var expected = number.ToString();

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            expected.ShouldBe(actual);
        }

        [Theory]
        [InlineData(6)]
        public void NumberDivisibleBy3_ReturnFoo(int number)
        {
            // Arrange
            var expected = "Foo";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            expected.ShouldBe(actual);
        }

        [Theory]
        [InlineData(10)]
        public void NumberDivisibleBy5_ReturnBar(int number)
        {
            // Arrange
            var expected = "Bar";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            expected.ShouldBe(actual);
        }

        [Theory]
        [InlineData(14)]
        public void NumberDivisibleBy7_ReturnQix(int number)
        {
            // Arrange
            var expected = "Qix";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            expected.ShouldBe(actual);
        }

        [Theory]
        [InlineData(3)]
        public void NumberContain3_ReplaceFoo(int number)
        {
            // Arrange
            var expected = "FooFoo";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            expected.ShouldBe(actual);
        }

        [Theory]
        [InlineData(5)]
        public void NumberContain5_ReplaceBar(int number)
        {
            // Arrange
            var expected = "BarBar";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            expected.ShouldBe(actual);
        }

        [Theory]
        [InlineData(7)]
        public void NumberContain7_ReplaceQix(int number)
        {
            // Arrange
            var expected = "QixQix";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            expected.ShouldBe(actual);
        }

        [Theory]
        [InlineData(15, "FooBarBar")]
        [InlineData(33, "FooFooFoo")]
        [InlineData(21, "FooQix")]
        [InlineData(51, "FooBar")]
        [InlineData(53, "BarFoo")]
        public void MultipleCase_ReturnExpected(int number, string expected)
        {
            // Arrange
            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            expected.ShouldBe(actual);
        }
    }
}