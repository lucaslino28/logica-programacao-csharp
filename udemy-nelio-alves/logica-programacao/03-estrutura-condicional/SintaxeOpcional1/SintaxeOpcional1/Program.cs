using System;
using System.Globalization;

namespace SintaxeOpcional1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operadores de atribuição cumulativa

            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if (minutos > 100)
            {
                conta += (minutos - 100) * 2.0;
            }

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}