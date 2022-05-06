using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_01_06_05.Models
{
    /* Atributos da classe produto
     * Codigo
     * Nome 
     * Preço
     */
    class Produtos
    {
        /*
         * get -> pegar informação
         * set -> inserir informações
        */

        public int Codigo { get; set; }

        public int Nome { get; set; }

        public int Preco { get; set; }

    
        // Essa variavel não pode ser alterada, pois terá o caminho do nosso banco de dados
        /**
         * private -> os codigos ficam privados 
         **/
        private const string caminhodobanco = "Database/Produto.csv";

        // csv - Valores separados por virgula

        // ctor tab tab -> criar construtor 
        public Produtos()
        {
            // SPLIT = Responsável por separar uma string a partir de um parametro e tem como retorno um array.
            string pasta = caminhodobanco.Split('/')[0];

            // So entra no if se a pasta não existir
            if (!Directory.Exists(pasta))
            {
                // Criar uma pasta no nosso projeto
                Directory.CreateDirectory(pasta);
            }

            // Verificando se o arquivo existe ou não
            if (!File.Exists(caminhodobanco))
            {
                // Criando arquivo dentro da pasta
                File.Create(caminhodobanco);
            }
        }
        
    }
}
