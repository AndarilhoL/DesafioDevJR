using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestaoTeste.Entities
{
    public static class BarreirasHandler
    {
        public static List<int> Barras = new List<int> { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        //public static List<int> Barras = new List<int> { 2, 0, 0, 2 };

        public static int CalcularRentencaoAgua()
        {
            int primeiraBarreira = Barras.IndexOf(Barras.FirstOrDefault(x => x != 0));
            int maiorValorUnico = Barras.Where(x => x == Barras.Max()).Count();
            int valorAtual = Barras[primeiraBarreira];
            int retencaoAgua = 0;

            //for (int i = primeiraBarreira; i < Barras.Count; i++)
            //{
            while (primeiraBarreira < Barras.Count)
            {
                int i = primeiraBarreira;

                int indiceProximaBarreira = BuscarProximaBarreira(i);
                int valorProximaBarreira = Barras.ElementAt(indiceProximaBarreira);

                if (indiceProximaBarreira != 0)
                {
                    valorAtual = Barras[primeiraBarreira];
                    for (int j = primeiraBarreira + 1; j < indiceProximaBarreira; j++)
                    {
                        while (Barras[j] < Math.Min(valorAtual, valorProximaBarreira))
                        {
                            Barras[j] = Barras[j] + 1;
                            retencaoAgua++;
                        }
                    }

                    if (Barras[indiceProximaBarreira] == Barras.Max() && maiorValorUnico == 1)
                    {
                        primeiraBarreira = BuscarProximaBarreira(indiceProximaBarreira, valorAtual);

                    }
                    else
                    {
                        primeiraBarreira = indiceProximaBarreira;
                        i = primeiraBarreira;
                    }
                }
                else
                {
                    primeiraBarreira++;
                }
            }

            //}

            return retencaoAgua;
        }

        public static int BuscarProximaBarreira(int indexAtual)
        {
            int contadorIndex = indexAtual;

            for (int i = contadorIndex; i < Barras.Count; i++)
            {
                if (Barras[i] >= Barras[contadorIndex] && contadorIndex < i)
                {
                    return i;
                }
            }

            return 0;
        }

        public static int BuscarProximaBarreira(int indexAtual, int maiorValor)
        {
            int contadorIndex = indexAtual + 1;
            int maiorValorAposBarreira = 0;

            for (int i = contadorIndex; i < Barras.Count; i++)
            {
                if (Barras[i] > maiorValorAposBarreira)
                {
                    maiorValorAposBarreira = Barras[i];
                    contadorIndex = i;
                }
            }

            return contadorIndex;
        }
    }
}
