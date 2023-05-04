using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9Lis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p;
            double h;
            double imc;
            int s;

            Console.Write("Digite seu Peso: ");
            p = double.Parse(Console.ReadLine());
            Console.Write("Digite sua Altura: ");
            h = double.Parse(Console.ReadLine());
            Console.Write("Digte seu Sexo, sendo (1) para Masculino, e (2) para Feminino: ");
            s = int.Parse(Console.ReadLine());
            imc = p / (Math.Pow(h, 2));

            if (s == 1)
                if (imc < 20)
                    Console.WriteLine("Abaixo do Peso! :| ");
                else
                       if (imc < 25)
                    Console.WriteLine("Peso Ideal! :) ");
                else
                    Console.WriteLine("Acima do Peso! :( ");

            else
                    if (imc < 19)
                Console.WriteLine("Abaixo do Peso! :| ");
            else
                    if (imc < 24)
                Console.WriteLine("Peso Ideal! :) ");
            else
                Console.WriteLine("Acima do Peso! :( ");
        }
    }
}
