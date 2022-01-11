using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estante_Literária
{
    class Funcionario:Pessoa
    {
        public int cod_funcionario { get; set; }
        public string status { get; set; }
        public string cargo { get; set; }
        public string turno { get; set; }
        public decimal salario { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }

        public string chave_acesso { get; set; }
        public DateTime dt_admissao { get; set; }
        public DateTime dt_desligamento { get; set; }


        public Funcionario(string nome, string cpf, DateTime dt_cadastro, DateTime dt_nascimento,
            string tel_principal, string tel_reserva, string email, int cod_funcionario, string status,
            string cargo, string turno, decimal salario, string cidade, string bairro, string cep,
            string rua, int numero, string complemento, string chave_acesso, DateTime dt_admissao,
            DateTime dt_desligamento) :base(nome, cpf, dt_cadastro, dt_nascimento, tel_principal, 
                tel_reserva, email)
        {
            this.cod_funcionario = cod_funcionario;
            this.status = status;
            this.cargo = cargo;
            this.turno = turno;
            this.salario = salario;
            this.cidade = cidade;
            this.bairro = bairro;
            this.cep = cep;
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.chave_acesso = chave_acesso;
            this.dt_admissao = dt_admissao;
            this.dt_desligamento = dt_desligamento;
        }
    }
}
