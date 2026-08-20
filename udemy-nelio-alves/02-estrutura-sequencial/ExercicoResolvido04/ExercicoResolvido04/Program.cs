/*
Beecrowd | 1019 - Conversão de Tempo

Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato 
horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

 */

using System;

namespace ExercicioResolvido04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, horas, resto, minutos, segundos;

            n = int.Parse(Console.ReadLine());

            horas = n / 3600;
            resto = n % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}