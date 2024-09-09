using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculaAumentoNaoEstatico;
using SequenciaFibonacci;

namespace Menu
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("0) Sair");
                Console.WriteLine("1) Calcular aumento.");
                Console.WriteLine("2) Fibonacci");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Finalizando o programa!");
                        break;

                    case 1:

                        CalculadoraAumento calculadora = new CalculadoraAumento();

                        Console.WriteLine("Digite o salário atual:");
                        double salarioAtual = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o percentual (%) de aumento:");
                        double percentualAumento = Convert.ToDouble(Console.ReadLine());

                        double novoSalario = calculadora.CalcularAumento(salarioAtual, percentualAumento);

                        Console.WriteLine($"O novo salário com o aumento é: {novoSalario:F2}");
                        Console.WriteLine();

                        Console.WriteLine();

                        break;

                    case 2:
                        Fibonacci.Main();
                        Console.WriteLine();

                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        Console.WriteLine();

                        break;
                } 

            } while (opcao != 0);
        }
    }
}