using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estante_Literária
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dt_cadastro { get; set; }
        public DateTime dt_nascimento { get; set; }
        public string tel_principal { get; set; }
        public string tel_reserva { get; set; }
        public string email { get; set; }

        public Pessoa(string nome, string cpf, DateTime dt_cadastro, DateTime dt_nascimento, 
            string tel_principal, string tel_reserva, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dt_cadastro = dt_cadastro;
            this.dt_nascimento = dt_nascimento;
            this.tel_principal = tel_principal;
            this.tel_reserva = tel_reserva;
            this.email = email;
        }
    }
}
