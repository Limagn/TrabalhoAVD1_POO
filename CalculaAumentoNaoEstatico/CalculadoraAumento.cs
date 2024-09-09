using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaAumentoNaoEstatico
{
    public class CalculadoraAumento
    {
        public static void Main(string[] args) { }

        public double CalcularAumento(double salarioAtual, double percentualAumento)
        {
            double aumento = salarioAtual * (percentualAumento / 100);
            return salarioAtual + aumento;
        }
    }
}
