using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6Lis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p;
            double h;
            double imc;

            Console.Write("Digite o seu Peso: ");
            p = double.Parse(Console.ReadLine());
            Console.Write("Digite sua Altura: ");
            h = double.Parse(Console.ReadLine());
            imc = p / (Math.Pow(h, 2));

            if (imc < 20)
                Console.WriteLine("Abaixo do peso :| ");
            else
                    if (imc < 25)
                Console.WriteLine("Peso Ideal :) ");
            else
                Console.WriteLine("Acima do Peso :( ");
        }
    }
}
