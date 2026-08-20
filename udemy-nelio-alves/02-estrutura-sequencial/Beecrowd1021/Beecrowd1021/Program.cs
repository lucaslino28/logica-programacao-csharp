/*
Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas 
e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 
0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

Saída
Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal. 
 */

using System;
using System.Globalization;

namespace Beecrowd1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Convertendo valor para centavos
            int valorCentavos = (int)(valor * 100.0 + 0.5);

            // Calculando quantidade de notas
            int qtdNotas100 = valorCentavos / 10000;
            int resto = valorCentavos % 10000;

            int qtdNotas50 = resto / 5000;
            resto = resto % 5000;

            int qtdNotas20 = resto / 2000;
            resto = resto % 2000;

            int qtdNotas10 = resto / 1000;
            resto = resto % 1000;

            int qtdNotas5 = resto / 500;
            resto = resto % 500;

            int qtdNotas2 = resto / 200;
            resto = resto % 200;

            // Calculando quantidade de moedas
            int qtdMoedas1 = resto / 100;
            resto = resto % 100;

            int qtdMoedas050 = resto / 50;
            resto = resto % 50;

            int qtdMoedas025 = resto / 25;
            resto = resto % 25;

            int qtdMoedas010 = resto / 10;
            resto = resto % 10;

            int qtdMoedas005 = resto / 5;
            resto = resto % 5;

            int qtdMoedas001 = resto;

            // Saída de dados
            Console.WriteLine("NOTAS:");
            Console.WriteLine(qtdNotas100 + " nota(s) de R$ 100.00");
            Console.WriteLine(qtdNotas50 + " nota(s) de R$ 50.00");
            Console.WriteLine(qtdNotas20 + " nota(s) de R$ 20.00");
            Console.WriteLine(qtdNotas10 + " nota(s) de R$ 10.00");
            Console.WriteLine(qtdNotas5 + " nota(s) de R$ 5.00");
            Console.WriteLine(qtdNotas2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(qtdMoedas1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(qtdMoedas050 + " moeda(s) de R$ 0.50");
            Console.WriteLine(qtdMoedas025 + " moeda(s) de R$ 0.25");
            Console.WriteLine(qtdMoedas010 + " moeda(s) de R$ 0.10");
            Console.WriteLine(qtdMoedas005 + " moeda(s) de R$ 0.05");
            Console.WriteLine(qtdMoedas001 + " moeda(s) de R$ 0.01");

        }
    }
}