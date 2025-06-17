using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Problema1 : Calculator
    {
        public static void  RendimentoInvestimento()
        {
            double valorPresente, taxaJuros, periodoConvertido;
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Calculo de Rendimento de um Investimento Final");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Informe o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a taxa de juros: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());
            periodoConvertido = ConversorPeriodo();

            Console.WriteLine("MÊS\t VALOR");
            Console.WriteLine("----------------------------------------------------");
            double valorFinal = ValorFuturo(valorPresente, taxaJuros, periodoConvertido);
            Console.WriteLine($"{periodoConvertido}°\t R${valorFinal}");
            Console.WriteLine("----------------------------------------------------");
        }

        
    }
}
