using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {

            int primeiro = 1;
            int segundo = 10;
            int terceiro = 20;

            // Quanto temos um + com string o C# entende que é uma junção -> concatenação

            // Quanto temos + com numeros(int) o C# entende que é soma
            Console.WriteLine("Soma de todos os valores= " + (primeiro + segundo + terceiro));
            Console.WriteLine("Subtração de todos os valores= " + (primeiro - segundo - terceiro));
            Console.WriteLine("Multiplicação de todos os valores= " + (primeiro * segundo * terceiro));
            Console.WriteLine("Divisão de todos os valores= " + (primeiro / segundo / terceiro));
            Console.WriteLine("Resto da divisão= " + (primeiro % segundo));


            Console.ReadKey();
        }
    }
}
