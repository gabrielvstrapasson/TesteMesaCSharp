using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMesa3
{
    class Problema8 : Calculadora
    {


        public void RendimentoComEntrada()
        {
            Console.Write("Informe a quantidade de Entradas: ");
            int quantidadeEntrada = int.Parse(Console.ReadLine()!);
            Console.Write("Deseja fazer resgate? (s/n)");
            char opcaoResgate = char.Parse(Console.ReadLine()!);
            double resgate = 0;
            int periodoResgate = 0;
            double[] valorPresente = new double[quantidadeEntrada];
            double[] taxaJuros = new double[quantidadeEntrada];

            if (opcaoResgate == 's' || opcaoResgate == 'S')
            {
                Console.Write("Informe o valor do resgate: ");
                resgate = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o mês que será aplicado o resgate: ");
                periodoResgate = Convert.ToInt32(Console.ReadLine());
            }
            else
                Console.WriteLine("Escolhido sem resgate.");

            Console.Write("Informe os valores de investimento iniciais: ");
            for (int i = 0; i < quantidadeEntrada; i++)
            {
                valorPresente[i] = double.Parse(Console.ReadLine()!);
            }

            Console.Write("Informe as taxas de juros a serem calculadas: ");
            for (int i = 0; i < quantidadeEntrada; i++)
            {
                taxaJuros[i] = double.Parse(Console.ReadLine()!);
            }
            Console.Write("Informe a quantidade de meses: ");
            int meses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe os dias extras: (Caso não tiver = 0)");
            int dias = Convert.ToInt32(Console.ReadLine());

            foreach (var vp in valorPresente)
            {
                Console.WriteLine($"\n\n=== Iniciando cálculo para -> R${vp:F2}  ===\n\n");
                foreach (var taxa in taxaJuros)
                {
                    Console.WriteLine($"\n>> Taxa: {taxa:F2}% ao mês");
                    CalculoComResgateMensal(vp, taxa, meses, dias, resgate, periodoResgate);
                }
            }
        }
    }


}
