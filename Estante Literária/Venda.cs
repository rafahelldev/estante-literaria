using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estante_Literária
{
    class Venda
    {
        public int cod_venda { get; set; }
        public int cod_cliente { get; set; }
        public int cod_funcionario { get; set; }
        public DateTime dt_registro { get; set; }
        public decimal valor_totalvenda { get; set; }

        public Venda(int cod_venda, int cod_cliente, int cod_funcionario, DateTime dt_registro, decimal valor_totalvenda)
        {
            this.cod_venda = cod_venda;
            this.cod_cliente = cod_cliente;
            this.cod_funcionario = cod_funcionario;
            this.dt_registro = dt_registro;
            this.valor_totalvenda = valor_totalvenda;
        }
    }
}
