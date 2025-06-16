using System;
using System.Collections.Generic;
using System.Linq;
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
            return opcao;
        }


    }
}
