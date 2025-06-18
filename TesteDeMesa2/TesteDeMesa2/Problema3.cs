using System;

namespace TesteDeMesa2
{
    public class Problema3 : Calculator
    {
        public static void RendimentoAno()
        {
            double valorPresente, taxaJuros;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("PROBLEMA 3 - RENDIMENTO [ENTRADA DE DADOS]");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Informe o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a taxa de juros: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());
            CalculoTaxaJuros(taxaJuros);
            Console.Write("Informe o periodo em anos: ");
            double periodoAnos = double.Parse(Console.ReadLine()!);
            periodoAnos *= 12;
            double valorFuturo = ValorFuturo(valorPresente, taxaJuros, periodoAnos);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"{"MÊS",4}|{"VALOR PRESENTE",15}|{"TAXA JUROS",15}|{"VALOR FUTURO",15}|");
            Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine($"Dados Informados:\nValor Presente: R${valorPresente}\nTaxa Juros: {taxaJuros}\nPeriodo[Anos]: {periodoAnos:F0}\nValor Final: R${valorFinal}");
            Console.WriteLine($"{periodoAnos,4}|{valorPresente,15}|{taxaJuros,15}|{valorFuturo,15}|");
            Console.WriteLine("----------------------------------------------------");

        }
    }
}
