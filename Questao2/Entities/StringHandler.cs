using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao2.Entities
{
    public static class StringHandler
    { 
        public static string ChecarString(string sequencia)
        {
            if (string.IsNullOrEmpty(sequencia))
                return "NÃO :(";

            var brackets = sequencia.ToCharArray().ToList();

            if (brackets.Count % 2 != 0 || brackets is null)
                return "NÃO :(";

            var metadeInicial = brackets.GetRange(0, brackets.Count/2);
            var metadeFinal = brackets.GetRange(brackets.Count / 2, brackets.Count / 2);

            bool bracketDesbalanceado = false;
            while (bracketDesbalanceado == false)
            {
                if (metadeInicial.Count == 0 && metadeFinal.Count == 0)
                {
                    return "SIM";
                }

                if (metadeInicial.Last() == '(')
                {
                    if (metadeFinal.First() == ')')
                    {
                        metadeInicial.Remove(metadeInicial.Last());
                        metadeFinal.Remove(metadeFinal.First());

                        bracketDesbalanceado = false;
                    }

                    else
                    {
                        return "NÃO";
                    }

                    continue;
                }

                if (metadeInicial.Last() == '[')
                {
                    if (metadeFinal.First() == ']')
                    {
                        metadeInicial.Remove(metadeInicial.Last());
                        metadeFinal.Remove(metadeFinal.First());

                        bracketDesbalanceado = false;
                    }

                    else
                    {
                        return "NÃO";
                    }

                    continue;
                }

                if (metadeInicial.Last() == '{')
                {
                    if (metadeFinal.First() == '}')
                    {
                        metadeInicial.Remove(metadeInicial.Last());
                        metadeFinal.Remove(metadeFinal.First());

                        bracketDesbalanceado = false;
                    }

                    else
                    {
                        return "NÃO";
                    }

                    continue;
                }

                else
                {
                    return "NÃO";
                }
            }

            return "SIM :)";         
        }
    }
}
