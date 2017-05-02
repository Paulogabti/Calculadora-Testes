using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Testes.TestaTudo())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO: Uma das operações não está funcionando corretamente!");
                Console.ResetColor();
                Console.ReadKey();

                return;
            }

            double Num1;
            double Num2;

            Console.WriteLine("Digite o primeiro número:");

            if (!double.TryParse(Console.ReadLine(), out Num1))
            {
                Console.WriteLine("Número inválido!");

                return;
            }

            Console.WriteLine("Digite o segundo número:");

            if (!double.TryParse(Console.ReadLine(), out Num2))
            {
                Console.WriteLine("Número inválido!");

                return;
            }

            Console.WriteLine("Digite a operação (+-*/):");

            string Op = Console.ReadLine();

            Console.Write("Resultado = ");

            switch (Op)
            {
                case "+": Console.WriteLine(Calculadora.Somar   (Num1, Num2)); break;
                case "-": Console.WriteLine(Calculadora.Subtrair(Num1, Num2)); break;
                case "*": Console.WriteLine(Calculadora.Mult    (Num1, Num2)); break;
                case "/": Console.WriteLine(Calculadora.Dividir (Num1, Num2)); break;

                default: Console.WriteLine("Operador inválida!"); break;
            }

            Console.ReadKey();
        }
    }
}
