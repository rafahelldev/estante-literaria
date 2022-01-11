using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estante_Literária
{
    class Cliente:Pessoa
    {
        public int cod_cliente { get; set; }

        public Cliente(string nome, string cpf, DateTime dt_cadastro, DateTime dt_nascimento,
            string tel_principal, string tel_reserva, string email, int cod_cliente) :
            base(nome, cpf, dt_cadastro, dt_nascimento, tel_principal, tel_reserva, email)
        {
            this.cod_cliente = cod_cliente;
        }
    }
}
