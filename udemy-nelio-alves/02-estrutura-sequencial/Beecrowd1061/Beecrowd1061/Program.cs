/*
Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. 
O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.

Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.

Entrada
Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. Na linha 
seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. Na terceira e quarta linha de entrada haverá outra 
informação no mesmo formato das duas primeiras linhas, indicando o término do evento.

Saída
Na saída, deve ser apresentada a duração do evento, no seguinte formato:

W dia(s)
X hora(s)
Y minuto(s)
Z segundo(s)

Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.
 */

using System;
using System.Globalization;

namespace Beecrowd1061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            string[] eventoInicio = Console.ReadLine().Split(' ');
            string descricao1 = eventoInicio[0];
            int diaInicio = int.Parse(eventoInicio[1]);

            string[] horarioEventoInicio = Console.ReadLine().Split(' ');
            int horasInicio = int.Parse(horarioEventoInicio[0]);
            int minutosInicio = int.Parse(horarioEventoInicio[2]);
            int segundosInicio = int.Parse(horarioEventoInicio[4]);

            string[] eventoFim = Console.ReadLine().Split(' ');
            string descricao2 = eventoFim[0];
            int diaFim = int.Parse(eventoFim[1]);

            string[] horarioEventoFim = Console.ReadLine().Split(' ');
            int horasFim = int.Parse(horarioEventoFim[0]);
            int minutosFim = int.Parse(horarioEventoFim[2]);
            int segundosFim = int.Parse(horarioEventoFim[4]);

            // Cálculo da duração do evento
            int inicioEmSegundos = (diaInicio * 86400) + (horasInicio * 3600) + (minutosInicio * 60) + segundosInicio;
            int fimEmSegundos = (diaFim * 86400) + (horasFim * 3600) + (minutosFim * 60) + segundosFim;

            int totalSegundos = fimEmSegundos - inicioEmSegundos;

            int duracaoDias = totalSegundos / 86400;
            int resto = totalSegundos % 86400;

            int duracaoHoras = resto / 3600;
            resto = resto % 3600;

            int duracaoMinutos = resto / 60;
            int duracaoSegundos = resto % 60;

            // Saída de dados
            Console.WriteLine(duracaoDias + " dia(s)");
            Console.WriteLine(duracaoHoras + " hora(s)");
            Console.WriteLine(duracaoMinutos + " minuto(s)");
            Console.WriteLine(duracaoSegundos + " segundo(s)");
        }
    }
}
