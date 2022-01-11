using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estante_Literária
{
    class ItemVenda
    {
        public int cod_itemvenda { get; set; }
        public int cod_venda { get; set; }
        public DateTime dt_registro { get; set; }
        public int cod_livro { get; set; }
        public decimal valor_livro { get; set; }
        public int unidades { get; set; }
        public decimal valor_itemvenda { get; set; }

        public ItemVenda(int cod_itemvenda, int cod_venda, DateTime dt_registro, int cod_livro, decimal valor_livro, 
            int unidades, decimal valor_itemvenda)
        {
            this.cod_itemvenda = cod_itemvenda;
            this.cod_venda = cod_venda;
            this.dt_registro = dt_registro;
            this.cod_livro = cod_livro;
            this.valor_livro = valor_livro;
            this.unidades = unidades;
            this.valor_itemvenda = valor_itemvenda;
        }
    }
}
