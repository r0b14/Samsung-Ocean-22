using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Estrutura_de_Decisao
{
    class Program
    {
        static void Main(string[] args)
        {

            char verificador;
            int tempo = 0;

            Console.WriteLine("São Paulo/SP a Belo Horizonte/MG");
            Console.WriteLine("Escolha o transporte: \n[A] = Avião \n[B] = Busão \n[C] = Carro");

            // Convertendo de string para char
            //ToLower() -> Converte para minusculo toda a string.
            //ToUpper() -> Deixa tudo maiusculo
            verificador = char.Parse(Console.ReadLine().ToUpper());

            // Estrutura de Decisão

            while (verificador != 'X')
            {
                switch (verificador)
                {
                    case 'A':
                        tempo = 45;
                        Console.WriteLine("De Avião o tempo é igual a {0}\n", tempo);
                        break;

                    case 'B':
                        tempo = 480;
                        Console.WriteLine("De Busão o tempo é igual a {0}\n", tempo);
                        break;

                    case 'C':
                        tempo = 240;
                        Console.WriteLine("De Carro o tempo é igual a {0}\n", tempo);
                        break;

                    default:
                        Console.WriteLine("Insira um caracter");
                        break;
                }

                Console.WriteLine("Digite o caracter: ");
                verificador = char.Parse(Console.ReadLine().ToUpper());

            }
            

            Console.ReadKey();
        }
    }
}
