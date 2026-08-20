/* 
Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, 
a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

Entrada
O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

Saída
Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco 
antes e depois da igualdade. Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você 
receberá "Presentation Error".
 */

using System;
using System.Globalization;

namespace beecrowd1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double notaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int pesoA = 2;
            int pesoB = 3;
            int pesoC = 5;

            double mediaAluno = (notaA * pesoA + notaB * pesoB + notaC * pesoC) / (pesoA + pesoB + pesoC);

            Console.WriteLine("MEDIA = " + mediaAluno.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}