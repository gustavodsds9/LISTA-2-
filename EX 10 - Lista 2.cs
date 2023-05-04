using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10Lis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double media;

            Console.Write("Digite a 1º Nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a 2º Nota: ");
            nota2 = double.Parse(Console.ReadLine());
            media = (nota1 + 2 * nota2) / 3;

            if (media < 5)
                Console.WriteLine("Aluno(a) Reprovado! :( ");
            else
                Console.WriteLine("Aluno(a) Aprovado! ;) ");
        }
    }
}
