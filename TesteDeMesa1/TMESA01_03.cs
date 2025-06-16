using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDeMesa
{
    public class TMESA01_03
    {
        public static void TM01_03()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("TESTE DE MESA 01 [03]");

            int a = 7;
            int b = a - 6;
            int[] v = new int[7];
            while (b < a)
            {
                Console.WriteLine("--------------------------------------");
                v[b] = b + a;
                Console.WriteLine($"v[b] = {v[b]}");
                Console.WriteLine($"b = {b}");
                b += 2;
            }
        }
    }
}
