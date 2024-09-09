using SequenciaFibonacci;

namespace FiboTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void SequenciaFibonacciTest()
        {
            //cenario
            int numMax = 58;
            string resultEsperado = "0 1 1 2 3 5 8 13 21 34 55";
            string resultado;

            //acao
            resultado = Fibonacci.Fibo(numMax);


            //verificacao
            Assert.AreEqual(resultado, resultEsperado);
        }
    }
}