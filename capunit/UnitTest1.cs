using System;
using Xunit;
using capcode;


namespace capunit
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(27,"13 14")]
        [InlineData(44,"2 3 4 5 6 7 8 9")]
        public void calculatable(double sum, string expect)
        {
            var code = new Code();
            var answer = code.calculate(sum);
            Assert.Equal(expect, answer);
        }

        [Theory]
        [InlineData(4,"only self is answer is 4")]
        [InlineData(2,"only self is answer is 2")]
        public void uncalculatable(double sum, string expect)
        {
            var code = new Code();
            var answer = code.calculate(sum);
            Assert.Equal(expect, answer);
        }

        [Theory]
        [InlineData(0, "Do not support this number")]
        [InlineData(-1, "Do not support this number")]
        [InlineData(-5, "Do not support this number")]
        [InlineData(-100, "Do not support this number")]
        public void paramIsZeroOrLower(double sum, string expect)
        {
            var code = new Code();
            var answer = code.calculate(sum);
            Assert.Equal(expect, answer);
        }
    }
}
