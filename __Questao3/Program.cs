using Questao3.Entities;
using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma quantidade de dias");
            int dias = int.Parse(Console.ReadLine());

            ArrayHandler.CriarArrayDeAcoes(dias);

            for (int i = 0; i < dias; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Digite um valor de ação para o dia {i+1}");
                double valorAcao = double.Parse(Console.ReadLine());

                ArrayHandler.ArmazenarValores(valorAcao, i);
            }

            Console.WriteLine(ArrayHandler.CalcularMaiorLucro());
        }
    }
}
