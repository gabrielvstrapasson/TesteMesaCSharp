using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDeMesa
{
    public class TMESA01_01
    {
        public static void TM01_01()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("TESTE DE MESA 01 [01]");
            int a = 10;
            Console.WriteLine($"A: {a}");
            int b = 20;
            Console.WriteLine($"B: {b}");
            int c = (a + b) / 2;
            Console.WriteLine($"C: {c}");
            c = c - 40;
            Console.WriteLine($"C(2): {c}");
            int[] v = new int[4];

            for (int i = 0; i < v.Length; i++) 
            {
                Console.WriteLine("--------------------------------------");
                if (i == 3)
                {
                    v[i] = a + b + c;
                    Console.WriteLine($"O valor do vetor na posição {i}°: {v[i]} = V");
                }
                else
                {
                    Console.WriteLine($"O valor do vetor na posição {i}° {v[i]} = F");
                }

            }
            Console.WriteLine("--------------------------------------");
            int opcaoContinue = Menu.Continue();

        }
    }
}
