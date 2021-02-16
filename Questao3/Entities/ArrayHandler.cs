using System;

namespace Questao3.Entities
{
    public static class ArrayHandler
    {
        public static double[] ArrayDeAcoes { get; set; }

        public static void CriarArrayDeAcoes(int dias)
        {
            ArrayDeAcoes = new double[dias];
        }

        public static void ArmazenarValores(double valorAcao, int index)
        {
            ArrayDeAcoes.SetValue(valorAcao, index);
        }

        public static string CalcularMaiorLucro()
        {
            double menorValor = 0;
            double maiorValor = 0;

            for (int i = 0; i < ArrayDeAcoes.Length; i++)
            {
                double valorAtual = ArrayDeAcoes[i];

                foreach (var valorAcaoFutura in ArrayDeAcoes)
                {
                    if (-(valorAtual) + valorAcaoFutura <= 0 && i == ArrayDeAcoes.Length-1)
                    {
                        return "0, COMPRA NADA NÃO MEU REI, SEU LUCRO MÁXIMO SERÁ 0 (ou pior)";
                    }

                    if (-(valorAtual) + valorAcaoFutura > 0)
                    {
                        return "TEM LUCRO, SÓ NÃO SEI AINDA";
                    }
                }
            }

            return "SEI LÁ";
        }
    }
}