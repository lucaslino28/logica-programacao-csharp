using System;

namespace TestesEC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas;

            Console.WriteLine("Quantas horas?");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else {
                Console.WriteLine("Boa tarde!");
            }

            Console.ReadLine();
        }
    }
}