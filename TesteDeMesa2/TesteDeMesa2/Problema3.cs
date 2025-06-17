using System;

namespace TesteDeMesa2
{
    public class Problema3 : Calculator
    {
        public static void RendimentoAno()
        {
            double valorPresente, taxaJuros;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Rendimento Calculado");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Informe o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a taxa de juros: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());
            CalculoTaxaJuros(taxaJuros);
            Console.Write("Informe o periodo em anos: ");
            double periodoAnos = double.Parse(Console.ReadLine()!);
            periodoAnos *= 12;
            double valorFinal = ValorFuturo(valorPresente, taxaJuros, periodoAnos);
            Console.WriteLine($"Dados Informados:\nValor Presente: R${valorPresente}\nTaxa Juros: {taxaJuros}\nPeriodo[Anos]: {periodoAnos:F0}\nValor Final: R${valorFinal}");

            Console.WriteLine("----------------------------------------------------");

        }
    }
}
