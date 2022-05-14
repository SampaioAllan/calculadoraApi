using Xunit;
using CalculadoraApi.Web;

namespace CalculadoraApi.Test
{
    public class CalculadoraTest
    {
        [Fact]
        public void SomarDoisMaisDoisDeveDarQuatro()
        {
            var calc = new Calculadora();
            var esperado = 4;
            var resultado = calc.Somar(2, 2);
            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void SubtrairDoisComDoisDeveDarZero()
        {
            var calc = new Calculadora();
            var esperado = 0;
            var resultado = calc.Subtrair(2, 2);
            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void DividirDezPorDoisDeveDarCinco()
        {
            var calc = new Calculadora();
            var esperado = 5;
            var resultado = calc.Dividir(10, 2);
            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void MultiplicarDezPorDoisDeveDarVinte()
        {
            var calc = new Calculadora();
            var esperado = 20;
            var resultado = calc.Multiplicar(10, 2);
            Assert.Equal(esperado, resultado);
        }
    }
}