using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDeMesa
{
    public class TMESA01_02
    {
        public static void TM01_02 ()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("TESTE DE MESA 01 [02]");
            int a = 2;
            int[] v = new int[6];
            while (a < 6)
            {
                Console.WriteLine("--------------------------------------");
                v[a] = 10 * a;
                Console.WriteLine($"V[A] =  {v[a]}");
                Console.WriteLine($"A =  {a}");
                a += 1;
            }
            int opcaoContinue = Menu.Continue();
        }
    }
}
