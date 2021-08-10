using System;
using System.Globalization;

namespace Uri_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int km_litro = 12;
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double tot_litros = (double)(tempo * velocidade) / km_litro;

            Console.WriteLine(tot_litros.ToString("F3",CultureInfo.InvariantCulture));

        }
    }
}
