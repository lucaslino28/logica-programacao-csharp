/* 
Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da 
conta a pagar.

CODIGO     ESPECIFICACAO      PREÇO
1          Cachorro Quente    R$ 4.00
2          X-Salada           R$ 4.50
3          X-Bacon            R$ 5.00
4          Torrada simples    R$ 2.00
5          Refrigerante       R$ 1.50

Entrada
O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

Saída
O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
 */

using System;
using System.Globalization;

namespace Beecrowd1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codigoItem = int.Parse(vet[0]);
            int quantidadeItem = int.Parse(vet[1]);

            double precoUnitario = 0.0;

            switch (codigoItem) {
                case 1: precoUnitario = 4.00;
                    break;
                case 2: precoUnitario = 4.50;
                    break;
                case 3: precoUnitario = 5.00;
                    break;
                case 4: precoUnitario = 2.00;
                    break;
                case 5: precoUnitario = 1.50;
                    break;
            }

            double valorTotal = precoUnitario * quantidadeItem;

            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}