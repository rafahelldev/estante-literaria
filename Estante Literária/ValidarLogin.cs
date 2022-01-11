using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estante_Literária
{
    class ValidarLogin
    {
        public int cod_funcionario { get; set; }
        public string chave_acesso { get; set; }
        public string cargo { get; set; }

        public ValidarLogin(int cod_funcionario, string chave_acesso)
        {
            this.cod_funcionario = cod_funcionario;
            this.chave_acesso = chave_acesso;
        }

        public ValidarLogin(int cod_funcionario, string chave_acesso, string cargo)
        {
            this.cod_funcionario = cod_funcionario;
            this.chave_acesso = chave_acesso;
            this.cargo = cargo;
        }

        public ValidarLogin(int cod_funcionario)
        {
            this.cod_funcionario = cod_funcionario;
        }
    }
}
