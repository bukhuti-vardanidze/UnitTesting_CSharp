
using Domain;
using FluentAssertions;
using Xunit;

namespace CalculatorTest
{
    public class CalcutaorTests
    {   

            [Fact]
            public void Sum_of_2_and_2_shout_be_4() 
            => new Calculator()
                  .Sum(2,2)
                  .Should().Be(4);





            //var calculator = new Calculator();
            //var result = calculator.Sum(2, 2);

        //result.Should().Be(4);









    }
}