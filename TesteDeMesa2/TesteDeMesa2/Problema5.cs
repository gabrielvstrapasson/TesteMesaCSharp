using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Problema5 : Calculator
    {
        public static void DescobrirValorFuturo ()
        {
            double valorPresente = 3800;
            double taxaJuros = 1.25;
            CalculoTaxaJuros(taxaJuros);
            double valorFuturo = valorPresente;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("PROBLEMA 5 - RENDIMENTO PARA OBTER VALOR FUTURO [VALOR FIXO]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"{"MÊS",4:F2}|{"VALOR PRESENTE",15}|{"TAXA JUROS",15}|{"VALOR FUTURO",15}|");
            Console.WriteLine("----------------------------------------------------");
            for (int i = 0; valorFuturo <= 7390.61; i++ )
            {
                valorFuturo = ValorFuturo(valorPresente, taxaJuros, i);

                Console.WriteLine($"{i,4}|{valorPresente,15:F2}|{taxaJuros,15:F2}|{valorFuturo,15:F2}|");
                Console.WriteLine("----------------------------------------------------");
            }


        }


    }
}
