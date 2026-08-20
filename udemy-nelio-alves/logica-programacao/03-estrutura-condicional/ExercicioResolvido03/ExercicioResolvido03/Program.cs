/* 
Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o
menor dentre os três números lidos. Em caso de empate, mostrar apenas uma vez.

Exemplos:

Entrada:             Saída:
7 3 8                MENOR = 3

Entrada:             Saída:
5 12 5               MENOR = 5

Entrada:             Saída:
9 9 9                MENOR = 9
 */

using System;

namespace ExercicioResolvido03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            String[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine("MENOR = " + x);
            }
            else if (y < z) {
                Console.WriteLine("MENOR = " + y);
            }
            else {
                Console.WriteLine("MENOR = " + z);
            }

            Console.ReadLine();
        }
    }
}