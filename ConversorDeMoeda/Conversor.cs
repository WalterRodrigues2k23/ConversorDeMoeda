using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoeda
{
    internal class ConversorDeMoeda
    {
        public double cotdol, compdol;
        public static double Soma(double cotdol, double compdol)
        {
            double soma = cotdol * compdol;
            return soma + soma * 6.0 / 100.0;
        }
    }
}