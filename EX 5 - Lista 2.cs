using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5Lis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.Write("Digite o Valor da Base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o Valor da altura: ");
            h = int.Parse(Console.ReadLine());
            a = b * h;

            if (a > 100)
                Console.WriteLine("Terreno Grande :) ");
            else
                Console.WriteLine("Terreno Pequeno :( ");
        }
    }
}
