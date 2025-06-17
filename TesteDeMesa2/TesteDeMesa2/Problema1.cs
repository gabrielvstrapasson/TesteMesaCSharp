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
            double valorPresente, taxaJuros;
            int periodoMes;
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Calculo de Rendimento de um Investimento");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Informe o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a taxa de juros: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine()!.Replace(',', '.'));
            Console.Write("Informe o periodo (mês): ");
            periodoMes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
            double valorFinal = ValorFuturo(valorPresente, taxaJuros, periodoMes);
            Console.WriteLine($"O Rendimento do Investimento no {periodoMes}° mês = R${valorFinal}");
            Console.WriteLine("----------------------------------------------------");
        }

        
    }
}
