
namespace TesteMesa3
{
    public class Problema6 : Calculadora
    {
        public void MenuDiversosValores()
        {
            double[] valorPresente = { 1000, 5500, 12000 };
            double[] taxaJuros = { 3, 2.48, 2 };
            int meses = 8, dias = 10;

            ImprimirCabecalho();
            foreach (var vp in valorPresente)
            {
                foreach (var taxa in taxaJuros)
                {
                    double valorFuturoDiario = ValorFuturoDiario(vp, taxa, meses, dias);
                    ImprimirCalculo(meses, dias, vp, taxa, valorFuturoDiario);
                }
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }
}
