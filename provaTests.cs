using System;
using System.Collections.Generic;
using Xunit;

namespace Autotests
{
        public class provaTests
    {
        [Theory]
        [InlineData(8,50,9.60,84.8)]
        [InlineData(9,0,5.52,49.68)]
        [InlineData(-7,30,10,0)]
        [InlineData(7,30,0,0)]
        [InlineData(7,-30,10,75)]
        [InlineData(7,30.50,10,75.08)]
        
        public void Question1(int hours, double minutes, double perHour, double expected)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1,
            // então a aplicação deverá retornar o valor ganho por dia.
            var question = new prova();

            var result = question.Question1(hours, minutes, perHour);

            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(new string[5]{"h","u","l","k","finalizar"},"hulk")]
        [InlineData(new string[7]{"h","u","l","k","finalizar","l","k"},"hulk")]
        [InlineData(new string[7]{"h","u","l","k","l","k","finalizar"},"hulklk")]
        public void Question2(string[] letters , string expected)
        {
            var question = new prova();
            
            var result = question.Question2(letters);

            Assert.Equal(expected, result);
        }
    }
}