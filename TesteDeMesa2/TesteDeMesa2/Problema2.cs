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
            Console.WriteLine("PROBLEMA 2 - RENDIMENTO [MÊS] [VALOR FIXO]");
            Console.WriteLine("----------------------------------------------------");
            valorAnterior = valorPresente;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"{"MÊS",4}|{"TAXA JUROS",15}|{"VALOR FUTURO",15}|{"RENDA LIQUIDA",15}|{"RENDA ACUMULADA",15}|");
            Console.WriteLine("----------------------------------------------------");
            for (int i = 1; i <= periodo; i++)
            {
                double valorFuturo = ValorFuturo(valorPresente, taxaJuros, i);

                Console.Write($"{i,4}|{taxaJuros,15:F2}|{valorFuturo,15:F2}|");
                /*Console.WriteLine($"Taxa Juros = {taxaJuros}%");
                Console.WriteLine($"Rendimento = R${valorFinal:F2}"); */
                rendaLiquido = valorFuturo - valorAnterior;
                Console.Write($"{rendaLiquido,15:F2}|");
                rendaAcumulado += rendaLiquido;
                Console.Write($"{rendaAcumulado,15:F2}|");
                Console.WriteLine();
                valorAnterior = valorFuturo;
            }
            Console.WriteLine("----------------------------------------------------");

        }
    }
}