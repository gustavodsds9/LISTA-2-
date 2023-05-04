using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7Lis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            double v3;

            Console.Write("Digite o Valor da 1º Lateral: ");
            v1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o Valor da 3º Lateral: ");
            v2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o Valor da 3º Lateral: ");
            v3 = double.Parse(Console.ReadLine());

            if ((v1 > v2 + v3) || (v2 > v1 + v3) || (v3 > v1 + v2))
                if ((v1 == v2) && (v1 == v3))
                    Console.WriteLine("Os Lados Formam um Triângulo Equilátero! ");
                else
                    if ((v1 == v2 && v1 < v3) || (v1 == v3 && v1 < v2) || (v3 == v2 && v3 < v1))
                    Console.WriteLine("Os Lados Formam um Triângulo Isósceles! ");
                else
                    Console.WriteLine("Os Lados Formam um Triângulo Escaleno! ");
            else
                Console.WriteLine("Os Valores Informados para os Lados, não Formam um Triângulo !!!");
        }
    }
}
