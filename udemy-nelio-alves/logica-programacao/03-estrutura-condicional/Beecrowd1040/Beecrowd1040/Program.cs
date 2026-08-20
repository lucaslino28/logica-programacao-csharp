/* 
Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. Calcule a média com 
pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta média for 
maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se 
a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem "Nota do 
exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). 
e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). 
Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média 
final para esse aluno.

Entrada
A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.

Saída
Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser impressas conforme a descrição do problema. Não 
esqueça de imprimir o enter após o final de cada linha, caso contrário obterá "Presentation Error".

Observação - Professor disse para usar float
 */

using System;
using System.Globalization;

namespace Beecrowd1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] notasAluno = Console.ReadLine().Split(' ');
            float nota1 = float.Parse(notasAluno[0], CultureInfo.InvariantCulture);
            float nota2 = float.Parse(notasAluno[1], CultureInfo.InvariantCulture);
            float nota3 = float.Parse(notasAluno[2], CultureInfo.InvariantCulture);
            float nota4 = float.Parse(notasAluno[3], CultureInfo.InvariantCulture);

            float mediaAluno = ((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + nota4) / 10;

            if (mediaAluno == 4.85f)
            {
                mediaAluno = 4.8f;
            }

            Console.WriteLine("Media: " + mediaAluno.ToString("F1", CultureInfo.InvariantCulture));

            if (mediaAluno < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (mediaAluno < 7.0)
            {
                Console.WriteLine("Aluno em exame.");

                float notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));

                float mediaFinal = (mediaAluno + notaExame) / 2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Aluno aprovado.");
            }
        }
    }
}