using System;

namespace Questao3.Entities
{
    public static class AcoesHandler
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
            for (int i = 0; i < ArrayDeAcoes.Length; i++)
            {
                double valorAtual = ArrayDeAcoes[i];

                foreach (var valorAcaoFutura in ArrayDeAcoes)
                {
                    if (-(valorAtual) + valorAcaoFutura <= 0 && i == ArrayDeAcoes.Length - 1)
                    {
                        return "0 (Nesse caso nenhuma transação deve ser feita, lucro máximo será igual a 0)";
                    }

                    if (-(valorAtual) + valorAcaoFutura > 0)
                    {
                        double acaoVendida = RetonarMaiorValor(i);
                        int diaVenda = Array.IndexOf(ArrayDeAcoes, acaoVendida) + 1;

                        double acaoComprada = RetonarMenorValor(i, valorAtual);
                        int diaCompra = Array.IndexOf(ArrayDeAcoes, acaoComprada) + 1;

                        Console.WriteLine("");
                        Console.WriteLine("===============================================================================");
                        return $"{acaoVendida - acaoComprada} (Comprou no dia {diaCompra} (preço igual a {acaoComprada}) e vendeu no dia {diaVenda} (preço igual a {acaoVendida}))";
                    }
                }
            }

            return "SEI LÁ";
        }

        public static double RetonarMenorValor(int index, double valorAtual)
        {
            double menorValor = 0;

            for (int i = index; i < ArrayDeAcoes.Length; i++)
            {
                if (valorAtual < ArrayDeAcoes[i])
                {
                    menorValor = valorAtual;
                }
                else
                {
                    menorValor = ArrayDeAcoes[i];
                }
            }

            return menorValor;
        }

        public static double RetonarMaiorValor(int index)
        {
            double maiorValor = 0;

            for (int i = index; i < ArrayDeAcoes.Length; i++)
            {
                if (ArrayDeAcoes[i] > maiorValor)
                {
                    maiorValor = ArrayDeAcoes[i];
                }
            }

            return maiorValor;
        }
    }
}