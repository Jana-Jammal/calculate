using Xunit;
using LEC2.Core;

namespace LEC2.Tests
{
    public class CalculaterTests
    {
        [Fact]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
        {
            int a = 3;
            int b = 2;
            int result = Calculater.Multiply(a, b);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_NumberAndZero_ReturnsZero()
        {
            int a = 5;
            int b = 0;
            int result = Calculater.Multiply(a, b);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Multiply_NegativeAndPositive_ReturnsNegativeProduct()
        {
            int a = -4;
            int b = 3;
            int result = Calculater.Multiply(a, b);
            Assert.Equal(-12, result);
        }

        [Fact]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            int a = 10;
            int b = 2;
            int result = Calculater.Divide(a, b);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ResultIsFraction_ReturnsTruncatedInteger()
        {
            int a = 7;
            int b = 2;
            int result = Calculater.Divide(a, b);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            int a = 10;
            int b = 0;
            Assert.Throws<DivideByZeroException>(() => Calculater.Divide(a, b));
        }

        [Fact]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            int number = 8;
            bool result = Calculater.IsEven(number);
            Assert.True(result);
        }

        [Fact]
        public void IsEven_OddNumber_ReturnsFalse()
        {
            int number = 7;
            bool result = Calculater.IsEven(number);
            Assert.False(result);
        }

        [Fact]
        public void IsEven_NegativeEvenNumber_ReturnsTrue()
        {
            int number = -6;
            bool result = Calculater.IsEven(number);
            Assert.True(result);
        }
    }
}
