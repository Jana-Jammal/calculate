using Xunit;
using LEC2.Core;
namespace LEC2.Tests;

public class Calculatertest
{
    [Fact]
    public void Multiply_TwoPositiveNumber_ReturnCorrectProduct()
    {
        int a = 3;
        int b = 2;
        int result = Calculater.Multiply(a, b);
        Assert.Equal(6, result);
    }
      [Fact]
        public void Divide_ShouldReturnTrueResaul()
        {
            int a = 10;
            int b = 2;
            int result = Calculater.Divide(a, b);
            Assert.Equal(5, result);
        }
      [Fact]
        public void IsEven_ShouldReturnTrue_WhenNumberIsEven()
        {
            int number = 8;
            bool result = Calculater.IsEven(number);
            Assert.True(result);
        }
          [Fact]
        public void Divide_ShouldThrowError_WhenDivideByZero()
        {
            int a = 10;
            int b = 0;
            Assert.Throws<DivideByZeroException>(() => Calculater.Divide(a, b));
        }

}
