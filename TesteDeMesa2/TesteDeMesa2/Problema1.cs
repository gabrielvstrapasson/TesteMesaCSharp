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
            Console.WriteLine("PROBLEMA 1 - RENDIMENTO INVESTIMENTO");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Informe o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a taxa de juros: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());
            periodoConvertido = ConversorPeriodo();
            Console.WriteLine($"{"MÊS",4}|{"VALOR PRESENTE",15}|{"TAXA JUROS",15}|{"VALOR FUTURO",15}|");
            Console.WriteLine("----------------------------------------------------");
            double valorFuturo = ValorFuturo(valorPresente, taxaJuros, periodoConvertido);
            Console.WriteLine($"{periodoConvertido,4}|{valorPresente,15}|{taxaJuros,15}|{valorFuturo,15}|");
            Console.WriteLine("----------------------------------------------------");
        }

        
    }
}
