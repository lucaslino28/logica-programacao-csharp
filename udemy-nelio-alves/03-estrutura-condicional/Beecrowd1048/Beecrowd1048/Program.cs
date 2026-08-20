/* 
A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

Salário	                    Percentual de Reajuste
0 - 400.00                  15%
400.01 - 800.00             12%
800.01 - 1200.00            10%
1200.01 - 2000.00           7%
Acima de 2000.00            4%

Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

Entrada
A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída
Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste (ambos devem ser apresentados com 2 casas decimais) e o percentual de 
reajuste ganho, conforme exemplo abaixo. 
 */

using System;
using System.Globalization;

namespace Beecrowd1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double percentual;

            if (salario <= 400.00) 
            {
                percentual = 15;
            }
            else if (salario <= 800.00)
            {
                percentual = 12;
            }
            else if (salario <= 1200.00)
            {
                percentual = 10;
            }
            else if (salario <= 2000.00)
            {
                percentual = 7;
            }
            else
            {
                percentual = 4;
            }

            double reajusteGanho = salario * percentual / 100;
            double novoSalario = salario + reajusteGanho;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}