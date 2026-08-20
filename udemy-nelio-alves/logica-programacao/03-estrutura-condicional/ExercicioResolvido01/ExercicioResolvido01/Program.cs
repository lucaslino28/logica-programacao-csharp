/* 
Fazer um programa para ler as duas notas que um aluno obteve no primeiro e
segundo semestres de uma disciplina anual. Em seguida, mostrar a nota final que o
aluno obteve no ano juntamente com um texto explicativo. Caso a nota final do aluno 
seja inferior a 60.00, mostrar a mensagem "REPROVADO", conforme exemplos. Todos
os valores devem ter uma casa decimal.
 */

using System;
using System.Globalization;

namespace ExercicioResolvido01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, soma;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));

            if (soma < 60.00) {
                Console.WriteLine("REPROVADO");
            }

            Console.ReadLine();
        }
    }
}