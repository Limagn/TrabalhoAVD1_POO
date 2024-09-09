using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaFibonacci
{
    public class Fibonacci
    {
        public static void Main()
        {
            Console.WriteLine("Digite o número máximo para a sequência de Fibonacci:");
            int numeroMaximo = Convert.ToInt32(Console.ReadLine());

            string resultado = Fibo(numeroMaximo);
            Console.WriteLine($"A sequência Fibonacci anterior ao número {numeroMaximo} é: \n {resultado}");
        }
        public static string Fibo(int numeroMaximo)
        {
            int a = 0, b = 1;
            StringBuilder sequencia = new StringBuilder();

            if (numeroMaximo >= 0)
            {
                sequencia.Append(a);
            }

            while (b <= numeroMaximo)
            {
                sequencia.Append($" {b}");

                int proximo = a + b;
                a = b;
                b = proximo;
            }

            return sequencia.ToString();
        }
    }

}
