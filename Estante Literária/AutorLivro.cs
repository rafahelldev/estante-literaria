using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estante_Literária
{
    class AutorLivro
    {
        public int cod_autorlivro { get; set; }
        public int cod_autor { get; set; }
        public int cod_livro { get; set; }

        public AutorLivro(int cod_autorlivro, int cod_autor, int cod_livro)
        {
            this.cod_autorlivro = cod_autorlivro;
            this.cod_autor = cod_autor;
            this.cod_livro = cod_livro;
        }
    }
}
