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
            double valorPresente, taxaJuros;
            int periodoMes;
            double rendimentoLiquido, rendimentoAcumulado = 0, valorAnterior;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Calculo de Rendimento ao Mês");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Informe o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a taxa de juros: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine()!.Replace(',', '.'));
            Console.Write("Informe o periodo (mês): ");
            periodoMes = Convert.ToInt32(Console.ReadLine());
            valorAnterior = valorPresente;

            for (int i =1; i <= periodoMes; i++)
            {
                Console.WriteLine("----------------------------------------------------");
                double valorFinal = ValorFuturo(valorPresente, taxaJuros, i);
                Console.WriteLine($"Mês: {i}");
                Console.WriteLine($"Taxa Juros = {taxaJuros}%");
                Console.WriteLine($"Rendimento = R${valorFinal:F2}");
                rendimentoLiquido = valorFinal - valorAnterior;
                Console.WriteLine($"Rendimento Liquido = R${rendimentoLiquido:F2}");
                rendimentoAcumulado += rendimentoLiquido;
                Console.WriteLine($"Rendimento Acumulado = R${rendimentoAcumulado:F2}");
                valorAnterior = valorFinal;
            }
            Console.WriteLine("----------------------------------------------------");

        }
    }
}
