using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMesa3;


namespace TesteDeMesa3
{
    public class Menu
    {
        public void MenuOptions()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Teste de Mesa 2");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Escolha qual problema deseja visualizar: ");
            Console.WriteLine("[0] - Sair");
            Console.WriteLine("[6] - PROBLEMA 6 - MENU COM DIVERSOS VALORES.");
            Console.WriteLine("[7] - PROBLEMA 7 - MENU COM RESGATE (5° MÊS).");
            Console.WriteLine("[8] - PROBLEMA 8 - ENTRADA + RESGATE RENDIMENTO.");
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
                case 6:
                    Console.Clear();
                    var problema6 = new Problema6();
                    problema6.MenuDiversosValores();
                    Continue();
                    break;
                case 7:
                    Console.Clear();
                    var problema7 = new Problema7();
                    problema7.CalculoRendimentoResgate();
                    Continue();
                    break;
                case 8:
                    Console.Clear();
                    var problema8 = new Problema8();
                    problema8.RendimentoComEntrada();
                    Continue();
                    break;
                    
            }
        }

        public int Continue()
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
