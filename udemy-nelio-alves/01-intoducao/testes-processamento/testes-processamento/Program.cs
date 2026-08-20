using System;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo utilizando casting
            int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = (double)a / b;
            Console.WriteLine(resultado);

            // Outro exemplo utilizando casting
            double c;
            int d;

            c = 5.0;
            d = (int)c;

            Console.WriteLine(d);

            // Pausa apenas no final
            Console.ReadLine();
        }
    }
}