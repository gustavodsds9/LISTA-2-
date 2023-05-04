using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1Lis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1;
            int v2;

            Console.Write("Digite o 1º Valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º Valor: ");
            v2 = int.Parse(Console.ReadLine());

            if (v1 > v2)
                Console.WriteLine("O 1º Valor ({0}) é Maior que o 2º Valor ({1})", v1, v2);
            else
                Console.WriteLine("O 2º Valor ({1}) é Maior que o 1º Valor ({0})", v1, v2);
        }
    }
}
