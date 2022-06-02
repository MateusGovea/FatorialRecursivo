using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número para calcular o fatorial: ");
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine("O fatorial de " + num + "é: " + Fatorial(num));

            Console.ReadKey();
        }

        static int Fatorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }
            return num * Fatorial(num - 1);
        }
    }
}
