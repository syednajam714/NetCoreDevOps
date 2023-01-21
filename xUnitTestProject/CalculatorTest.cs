using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTestProject
{
    public class CalculatorTest
    {
        [Fact]
        public void Calculator_Multiply_ReturnMultiplication()
        {
            //Arrange 
            Calculator calculator = new Calculator();
            //Act 
            var result = calculator.Multiply(4, 2);
            //Assert
            Assert.Equal(8, result);
        }
        [Theory]
        [InlineData(3,2,6)]
        [InlineData(10, 5, 50)]
        [InlineData(7, 4, 28)]
        [InlineData(75, 4, 300)]
        public void Calculator_Multiply_ReturnMultiplicationList(int value1, int value2, int total)
        {
            //Arrange 
            Calculator calculator = new Calculator();
            //Act 
            var result = calculator.Multiply(value1, value2);
            //Assert
            Assert.Equal(total, result);
        }
        [Fact(Timeout =1000)]
        public async Task Calculator_Multiply_ReturnMultiplicationTimeOut()
        {
            
            //Arrange 
            Calculator calculator = new Calculator();
            //Act 
            var result = calculator.Multiply(4, 2);
            await Task.Delay(1100);
            //Assert
            Assert.Equal(8, result);
        }

    }
}
