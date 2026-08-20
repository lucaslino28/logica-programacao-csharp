/* 
Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em 
outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

Entrada
A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

Saída
Apresente a duração do jogo conforme exemplo abaixo.
 */

using System;

namespace Beecrowd1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] jogo = Console.ReadLine().Split(' ');
            int horasInicio = int.Parse(jogo[0]);
            int horasFim = int.Parse(jogo[1]);

            int duracaoJogo;

            if (horasFim > horasInicio) {
                duracaoJogo = horasFim - horasInicio;
            }
            else if (horasFim < horasInicio) {
                duracaoJogo = (24 - horasInicio) + horasFim;
            }
            else {
                duracaoJogo = 24;
            }

            Console.WriteLine("O JOGO DUROU " + duracaoJogo + " HORA(S)");
        }
    }
}