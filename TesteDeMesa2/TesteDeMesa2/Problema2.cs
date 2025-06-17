using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Problema2 : Calculator
    {

        public static void RendimentoAoMes()
        {
            double valorPresente = 3800, taxaJuros = 1.25;
            int periodo = 6;
            double rendaLiquido, rendaAcumulado = 0, valorAnterior;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Calculo de Rendimento - Valor Fixo");
            Console.WriteLine("----------------------------------------------------");
            valorAnterior = valorPresente;
            Console.WriteLine("MÊS\t TAXA JUROS\t VALOR\t\t RENDA LIQUIDA\tRENDA ACUMULADA");
            Console.WriteLine("----------------------------------------------------");
            for (int i = 1; i <= periodo; i++)
            {
                double valorFinal = ValorFuturo(valorPresente, taxaJuros, i);

                Console.Write($"{i}\t   {taxaJuros}%\t R${valorFinal:F2}\t");
                /*Console.WriteLine($"Taxa Juros = {taxaJuros}%");
                Console.WriteLine($"Rendimento = R${valorFinal:F2}"); */
                rendaLiquido = valorFinal - valorAnterior;
                Console.Write($" R${rendaLiquido:F2}");
                rendaAcumulado += rendaLiquido;
                Console.Write($"\tR${rendaAcumulado:F2}");
                Console.WriteLine();
                valorAnterior = valorFinal;
            }
            Console.WriteLine("----------------------------------------------------");

        }
    }
}