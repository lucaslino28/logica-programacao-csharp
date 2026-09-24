/* 
Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que 
permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

Entrada
O arquivo de entrada contém um valor inteiro.

Saída
Imprima a saída conforme exemplo fornecido. 
 */

using System;

namespace Beecrowd1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());

            int qtdAnos = idade / 365;
            int resto = idade % 365;

            int qtdMeses = resto / 30;
            resto = resto % 30;

            int qtdDias = resto;

            Console.WriteLine(qtdAnos + " ano(s)");
            Console.WriteLine(qtdMeses + " mes(es)");
            Console.WriteLine(qtdDias + " dia(s)");
        }
    }
}