using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estante_Literária
{
    public partial class FormFuncionario : Form
    {


        public FormFuncionario()
        {


            InitializeComponent();


            //  Botão btnNovaConsulta inicialmente invisível
            btnNovaConsulta.Visible = false;

            //  Um dos radio buttons sempre será selecionado!
            rbConsultarCodFuncionario.Checked = true;


        }


        //  Variáveis
        string nome;
        string cpf;
        string dt_nascimento_sem_formatacao;
        string tel_principal;
        string tel_reserva;
        string email;
        int cod_funcionario;
        string status;
        string cargo;
        string turno;
        decimal salario;
        string cidade;
        string bairro;
        string cep;
        string rua;
        int numero;
        string complemento;
        string chave_acesso;
        string dt_admissao_sem_formatacao;
        List<Funcionario> funcionarios = new List<Funcionario>();
        Funcionario escolhido;


        //  Se conectando ao banco de dados
        BancoDeDados BD = new BancoDeDados();


        //  Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            //  Criando um código para o novo cadastro
            string numeros = "123456789";
            string cod_gerado = "";

            Random random_codigo = new Random();
            for (int f = 0; f < 8; f++)
            {
                cod_gerado = cod_gerado + numeros.Substring(random_codigo.Next(0, numeros.Length - 1), 1);
            }


            //  Criando uma chave para o novo cadastro
            string numeroseletras = "123456789abcdefghijklmnopqrstuvwxyz";
            string chave_gerada = "";

            Random random_chave = new Random();
            for (int f = 0; f < 8; f++)
            {
                chave_gerada = chave_gerada + numeroseletras.Substring(random_chave.Next(0, numeroseletras.Length - 1), 1);
            }


            //  Definindo dados
            nome = txtNome.Text;
            cpf = mtxtCPF.Text;
            DateTime dt_cadastro = DateTime.Now;

            dt_nascimento_sem_formatacao = mtxtDataNascimento.Text;
            DateTime dt_nascimento = DateTime.Parse(dt_nascimento_sem_formatacao);

            tel_principal = mtxtTelefonePrincipal.Text;
            tel_reserva = mtxtTelefoneReserva.Text;
            email = txtEmail.Text;
            cod_funcionario = Convert.ToInt32(cod_gerado);
            status = "FUNCIONÁRIO ATIVO";
            cargo = txtCargo.Text;
            turno = cbTurno.Text;
            salario = Convert.ToDecimal(txtSalario.Text);
            cidade = txtCidade.Text;
            bairro = txtBairro.Text;
            cep = mtxtCEP.Text;
            rua = txtRua.Text;
            numero = Convert.ToInt32(txtNumero.Text);
            complemento = txtComplemento.Text;
            chave_acesso = chave_gerada;

            dt_admissao_sem_formatacao = mtxtDataAdmissao.Text;
            DateTime dt_admissao = DateTime.Parse(dt_admissao_sem_formatacao);

            DateTime dt_desligamento = DateTime.MinValue;


            //  Instanciando a classe Funcionário
            Funcionario novoFuncionario = new Funcionario(nome, cpf, dt_cadastro, dt_nascimento, tel_principal, tel_reserva,
                email, cod_funcionario, status, cargo, turno, salario, cidade, bairro, cep, rua, numero, complemento, chave_acesso,
                dt_admissao, dt_desligamento);


            //  Cadastrando o novo cliente
            if (BD.Conecta())
            {


                if (BD.CadastrarFuncionario(novoFuncionario))
                {


                    MessageBox.Show("Funcionário cadastrado com sucesso");


                    txtNome.Text = string.Empty;
                    mtxtCPF.Text = string.Empty;
                    mtxtDataNascimento.Text = string.Empty;
                    mtxtTelefonePrincipal.Text = string.Empty;
                    mtxtTelefoneReserva.Text = string.Empty;
                    txtEmail.Text = string.Empty;

                    txtCargo.Text = string.Empty;
                    cbTurno.Text = string.Empty;
                    txtSalario.Text = string.Empty;
                    txtCidade.Text = string.Empty;
                    txtBairro.Text = string.Empty;
                    mtxtCEP.Text = string.Empty;
                    txtRua.Text = string.Empty;
                    txtNumero.Text = string.Empty;
                    txtComplemento.Text = string.Empty;

                    mtxtDataAdmissao.Text = string.Empty;


                }

                else
                    MessageBox.Show("O funcionário já possui cadastro");


                BD.Desconecta();


            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }


        //  Consultar
        private void btnConsultarCadastro_Click(object sender, EventArgs e)
        {


            if (BD.Conecta())
            {


                if (rbConsultarNome.Checked)
                {


                    if (string.IsNullOrWhiteSpace(cbConsultarPorNome.Text))
                    {
                        MessageBox.Show("Insira o nome do funcionário");
                    }

                    else
                    {


                        cbConsultarPorNome.Items.Clear();


                        string parteNome = cbConsultarPorNome.Text;
                        funcionarios = BD.ConsultarFuncionario_Nome(parteNome);


                        for (int i = 0; i < funcionarios.Count; i++)
                        {
                            cbConsultarPorNome.Items.Add(funcionarios[i].nome);
                        }


                        btnConsultarCadastro.Visible = false;
                        btnNovaConsulta.Visible = true;


                    }


                }

                else
                {


                    if (string.IsNullOrWhiteSpace(txtConsultarPorCodFuncionario.Text))
                    {
                        MessageBox.Show("Insira o código do funcionário.");
                    }

                    else
                    {


                        int search_cod_funcionario = Convert.ToInt32(txtConsultarPorCodFuncionario.Text);
                        escolhido = BD.ConsultarFuncionario_Codigo(search_cod_funcionario);


                        if (escolhido == null)
                            MessageBox.Show("Funcionário não encontrado");

                        else
                        {
                            cbStatus.Text = escolhido.status;
                            mtxtDataAdmissaoRetornada.Text = Convert.ToString(escolhido.dt_admissao);
                            mtxtDataCadastroRetornada.Text = Convert.ToString(escolhido.dt_cadastro);
                            txtNomeRetornado.Text = escolhido.nome;
                            mtxtDataNascimentoRetornada.Text = Convert.ToString(escolhido.dt_nascimento);
                            mtxtCPFRetornado.Text = escolhido.cpf;
                            txtCargoRetornado.Text = escolhido.cargo;
                            cbTurnoRetornado.Text = escolhido.turno;
                            txtSalarioRetornado.Text = Convert.ToString(escolhido.salario);
                            mtxtTelefonePrincipalRetornado.Text = escolhido.tel_principal;
                            mtxtTelefoneReservaRetornado.Text = escolhido.tel_reserva;
                            txtEmailRetornado.Text = escolhido.email;
                            txtCidadeRetornada.Text = escolhido.cidade;
                            txtBairroRetornado.Text = escolhido.bairro;
                            mtxtCEPRetornado.Text = escolhido.cep;
                            txtRuaRetornada.Text = escolhido.rua;
                            txtNumeroRetornado.Text = Convert.ToString(escolhido.numero);
                            txtComplementoRetornado.Text = escolhido.complemento;
                            txtCodFuncionario.Text = Convert.ToString(escolhido.cod_funcionario);
                            mtxtDataDesligamento.Text = Convert.ToString(escolhido.dt_desligamento);
                            txtChaveAcessoRetornada.Text = escolhido.chave_acesso;


                            btnConsultarCadastro.Visible = false;
                            btnNovaConsulta.Visible = true;


                        }


                    }


                }


                BD.Desconecta();


            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }

        private void cbConsultarPorNome_SelectedIndexChanged(object sender, EventArgs e)
        {


            int element_cb = cbConsultarPorNome.SelectedIndex;
            escolhido = funcionarios[element_cb];

            cbStatus.Text = escolhido.status;
            mtxtDataAdmissaoRetornada.Text = Convert.ToString(escolhido.dt_admissao);
            mtxtDataCadastroRetornada.Text = Convert.ToString(escolhido.dt_cadastro);
            txtNomeRetornado.Text = escolhido.nome;
            mtxtDataNascimentoRetornada.Text = Convert.ToString(escolhido.dt_nascimento);
            mtxtCPFRetornado.Text = escolhido.cpf;
            txtCargoRetornado.Text = escolhido.cargo;
            cbTurnoRetornado.Text = escolhido.turno;
            txtSalarioRetornado.Text = Convert.ToString(escolhido.salario);
            mtxtTelefonePrincipalRetornado.Text = escolhido.tel_principal;
            mtxtTelefoneReservaRetornado.Text = escolhido.tel_reserva;
            txtEmailRetornado.Text = escolhido.email;
            txtCidadeRetornada.Text = escolhido.cidade;
            txtBairroRetornado.Text = escolhido.bairro;
            mtxtCEPRetornado.Text = escolhido.cep;
            txtRuaRetornada.Text = escolhido.rua;
            txtNumeroRetornado.Text = Convert.ToString(escolhido.numero);
            txtComplementoRetornado.Text = escolhido.complemento;
            txtCodFuncionario.Text = Convert.ToString(escolhido.cod_funcionario);

            mtxtDataDesligamento.Text = Convert.ToString(escolhido.dt_desligamento);
            txtChaveAcessoRetornada.Text = escolhido.chave_acesso;


        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {


            txtConsultarPorCodFuncionario.Text = string.Empty;
            cbConsultarPorNome.Items.Clear();
            cbConsultarPorNome.Text = string.Empty;

            btnConsultarCadastro.Visible = true;
            btnNovaConsulta.Visible = false;

            cbStatus.Text = string.Empty;
            mtxtDataAdmissaoRetornada.Text = string.Empty;
            mtxtDataCadastroRetornada.Text = string.Empty;
            txtNomeRetornado.Text = string.Empty;
            mtxtDataNascimentoRetornada.Text = string.Empty;
            mtxtCPFRetornado.Text = string.Empty;
            txtCargoRetornado.Text = string.Empty;
            cbTurnoRetornado.Text = string.Empty;
            txtSalarioRetornado.Text = string.Empty;
            mtxtTelefonePrincipalRetornado.Text = string.Empty;
            mtxtTelefoneReservaRetornado.Text = string.Empty;
            txtEmailRetornado.Text = string.Empty;
            txtCidadeRetornada.Text = string.Empty;
            txtBairroRetornado.Text = string.Empty;
            mtxtCEPRetornado.Text = string.Empty;
            txtRuaRetornada.Text = string.Empty;
            txtNumeroRetornado.Text = string.Empty;
            txtComplementoRetornado.Text = string.Empty;
            txtCodFuncionario.Text = string.Empty;
            mtxtDataDesligamento.Text = string.Empty;
            txtChaveAcessoRetornada.Text = string.Empty;

            escolhido = null;
            funcionarios.Clear();

            btnNovaConsulta.Visible = false;


        }


        //  Atualizar dados
        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {


            if (escolhido != null)
            {
                string novoNome = txtNomeRetornado.Text;
                string novoCPF = mtxtCPFRetornado.Text;

                string dt_nascimento_sem_formatacao = mtxtDataNascimentoRetornada.Text;
                DateTime novaDataNascimento = DateTime.Parse(dt_nascimento_sem_formatacao);

                string novoTelPrincipal = mtxtTelefonePrincipalRetornado.Text;
                string novoTelReserva = mtxtTelefoneReservaRetornado.Text;
                string novoEmail = txtEmailRetornado.Text;

                string novoStatus = cbStatus.Text;
                string novoCargo = txtCargoRetornado.Text;
                string novoTurno = cbTurnoRetornado.Text;
                decimal novoSalario = Convert.ToDecimal(txtSalarioRetornado.Text);
                string novaCidade = txtCidadeRetornada.Text;
                string novoBairro = txtBairroRetornado.Text;
                string novoCEP = mtxtCEPRetornado.Text;
                string novaRua = txtRuaRetornada.Text;
                int novoNumero = Convert.ToInt32(txtNumeroRetornado.Text);
                string novoComplemento = txtComplementoRetornado.Text;
                string novaChaveAcesso = txtChaveAcessoRetornada.Text;

                string dt_admissao_sem_formatacao = mtxtDataAdmissaoRetornada.Text;
                DateTime novaDataAdmissao = DateTime.Parse(dt_admissao_sem_formatacao);

                string dt_desligamento_sem_formatacao = mtxtDataDesligamento.Text;
                DateTime novaDataDesligamento = DateTime.Parse(dt_desligamento_sem_formatacao);


                if (BD.Conecta())
                {


                    //  Chave primária
                    escolhido.cod_funcionario = Convert.ToInt32(txtCodFuncionario.Text);


                    //  Atributos modificados
                    escolhido.nome = novoNome;
                    escolhido.cpf = novoCPF;
                    escolhido.dt_nascimento = novaDataNascimento;
                    escolhido.tel_principal = novoTelPrincipal;
                    escolhido.tel_reserva = novoTelReserva;
                    escolhido.email = novoEmail;
                    escolhido.status = novoStatus;
                    escolhido.cargo = novoCargo;
                    escolhido.turno = novoTurno;
                    escolhido.salario = novoSalario;
                    escolhido.cidade = novaCidade;
                    escolhido.bairro = novoBairro;
                    escolhido.cep = novoCEP;
                    escolhido.rua = novaRua;
                    escolhido.numero = novoNumero;
                    escolhido.complemento = novoComplemento;
                    escolhido.chave_acesso = novaChaveAcesso;
                    escolhido.dt_admissao = novaDataAdmissao;
                    escolhido.dt_desligamento = novaDataDesligamento;


                    if (BD.AtualizarDados_Funcionario(escolhido))
                    {


                        MessageBox.Show("Dados alterados!");


                        txtConsultarPorCodFuncionario.Text = string.Empty;
                        cbConsultarPorNome.Items.Clear();
                        cbConsultarPorNome.Text = string.Empty;

                        btnConsultarCadastro.Visible = true;
                        btnNovaConsulta.Visible = false;

                        cbStatus.Text = string.Empty;
                        mtxtDataAdmissaoRetornada.Text = string.Empty;
                        mtxtDataCadastroRetornada.Text = string.Empty;
                        txtNomeRetornado.Text = string.Empty;
                        mtxtDataNascimentoRetornada.Text = string.Empty;
                        mtxtCPFRetornado.Text = string.Empty;
                        txtCargoRetornado.Text = string.Empty;
                        cbTurnoRetornado.Text = string.Empty;
                        txtSalarioRetornado.Text = string.Empty;
                        mtxtTelefonePrincipalRetornado.Text = string.Empty;
                        mtxtTelefoneReservaRetornado.Text = string.Empty;
                        txtEmailRetornado.Text = string.Empty;
                        txtCidadeRetornada.Text = string.Empty;
                        txtBairroRetornado.Text = string.Empty;
                        mtxtCEPRetornado.Text = string.Empty;
                        txtRuaRetornada.Text = string.Empty;
                        txtNumeroRetornado.Text = string.Empty;
                        txtComplementoRetornado.Text = string.Empty;
                        txtCodFuncionario.Text = string.Empty;
                        mtxtDataDesligamento.Text = string.Empty;
                        txtChaveAcessoRetornada.Text = string.Empty;

                        escolhido = null;
                        funcionarios.Clear();


                    }

                    else
                        MessageBox.Show("Erro de alteração.");


                    BD.Desconecta();


                }

                else
                    MessageBox.Show("Não foi possível conectar o servidor.");


            }


            else
                MessageBox.Show("Consulte um registro primeiro");


        }

        //  Deletar cadastro
        private void btnDeletarCaadastro_Click(object sender, EventArgs e)
        {


            if (BD.Conecta())
            {


                if (escolhido != null)
                {


                    if (BD.DeletarCadastro_Funcionario(escolhido))
                    {


                        MessageBox.Show("Dados excluídos!");


                        txtConsultarPorCodFuncionario.Text = string.Empty;
                        cbConsultarPorNome.Items.Clear();
                        cbConsultarPorNome.Text = string.Empty;

                        btnConsultarCadastro.Visible = true;
                        btnNovaConsulta.Visible = false;

                        cbStatus.Text = string.Empty;
                        mtxtDataAdmissaoRetornada.Text = string.Empty;
                        mtxtDataCadastroRetornada.Text = string.Empty;
                        txtNomeRetornado.Text = string.Empty;
                        mtxtDataNascimentoRetornada.Text = string.Empty;
                        mtxtCPFRetornado.Text = string.Empty;
                        txtCargoRetornado.Text = string.Empty;
                        cbTurnoRetornado.Text = string.Empty;
                        txtSalarioRetornado.Text = string.Empty;
                        mtxtTelefonePrincipalRetornado.Text = string.Empty;
                        mtxtTelefoneReservaRetornado.Text = string.Empty;
                        txtEmailRetornado.Text = string.Empty;
                        txtCidadeRetornada.Text = string.Empty;
                        txtBairroRetornado.Text = string.Empty;
                        mtxtCEPRetornado.Text = string.Empty;
                        txtRuaRetornada.Text = string.Empty;
                        txtNumeroRetornado.Text = string.Empty;
                        txtComplementoRetornado.Text = string.Empty;
                        txtCodFuncionario.Text = string.Empty;
                        mtxtDataDesligamento.Text = string.Empty;
                        txtChaveAcessoRetornada.Text = string.Empty;

                        escolhido = null;
                        funcionarios.Clear();


                    }

                    else
                        MessageBox.Show("Erro de exclusão.");


                }

                else
                    MessageBox.Show("Consulte um registro primeiro");


                BD.Desconecta();


            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtConsultarPorCodFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNumeroRetornado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
