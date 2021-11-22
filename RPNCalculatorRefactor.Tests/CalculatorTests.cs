using RPNCalculatorRefactor;
using System.Collections.Generic;
using Xunit;

namespace RPNCalculatorTDD.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _sut;

        public CalculatorTests()
        {
            _sut = new Calculator();
        }


        [Theory]
        [InlineData(0, "[0]")]
        [InlineData(1337, "[1337]")]
        [InlineData(999999999, "[999999999]")]
        [InlineData(3.141592653, "[3.141592653]")]
        public void InputNumber(decimal input, string result)
        {
            _sut.InputValue(input);
            Assert.Equal(_sut.ToString(), result);
        }


        [Theory]
        [InlineData(1, 2, 3, "[1, 2, 3]")]
        [InlineData(1.11, 2.22, 3.33, "[1.11, 2.22, 3.33]")]
        [InlineData(0, 999999999, 3.141592653, "[0, 999999999, 3.141592653]")]
        public void InputNumbers(decimal inputA, decimal inputB, decimal inputC, string result)
        {
            _sut.InputValue(inputA);
            _sut.InputValue(inputB);
            _sut.InputValue(inputC);
            Assert.Equal(_sut.ToString(), result);
        }

        [Fact]
        public void OnlyOneValueAddition()
        {
            _sut.InputValue(100);
            _sut.Addition();
            Assert.Equal("[100]", _sut.ToString());
        }

        [Theory]
        [InlineData(0, 0, "[0]")]
        [InlineData(0, 1, "[1]")]
        [InlineData(1, 0, "[1]")]
        [InlineData(-100, 100, "[0]")]
        [InlineData(100, -100, "[0]")]
        [InlineData(-50, -50, "[-100]")]
        [InlineData(0.999999999, 0.000000001, "[1]")]
        [InlineData(999999999, 1, "[1000000000]")]
        public void Addition(decimal inputA, decimal inputB, string result)
        {
            _sut.InputValue(inputA);
            _sut.InputValue(inputB);
            _sut.Addition();
            Assert.Equal(result, _sut.ToString());
        }

        [Theory]
        [InlineData(0, 0, "[0]")]
        [InlineData(0, 1, "[-1]")]
        [InlineData(1, 0, "[1]")]
        [InlineData(1, 0.999999999, "[0.000000001]")]
        [InlineData(999999999, 1, "[1000000000]")]

        public void Subtraction(decimal inputA, decimal inputB, string result)
        {
            _sut.InputValue(inputA);
            _sut.InputValue(inputB);
            _sut.Subtraction();
            Assert.Equal(result, _sut.ToString());
        }
    }
}