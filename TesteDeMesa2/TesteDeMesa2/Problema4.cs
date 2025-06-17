using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Problema4 : Calculator
    {

        public static void RendimentoComResgate()
        {
            double valorPresente, taxaJuros, periodoConvertido;
            int periodoResgate = 5;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Rendimento com Resgate");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Informe o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a taxa de juros: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());
            periodoConvertido = ConversorPeriodo();
            Console.WriteLine("MÊS\t RENDA LIQUIDA\tRENDA ACUMULADA\t VALOR");
            Console.WriteLine("----------------------------------------------------");
            for (int i = 0; i <= periodoConvertido; i++)
            {
                double valorFinal = ValorFuturo(valorPresente, taxaJuros, i);
                double rendaLiquida = valorFinal  - valorPresente , valorResgate = 1000;
                if (i == periodoResgate)
                {
                    valorFinal -= valorResgate;
                    valorPresente = valorFinal;
                    periodoConvertido -= i;
                    i = 1;
                    
                }
                Console.WriteLine($"{i}\t R${rendaLiquida:f2}\tR${valorPresente + rendaLiquida - valorResgate:F2}\t R${valorFinal:f2}");
                /*Console.WriteLine($"Mês: {periodoConvertido:F2}");
                Console.WriteLine($"Renda Liquida: {rendaLiquida:F2}");
                Console.WriteLine($"Renda Acumulada: {valorPresente + rendaLiquida - valorResgate:F2}");
                Console.WriteLine($"Valor Final: {valorFinal:F2}");*/
            }
            Console.WriteLine("----------------------------------------------------");
        }
    }
}

/* Valor rendendo até o resgate, após o resgate retirar o valor (1000)
resetar os meses e começar a render denovo sobre a nova renda. */
