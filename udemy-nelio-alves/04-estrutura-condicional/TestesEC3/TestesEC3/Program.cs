using System;

namespace TestesEC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Encadeamento de estruturas condicionais
            int horas;

            Console.WriteLine("Quantas horas? ");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else {
                if (horas < 18)
                {
                    Console.WriteLine("Boa tarde!");
                }
                else {
                    Console.WriteLine("Boa noite!");
                }
            }

            Console.ReadLine();
        }
    }
}