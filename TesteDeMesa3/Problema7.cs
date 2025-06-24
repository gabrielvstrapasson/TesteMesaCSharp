

namespace TesteMesa3
{
    public class Problema7 : Calculadora
    {

        const double resgate = 1000;
        const int periodoResgate = 5;
        double[] valorPresente = { 1000, 5500, 12000 };
        double[] taxaJuros = { 3, 2.48, 2 };
        int meses = 8, dias = 10;

        public void CalculoRendimentoResgate()
        {
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


