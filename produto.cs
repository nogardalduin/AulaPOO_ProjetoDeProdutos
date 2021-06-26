using System.Collections.Generic;
using System.IO;

namespace exemplo_mvc_manha.models
{
    public class produto
    {
        public produto(int codigo, string nome, float preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.preco = preco;

        }
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public produto()
        {

            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<produto> Ler();
        {

            List<produto> produtos = new List<produto>();

            string[] linhas - File.ReadAllLines(PATH)

        }
    }
}