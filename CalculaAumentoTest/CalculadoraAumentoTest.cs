using CalculaAumentoNaoEstatico;

namespace CalculaAumentoTest
{
    [TestClass]
    public class CalculadoraAumentoTest
    {
        [TestMethod]
        public void CalculaSalarioAumentado()
        {
            //cenario
            double salarioAtual = 1412.00;
            double porcentAumento = 10;
            double novoSal = 1553.2;
            double resultado;
            var calc = new CalculadoraAumento();

            //acao
            resultado = calc.CalcularAumento(salarioAtual, porcentAumento);

            //verificacao
            Assert.AreEqual(novoSal, resultado);
        }
    }
}