using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class Conversor
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é a cotação do dólar? ");
            double cotdol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double compdol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.Soma(cotdol, compdol);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
