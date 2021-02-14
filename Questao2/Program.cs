using Questao2.Entities;
using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência de brackets para validar");
            string brackets = Console.ReadLine();

            Console.WriteLine("==================================================");

            Console.WriteLine(StringHandler.ChecarString(brackets)); 
        }
    }
}
