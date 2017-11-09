using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacao = string.Empty;

            while (!operacao.Equals("C"))
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("Selecione a Operação: ");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplição");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("C. Fechar");

                operacao = Console.ReadLine();
                if (operacao == "C")
                {
                    break;
                }


                Console.WriteLine("Digite o primeiro número: ");
                Decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                Decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                Decimal resultado = 0.00m;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    Console.WriteLine(resultado);
                }
                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    Console.WriteLine(resultado);
                }
                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    Console.WriteLine(resultado);
                }
                else if (operacao == "4")
                {
                    resultado = primeiroNumero / segundoNumero;
                    Console.WriteLine(resultado);
                }
                else
                {
                    Console.WriteLine("Operação Inválida");
                }
            }
        }
    }
}
