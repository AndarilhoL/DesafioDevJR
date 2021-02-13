using Questao1.Entities;
using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            Console.WriteLine("QUESTÃO 1");
            Console.WriteLine("");
            Console.WriteLine("Digite '1' para usar o Array Padrão (Valores setados)");
            Console.WriteLine("Digite '2' para usar o Array Dinâmico (Valores dinâmicos)");

            Console.Write("Digite a opção desejada: ");
            resposta = Console.ReadLine();

            while (resposta != "1" && resposta != "2")
            {
                Console.WriteLine("Valor inválido");
                Console.WriteLine("Digite a opção entre 1 e 2");
                resposta = Console.ReadLine();
            }

            Console.WriteLine("============================================================");
            Console.WriteLine("");

            if (resposta == "1")
            {
                var arrayNumeros = ArrayHandler.RetornarArrayPadrao();
                Array.ForEach(arrayNumeros, numeros => Console.Write($"{numeros} "));
            }
            else
            {
                Console.Write("Digite o tamanho desejado para o Array (quantos números poderão ter dentro do array):");
                int tamanho = int.Parse(Console.ReadLine());
                var arrayNumeros = ArrayHandler.RetornarArrayDinamico(tamanho);

                Array.ForEach(arrayNumeros, numeros => Console.Write($"{numeros} "));
            }

            Console.WriteLine("");
            Console.Write("Digite um valor ALVO, esse valor deve ser a soma de dois valores que estão no Array:");
            int alvo = int.Parse(Console.ReadLine());
            var indicesRetornados = ArrayHandler.RetornarIndices(alvo);

            Console.WriteLine("");
            Console.WriteLine("============================================================");
            if (indicesRetornados[0] == 0 && indicesRetornados[1] == 0)
            {
                Console.WriteLine("O valor ALVO não é a soma de nenhum dos valores no Array :(");
            }
            else
            {
                Console.WriteLine("Esses são os índices da soma desejada :");
                Array.ForEach(indicesRetornados, indices => Console.Write($"{indices} "));
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("============================================================");
            }           
        }
    }
}
