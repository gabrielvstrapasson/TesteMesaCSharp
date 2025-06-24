

namespace TesteMesa3
{
    public class Calculadora
    {
        public void ImprimirCabecalho()
        {
            Console.WriteLine($"{"PERÍODO".PadRight(18)}{"VALOR PRESENTE",12}{"TAXA JUROS",12}{"VALOR FUTURO",18}");
            Console.WriteLine("----------------------------------------------------");
        }
        public void ImprimirCalculo(int valorMes, double valorDia, double valorPresente, double taxaJuros, double valorFuturo)
        {
            Console.WriteLine($"{valorMes}Meses {(int)valorDia}Dias".PadRight(18) +
                              $"{"R$" + valorPresente,12:F2}" +
                              $"{taxaJuros.ToString("F2") + "%",12}" +
                              $"{("R$" + valorFuturo.ToString("F2")).PadLeft(18)}");
        }

        public double CalculoTotalDias(int meses, int dias)
        {
            var dataHoje = DateTime.Today;
            var dataFutura = dataHoje.AddMonths(meses).AddDays(dias);
            return (dataFutura - dataHoje).TotalDays;
        }
        public double CalculoTaxaJurosDiaria (double percentualTaxaJurosMensal)
        {
            double taxaJurosMensal = percentualTaxaJurosMensal / 100;
            return Math.Pow(1 + taxaJurosMensal, 1.0 / 30.0) - 1;
        }

        public double ValorFuturoDiario (double valorPresente, double percentualTaxaJurosMensal, int meses, int dias)
        {
            double totalDias = CalculoTotalDias(meses, dias);
            double taxaDiaria = CalculoTaxaJurosDiaria(percentualTaxaJurosMensal);
            return Math.Round(valorPresente * Math.Pow(1 + taxaDiaria, totalDias), 2);
        }        
        public void CalculoComResgateMensal (double valorPresente, double taxaMensal, int meses, int diasExtras, double valorResgate, int mesResgate)
        {
            double saldo = valorPresente;
            double rendimentoAcumulado = 0;
            Console.WriteLine($"{"VP",10} {"TAXA",6} {"MÊS/DIA",8} {"VF",12} {"RENDIMENTO",12} {"RESGATE",10} {"APÓS RESGATE",14}");

            for (int mes = 1; mes <= meses; mes++)
            {
                double rendimento = saldo * (taxaMensal / 100);
                rendimentoAcumulado = rendimento;

                double resgateAplicado = (mes == mesResgate) ? valorResgate : 0;
                double novoSaldo = (saldo + rendimento) - resgateAplicado;
                Console.WriteLine($"{Math.Round(valorPresente,2),10} {taxaMensal,6:F2}% {mes,8} {saldo + rendimento,12:C2} {rendimentoAcumulado,12:C2} {resgateAplicado,10:C2} {novoSaldo,14:C2}");
                saldo = novoSaldo;
            }

            double taxaDiaria = CalculoTaxaJurosDiaria(taxaMensal);
            double rendimentoDias = saldo * Math.Pow(1 + taxaDiaria, diasExtras) - saldo;
            double saldoFinal = saldo + rendimentoDias;
            Console.WriteLine($"{saldo,10:C2} {taxaMensal,6:F2}% {$"+{diasExtras}d",8} {saldoFinal,12:C2} {rendimentoDias,12:C2} {"-",10} {saldoFinal,14:C2}");
            Console.WriteLine("------------------------------------------");
        }
        
        
        
        
    }
}

