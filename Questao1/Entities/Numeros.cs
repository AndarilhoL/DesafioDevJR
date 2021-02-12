using System;

namespace Questao1.Entities
{
    public static class Numeros
    {
        public static int[] ArrayNumeros { get; set; }

        public static int[] RetornarArrayPadrao()
        {
            int[] numerosArray = { 2, 7, 11, 15 };
            ArrayNumeros = numerosArray;

            return numerosArray;
        }   
        
        public static int[] RetornarArrayDinamico(int tamanho)
        {
            Random numeroRandom = new Random();
            int[] numerosArray = new int[4];

            for (int i = 0; i < tamanho; i++)
            {
                numerosArray.SetValue(numeroRandom.Next(1, 100), i);
            }

            ArrayNumeros = numerosArray;

            return numerosArray;
        }

        public static int[] RetornarIndices(int alvo)
        {
            int[] arrayDeIncices = new int[2];

            for (int i = 0; i <= ArrayNumeros.Length-1; i++)
            {
                int valorInicial = (int)ArrayNumeros.GetValue(i);

                for (int index = i; index <= ArrayNumeros.Length-1; index++)
                {
                    int valor = (int)ArrayNumeros.GetValue(index);

                    if ((valorInicial+valor) == alvo)
                    {
                        arrayDeIncices.SetValue(i,0);
                        arrayDeIncices.SetValue(index,1);

                        return arrayDeIncices;
                    }           
                }
            }

            return arrayDeIncices;
        }
    }
}
