using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EstudoXUnit
{
    public class CalculadoraTest
    {
        private Calculadora _calculadora;

        public CalculadoraTest()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void SomaBasica()
        {
            Assert.Equal(0, _calculadora.Soma(0, 0));
        }

        [Fact]
        public void SomaValorMaximo()
        {
            Assert.Equal(int.MinValue, _calculadora.Soma(int.MaxValue, 1));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void SomaParametros(int value)
        {
            Assert.Equal(value*2, _calculadora.Soma(value, value));
        }

        [Theory]
        [InlineData(10, 521.23)]
        public void TesteParametros(int arg1, double arg2)
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(null)]
        public void TesteParametroObjeto(Calculadora calculadora)
        {
            Assert.True(true);
        }

        [Fact]
        public void TesteSomaInfinita()
        {
            Assert.Equal(-2, _calculadora.Soma(int.MaxValue, int.MaxValue));
        }

        [Theory]
        [InlineData(1, 0)]
        public void TesteDivisao(int arg1, int arg2)
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Divisao(arg1, arg2));
        }


    }
}
