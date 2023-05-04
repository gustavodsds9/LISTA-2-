using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3Lis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1;
            int v2;
            int v3;

            Console.Write("Digite o 1º Valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º Valor: ");
            v2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3º Valor: ");
            v3 = int.Parse(Console.ReadLine());

            if (v1 == v2)
                if (v1 == v3)
                    Console.WriteLine("Todos os Valores são Iguais! ");
                else
            if (v1 > v3)
                    Console.WriteLine("O 1º Valor ({0}) e o 2º Valor ({1}) são Iguais e Maiores que o 3º Valor ({2})", v1, v2, v3);
                else
                    Console.WriteLine("O 1º Valor ({0}) e o 2º Valor ({1}) são Iguais e Menores que o 3º Valor ({2})", v1, v2, v3);
            else
                if (v1 == v3)
                if
                (v1 > v2)
                    Console.WriteLine("O 1º Valor ({0}) é Maior que o 2º Valor ({1}) e Iqual ao 3º Valor ({2})", v1, v2, v3);
                else
                    Console.WriteLine("O 1º Valor ({0}) é Menor que o 2º Valor ({1}) e Iqual ao 3º Valor ({2})", v1, v2, v3);
            else
                    if (v1 > v2)
                if (v1 > v3)
                    Console.WriteLine("O 1º Valor ({0}) é Maior de Todos, em Seguida o 2º Valor ({1}) e o 3º Valor ({2}) Sendo o Menor Deles.", v1, v2, v3);
                else
                    Console.WriteLine("O 1º Valor ({0}) é Maior de Todos, em Seguida o 3º Valor ({2}) e o 2º Valor ({1}) Sendo o Menor Deles.", v1, v2, v3);
            else
                          if (v1 > v3)
                Console.WriteLine("O 2º Valor ({1}) é Maior de Todos, em Seguida o 1º Valor ({0}) e o 3º Valor ({2}) Sendo o Menor Deles.", v1, v2, v3);
            else
                             if (v2 > v3)
                Console.WriteLine("O 2º Valor ({1}) é Maior de Todos, em Seguida o 3º Valor ({2}) e o 1º Valor ({0}) Sendo o Menor Deles.", v1, v2, v3);
            else
                Console.WriteLine("O 3º Valor ({2}) é Maior de Todos, em Seguida o 2º Valor ({1}) e o 1º Valor ({0}) Sendo o Menor Deles.", v1, v2, v3);
        }
    }
}
