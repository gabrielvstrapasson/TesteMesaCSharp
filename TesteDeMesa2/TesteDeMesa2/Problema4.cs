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
            const double valorResgate = 1000;
            double resgateAtual = 0;
            int mesRelativo = 1;
            int periodoResgate = 5;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Rendimento com Resgate");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Informe o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a taxa de juros: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());
            periodoConvertido = ConversorPeriodo();
            Console.WriteLine($"{"MÊS",4}|{"RENDA LIQUIDA",15}|{"RENDA ACUMULADA",15}|{"RESGATE",15}");
            Console.WriteLine("----------------------------------------------------");
            double valorFinalAnterior = valorPresente;
            for (int i = 1; i <= periodoConvertido; i++)
            {

                double valorFinalAtual = ValorFuturo(valorPresente, taxaJuros, mesRelativo);
                double rendaLiquida = valorFinalAtual - valorFinalAnterior;


                if (i == periodoResgate)
                {

                    valorFinalAtual -= valorResgate;
                    valorPresente = valorFinalAtual;
                    resgateAtual = valorResgate;
                }

                Console.WriteLine($"{mesRelativo,4}|{rendaLiquida,15:F2}|{valorFinalAtual,15:F2}|{resgateAtual,15:F2}");
                valorFinalAnterior = valorFinalAtual;

                if (i == periodoResgate)
                    mesRelativo = 0;

                resgateAtual = 0;

                mesRelativo++;

            }
            Console.WriteLine("----------------------------------------------------");
        }
    }
}

/* Valor rendendo até o resgate, após o resgate retirar o valor (1000)
resetar os meses e começar a render denovo sobre a nova renda. */
