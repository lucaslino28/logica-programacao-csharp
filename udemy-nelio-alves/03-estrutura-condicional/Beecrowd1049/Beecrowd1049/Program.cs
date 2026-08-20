/* 
Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  
Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.
 
                  |- carnivoro -- aguia
            |- ave
            |     |-onivero -- pomba
 verterbrado
            |          |- onivero -- homem
            |- mamifero
                       |- herbivoro -- vaca


                      |- hematofago -- pulga
             |- inseto
             |        |- herbivoro -- lagarta
 invertebrado
             |          |- hematofago -- sanguessuga
             |- anelideo
                        |- onivoro -- minhoca

Entrada
A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

Saída
Imprima o nome do animal correspondente à entrada fornecida.
 */

using System;

namespace Beecrowd1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string primeiraPalavra = Console.ReadLine();
            string segundaPalavra = Console.ReadLine();
            string terceiraPalavra = Console.ReadLine();

            if (primeiraPalavra == "vertebrado")
            {
                if (segundaPalavra == "ave")
                {
                    if (terceiraPalavra == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (terceiraPalavra == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (segundaPalavra == "mamifero")
                {
                    if (terceiraPalavra == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (terceiraPalavra == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (segundaPalavra == "inseto")
                {
                    if (terceiraPalavra == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (terceiraPalavra == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (segundaPalavra == "anelideo")
                {
                    if (terceiraPalavra == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (terceiraPalavra == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}