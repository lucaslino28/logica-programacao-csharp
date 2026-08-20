using System;

namespace SintaxeOpcional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estrutura switch-case

            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x) {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sábado";
                    break;
                default:
                    dia = "valor inváldo";
                    break;
            }

            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();
        }
    }
}