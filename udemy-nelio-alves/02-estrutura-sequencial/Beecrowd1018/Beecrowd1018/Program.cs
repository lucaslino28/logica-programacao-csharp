/*
Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas 
são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

Saída
Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não esqueça de 
imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
 */

using System;

namespace Beecrowd1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int qtdNotas100 = n / 100;
            int resto = n % 100;

            int qtdNotas50 = resto / 50;
            resto = resto % 50;

            int qtdNotas20 = resto / 20;
            resto = resto % 20;

            int qtdNotas10 = resto / 10;
            resto = resto % 10;

            int qtdNotas5 = resto / 5;
            resto = resto % 5;

            int qtdNotas2 = resto / 2;
            resto = resto % 2;

            int qtdNotas1 = resto;

            Console.WriteLine(n);
            Console.WriteLine(qtdNotas100 + " nota(s) de R$ 100,00");
            Console.WriteLine(qtdNotas50 + " nota(s) de R$ 50,00");
            Console.WriteLine(qtdNotas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(qtdNotas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(qtdNotas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(qtdNotas2 + " nota(s) de R$ 2,00");
            Console.WriteLine(qtdNotas1 + " nota(s) de R$ 1,00");
        }
    }
}