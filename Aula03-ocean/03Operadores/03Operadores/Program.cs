using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Operadores Relacionais não apresentando resultados normais, são resultados booleanos.
             * A sua principal função é fazer comparação entre valores, que seja int, char, long, booler...
             * O seu resultado é TRUE ou FALSE -> 0 ou 1
             **/
            int a = 10;

            bool c1 = a < 10; // A resposta é a condição
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a == 10;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

        }
    }
}
