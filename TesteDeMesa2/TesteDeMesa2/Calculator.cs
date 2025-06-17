using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{

    public class Calculator
    {

        public static double CalculoTaxaJuros(double taxaJuros)
        {
            return taxaJuros / 100;
        }

        public static double ValorFuturo(double valorPresente, double taxaJuros, double periodo)
        {
            double valorFuturo = valorPresente * Math.Pow((1 + CalculoTaxaJuros(taxaJuros)), periodo);
            return double.Parse(valorFuturo.ToString("F2"));

        }

        public static double ConversorPeriodo()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Deseja fazer o calculo em [1] Mês || [2] Ano? ");
            int opcao = int.Parse(Console.ReadLine()!);
            double periodo = 0;
            if (opcao == 1)
            {

                Console.Write("Selecionado calculo por mês, informe o periodo em meses: ");
                periodo = int.Parse(Console.ReadLine()!);
                Console.WriteLine("----------------------------------------------------");
                return periodo;
            }
            else if (opcao == 2)
            {

                Console.Write("Selecionado calculo por ano, informe o periodo em ano: ");
                periodo = double.Parse(Console.ReadLine()!);
                Console.WriteLine("----------------------------------------------------");

                periodo *= 12;
                return periodo;
            }
            return periodo;
        }


    }
}
