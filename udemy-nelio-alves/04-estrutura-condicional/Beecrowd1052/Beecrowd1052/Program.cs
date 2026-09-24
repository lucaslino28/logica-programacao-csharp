/* 
Leia um valor inteiro entre 1 e 12, inclusive. Correspondente a este valor, deve ser apresentado como resposta o mês do ano por extenso, 
em inglês, com a primeira letra maiúscula.

Entrada
A entrada contém um único valor inteiro.

Saída
Imprima por extenso o nome do mês correspondente ao número existente na entrada, com a primeira letra em maiúscula.
 */

using System;

namespace Beecrowd1052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mesAno = int.Parse(Console.ReadLine());

            if (mesAno == 1)
            {
                Console.WriteLine("January");
            }
            else if (mesAno == 2)
            {
                Console.WriteLine("February");
            }
            else if (mesAno == 3)
            {
                Console.WriteLine("March");
            }
            else if (mesAno == 4)
            {
                Console.WriteLine("April");
            }
            else if (mesAno == 5)
            {
                Console.WriteLine("May");
            }
            else if (mesAno == 6)
            {
                Console.WriteLine("June");
            }
            else if (mesAno == 7)
            {
                Console.WriteLine("July");
            }
            else if (mesAno == 8)
            {
                Console.WriteLine("August");
            }
            else if (mesAno == 9)
            {
                Console.WriteLine("September");
            }
            else if (mesAno == 10)
            {
                Console.WriteLine("October");
            }
            else if (mesAno == 11)
            {
                Console.WriteLine("November");
            }
            else if (mesAno == 12)
            {
                Console.WriteLine("December");
            }
            else
            {
                Console.WriteLine("Mes nao encontrado");
            }
        }
    }
}