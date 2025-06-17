using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Menu
    {
        public static void MenuOptions()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Teste de Mesa 2");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Escolha qual problema deseja visualizar: ");
            Console.WriteLine("[0] - Sair");
            Console.WriteLine("[1] - Rendimento de um investimento.");
            Console.WriteLine("[2] - Rendimento ao mês com Juros Compostos.");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Saindo..");
                    Thread.Sleep(1000);
                    break;
                case 1:
                    Console.Clear();
                    Problema1.RendimentoInvestimento();
                    Continue();
                    break;
                case 2:
                    Console.Clear();
                    Problema2.RendimentoAoMes();
                    Continue();
                    break;
            }
        }

        public static int Continue()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("[0] - Sair.");
            Console.WriteLine("[1] - Continuar");
            Console.Write("Opção: ");
            int opcaoContinue = Convert.ToInt32(Console.ReadLine());
            if (opcaoContinue == 0)
            {
                Console.Clear();
                Console.WriteLine("Encerrando..");
                Thread.Sleep(1000);
            }
            else if (opcaoContinue == 1)
            {
                Console.Clear();
                MenuOptions();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida.");
                Thread.Sleep(1000);
                Continue();
            }

            return opcaoContinue;
        }
    }

}
