using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{

    public class Calculator
    {
        double valorPresente, taxaJuros;
        int periodoMes;

        public static double CalculoTaxaJuros(double taxaJuros)
        {
            return taxaJuros / 100;
        }

        public static double ValorFuturo(double valorPresente, double taxaJuros,int periodoMes)
        {
            double valorFuturo = valorPresente * Math.Pow((1 + CalculoTaxaJuros(taxaJuros)),periodoMes);
            return double.Parse(valorFuturo.ToString("F2"));

        }


    }
}
