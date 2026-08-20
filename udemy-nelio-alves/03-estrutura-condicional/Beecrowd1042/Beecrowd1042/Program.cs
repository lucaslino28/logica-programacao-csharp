/* 
Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os 
valores na sequência como foram lidos.

Entrada
A entrada contem três números inteiros.

Saída
Imprima a saída conforme foi especificado.
 */

using System;

namespace Beecrowd1042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ordemCrescente = Console.ReadLine().Split(' ');
            int primeiroValor = int.Parse(ordemCrescente[0]);
            int segundoValor = int.Parse(ordemCrescente[1]);
            int terceiroValor = int.Parse(ordemCrescente[2]);

            int menor;
            int meio;
            int maior;

            if (primeiroValor < segundoValor && primeiroValor < terceiroValor)
            {
                menor = primeiroValor;
                if (segundoValor < terceiroValor)
                {
                    meio = segundoValor;
                    maior = terceiroValor;
                }
                else
                {
                    meio = terceiroValor;
                    maior = segundoValor;
                }
            }
            else if (segundoValor < terceiroValor)
            {
                menor = segundoValor;
                if (primeiroValor < terceiroValor)
                {
                    meio = primeiroValor;
                    maior = terceiroValor;
                }
                else
                {
                    meio = terceiroValor;
                    maior = primeiroValor;
                }
            }
            else
            {
                menor = terceiroValor;
                if (primeiroValor < segundoValor)
                {
                    meio = primeiroValor;
                    maior = segundoValor;
                }
                else
                {
                    meio = segundoValor;
                    maior = primeiroValor;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);

            Console.WriteLine();

            Console.WriteLine(primeiroValor);
            Console.WriteLine(segundoValor);
            Console.WriteLine(terceiroValor);
        }
    }
}