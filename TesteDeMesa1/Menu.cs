using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TestesDeMesa
{
    public class Menu
    {
        public static int MenuTM01 ()
        {
            Console.WriteLine("Escolha qual teste de mesa você deseja ver:");
            Console.WriteLine("1 - Teste de Mesa 01 [01].");
            Console.WriteLine("2 - Teste de Mesa 01 [02].");
            Console.WriteLine("3 - Teste de Mesa 01 [03].");
            Console.WriteLine("0 - Sair.");
            Console.Write("Opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(2000);
                    break;

                case 1:
                    TMESA01_01.TM01_01();
                    break;

                case 2:
                    TMESA01_02.TM01_02();
                    break;

                case 3:
                    TMESA01_03.TM01_03();
                    break;
            }
            return opcao;
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
                MenuTM01();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida.");
                Thread.Sleep(1000);
                Menu.Continue();
            }

            return opcaoContinue;
        }

    }
}
