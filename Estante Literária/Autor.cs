using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estante_Literária
{
    class Autor
    {
        public int cod_autor { get; set; }
        public string nome { get; set; }
        public DateTime dt_nascimento { get; set; }
        public string descricao { get; set; }
        public DateTime dt_cadastro { get; set; }

        public Autor(int cod_autor, string nome, DateTime dt_nascimento, string descricao, DateTime dt_cadastro)
        {
            this.cod_autor = cod_autor;
            this.nome = nome;
            this.dt_nascimento = dt_nascimento;
            this.descricao = descricao;
            this.dt_cadastro = dt_cadastro;
        }
    }
}
