using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ValueServiceTest
{
    public class ValueServiceTestingClass
    {
        ValueService valueService = new ValueService();

        [Fact]
        public void CountPostFactorsList()
        {
            Assert.Equal(10, valueService.PostFactors.Count);
        }

        [Theory]
        [InlineData(-12, "p")]
        [InlineData(-9, "n")]
        [InlineData(-6, "µ")]
        [InlineData(-3, "m")]
        [InlineData(3, "k")]
        [InlineData(6, "M")]
        [InlineData(9, "G")]
        [InlineData(12, "T")]
        [InlineData(15, "P")]
        [InlineData(18, "E")]
        [InlineData(null, "x")]
        [InlineData(0, "")]
        public void PotenzFromPostFactor(int? power, string postfactor)
        {
            Assert.Equal(power, valueService.GetPotenz(postfactor));
        }

        [Theory]
        [InlineData(0.000000000001, "1p")]
        [InlineData(0.000000001, "1n")]
        [InlineData(0.000001, "1µ")]
        [InlineData(0.001, "1m")]
        [InlineData(100, "100")]
        [InlineData(100000, "100k")]
        [InlineData(1000000, "1M")]
        [InlineData(1000000000, "1G")]
        [InlineData(1000000000000, "1T")]
        [InlineData(1000000000000000, "1P")]
        [InlineData(4700, "4k7")]
        [InlineData(0.5, "500000µ")]
        [InlineData(0.0025, "2.5m")]
        [InlineData(500,"k5")]
        public void GetDecimalFromString(decimal result, string value)
        {
            Assert.Equal(result, valueService.GetDecimal(value));
        }

        [Fact]
        public void GetDecimalException()
        {
            Assert.Throws<FormatException>(() => valueService.GetDecimal("2kx"));
        }

        [Theory]
        [InlineData(0.000001, "µ")]
        [InlineData(1000, "k")]
        [InlineData(1000000, "M")]
        [InlineData(1000000000, "G")]
        public void GetPostFactor(decimal input, string expected) 
        { 
            Assert.Equal(expected, valueService.GetPostFactor(input));
        }


        [Theory]
        [InlineData(123456, 2,"", "123,46k")]
        [InlineData(154.56, 0,"", "155")]
        [InlineData(0.001, 0,"µ", "1000µ")]
        [InlineData(1000.24, 2, "k", "1,00k")]
        public void GetDisplayValue(decimal value, int precision, string postFactor, string expected)
        {
            Assert.Equal(expected, valueService.GetDisplayValue(value, precision, postFactor));
        }
    }
}
