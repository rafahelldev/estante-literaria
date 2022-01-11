using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estante_Literária
{
    class Livro
    {
        public int cod_livro { get; set; }
        public string titulo { get; set; }
        public int ano_publicacao { get; set; }
        public string editora { get; set; }
        public string descricao { get; set; }
        public DateTime dt_cadastro { get; set; }
        public decimal valor_livro { get; set; }

        public Livro(int cod_livro, string titulo, int ano_publicacao, string editora, 
            string descricao, DateTime dt_cadastro, decimal valor_livro)
        {
            this.cod_livro = cod_livro;
            this.titulo = titulo;
            this.ano_publicacao = ano_publicacao;
            this.editora = editora;
            this.descricao = descricao;
            this.dt_cadastro = dt_cadastro;
            this.valor_livro = valor_livro;
        }
    }
}
