using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula_02___Estrutura_de_Decisão
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando diversas formas que apresentar o mesmo conteudo
            int idade = 28;
            double saldo = 10.255;
            string nome = "Maria Roseane";

            // Apresentando usando 1 forma
            Console.WriteLine(nome + " " + saldo + " " + idade);

            // Apresentando de uma outra forma
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo);
            //Limitando as casas decimais
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //trocando saldo do tipo double para string.
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

        }

        void parouimpar()
        {
            // Usando estrutura de decisão.  
            Console.WriteLine("Digite um numero: ");

            // ReadLine sempre devolve como string, por isso temos que forçar para p
            long numero = long.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Numero Par");
            }
            else
            {
                Console.WriteLine("Numero Ímpar");
            }
        }

        void exercicio()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            /*Usando os valores das variáveis, produza a seguinte saída na tela do console:
                Produtos:
                Computador, cujo preço é $ 2100,00
                Mesa de escritório, cujo preço é $ 650,50
                Registro: 30 anos de idade, código 5290 e gênero M
                Medida com oito casas decimais: 53,23456700
                Arredondado (três casas decimais): 53,235
            */
            Console.WriteLine("{0}, cujo preço é {1:C2}", produto1, preco1);

            Console.WriteLine("{0}, cujo preço é {1:C2}", produto2, preco2);

            Console.WriteLine("Registro: {0} anos de idade, codigo {1} e gênero {2}", idade, codigo, genero);

            Console.WriteLine("Medida com oito casas decimais: {0:C8}", medida);

            Console.WriteLine("Arredondando {0:C3}", medida);

        }
    }
}
