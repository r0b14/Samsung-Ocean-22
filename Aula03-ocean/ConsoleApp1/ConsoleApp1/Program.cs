using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) // é preciso que o programa esteja escrito dentro do main
        {
            /**
             * Comentário de varias linhas
            **/
            //usando variaveis
            string nome = "Robson";
            /* String -> tipo da variavel 
             * nome -> nome da variavel
             * = -> atribuição
             * "Robson" -> o 'valor' que vai ser guardado no variavel do tipo string
             */

            int idade = 22;
            /* int -> tipo da variavel 
             * idade -> nome da variavel
             * = -> atribuição
             * 22 -> o valor que vai ser guardado no variavel do tipo string
             */
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.ReadKey();
        }
    }
}
