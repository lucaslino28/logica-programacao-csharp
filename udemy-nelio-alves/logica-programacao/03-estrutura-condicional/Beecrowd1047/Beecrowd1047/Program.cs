/* 
Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.

Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

Entrada
Quatro números inteiros representando a hora de início e fim do jogo.

Saída
Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” .
 */

using System;

namespace Beecrowd1047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tempoJogo = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(tempoJogo[0]);
            int minutoInicial = int.Parse(tempoJogo[1]);
            int horaFinal = int.Parse(tempoJogo[2]);
            int minutoFinal = int.Parse(tempoJogo[3]);

            int inicioEmMinutos = (horaInicial * 60) + minutoInicial;
            int finalEmMinutos = (horaFinal * 60) + minutoFinal;

            int duracaoEmMinutos = finalEmMinutos - inicioEmMinutos;

            if (duracaoEmMinutos <= 0)
            {
                duracaoEmMinutos += 1440;
            }

            int duracaoHoras, duracaoMinutos;

            duracaoHoras = duracaoEmMinutos / 60;
            duracaoMinutos = duracaoEmMinutos % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}