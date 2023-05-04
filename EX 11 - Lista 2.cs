using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11Lis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;

            Console.Write("Digite a Nota P1: ");
            p1 = double.Parse(Console.ReadLine());

            p2 = (3 * 5 - p1) / 2;

            if (p2 <= 10)
                Console.WriteLine("Aluno(a) Precisa Tirar uma Nota {0} ou Maior na P2 para ser Aprovado de ano!", p2);
            else
                Console.WriteLine("Idependente da Nota do Aluno esse estar Reprovado! :0 ");
        }
    }
}
