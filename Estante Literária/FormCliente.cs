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
    public partial class FormCliente : Form
    {


        public FormCliente()
        {


            InitializeComponent();


            //  Botão btnNovaConsulta inicialmente invisível
            btnNovaConsulta.Visible = false;

            //  Um dos radio buttons sempre será selecionado!
            rbConsultarCodCliente.Checked = true;


        }


        //  Variáveis
        string nome;
        string cpf;
        string dt_nascimento_sem_formatacao;
        string tel_principal;
        string tel_reserva;
        string email;
        int cod_cliente;
        List<Cliente> clientes = new List<Cliente>();
        Cliente escolhido;


        //  Se ligando ao banco de dados
        BancoDeDados BD = new BancoDeDados();


        //  Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            
            //  Criando um código para o novo cadastro
            string numeros = "123456789";
            string cod_gerado = "";

            Random random = new Random();
            for (int f = 0; f < 8; f++)
            {
                cod_gerado = cod_gerado + numeros.Substring(random.Next(0, numeros.Length - 1), 1);
            }


            //  Definindo dados
            nome = txtNome.Text;
            cpf = mtxtCPF.Text;

            dt_nascimento_sem_formatacao = mtxtDataNascimento.Text;
            DateTime dt_nascimento = DateTime.Parse(dt_nascimento_sem_formatacao);

            DateTime dt_cadastro = DateTime.Now;
            tel_principal = mtxtTelefonePrincipal.Text;
            tel_reserva = mtxtTelefoneReserva.Text;
            email = txtEmail.Text;
            cod_cliente = Convert.ToInt32(cod_gerado);


            //  Instanciando a classe Cliente
            Cliente novoCliente = new Cliente(nome, cpf, dt_cadastro, dt_nascimento, tel_principal, tel_reserva, email, cod_cliente);


            //  Cadastrando o novo cliente
            if (BD.Conecta())
            {


                if (BD.CadastrarCliente(novoCliente))
                {


                    MessageBox.Show("Cliente cadastrado com sucesso");


                    txtNome.Text = string.Empty;
                    mtxtCPF.Text = string.Empty;
                    mtxtDataNascimento.Text = string.Empty;
                    mtxtTelefonePrincipal.Text = string.Empty;
                    mtxtTelefoneReserva.Text = string.Empty;
                    txtEmail.Text = string.Empty;


                }

                else
                    MessageBox.Show("O cliente já possui cadastro");


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
                        MessageBox.Show("Insira o nome do cliente");
                    }

                    else
                    {


                        cbConsultarPorNome.Items.Clear();

                        string parteNome = cbConsultarPorNome.Text;
                        clientes = BD.ConsultarCliente_Nome(parteNome);


                        for (int i = 0; i < clientes.Count; i++)
                        {
                            cbConsultarPorNome.Items.Add(clientes[i].nome);
                        }


                        btnConsultarCadastro.Visible = false;
                        btnNovaConsulta.Visible = true;


                    }


                }

                else
                {


                    if (string.IsNullOrWhiteSpace(txtConsultarPorCodCliente.Text))
                    {
                        MessageBox.Show("Insira o código do cliente.");
                    }


                    else
                    {


                        int search_cod_cliente = Convert.ToInt32(txtConsultarPorCodCliente.Text);
                        escolhido = BD.ConsultarCliente_Codigo(search_cod_cliente);


                        if (escolhido == null)
                            MessageBox.Show("Cliente não encontrado");

                        else
                        {


                            txtNomeRetornado.Text = escolhido.nome;
                            mtxtCPFRetornado.Text = escolhido.cpf;
                            mtxtDataCadastroRetornada.Text = Convert.ToString(escolhido.dt_cadastro);
                            mtxtDataNascimentoRetornada.Text = Convert.ToString(escolhido.dt_nascimento);
                            mtxtTelefonePrincipalRetornado.Text = escolhido.tel_principal;
                            mtxtTelefoneReservaRetornado.Text = escolhido.tel_reserva;
                            txtEmailRetornado.Text = escolhido.email;
                            txtCodCliente.Text = Convert.ToString(escolhido.cod_cliente);

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
            escolhido = clientes[element_cb];
            txtNomeRetornado.Text = escolhido.nome;
            mtxtCPFRetornado.Text = escolhido.cpf;
            mtxtDataCadastroRetornada.Text = Convert.ToString(escolhido.dt_cadastro);
            mtxtDataNascimentoRetornada.Text = Convert.ToString(escolhido.dt_nascimento);
            mtxtTelefonePrincipalRetornado.Text = escolhido.tel_principal;
            mtxtTelefoneReservaRetornado.Text = escolhido.tel_reserva;
            txtEmailRetornado.Text = escolhido.email;
            txtCodCliente.Text = Convert.ToString(escolhido.cod_cliente);


        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {


            txtConsultarPorCodCliente.Text = string.Empty;
            cbConsultarPorNome.Items.Clear();
            cbConsultarPorNome.Text = string.Empty;

            btnConsultarCadastro.Visible = true;
            btnNovaConsulta.Visible = false;

            txtNomeRetornado.Text = string.Empty;
            mtxtCPFRetornado.Text = string.Empty;
            mtxtDataCadastroRetornada.Text = string.Empty;
            mtxtDataNascimentoRetornada.Text = string.Empty;
            mtxtTelefonePrincipalRetornado.Text = string.Empty;
            mtxtTelefoneReservaRetornado.Text = string.Empty;
            txtEmailRetornado.Text = string.Empty;
            txtCodCliente.Text = string.Empty;


        }


        //  Atualizar dados
        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {


            string novoNome = txtNomeRetornado.Text;
            string novoCPF = mtxtCPFRetornado.Text;

            string dt_nascimento_sem_formatacao = mtxtDataNascimentoRetornada.Text;
            DateTime novaDataNascimento = DateTime.Parse(dt_nascimento_sem_formatacao);

            string novoTelPrincipal = mtxtTelefonePrincipalRetornado.Text;
            string novoTelReserva = mtxtTelefoneReservaRetornado.Text;
            string novoEmail = txtEmailRetornado.Text;


            if (BD.Conecta())
            {


                //  Chave primária
                escolhido.cod_cliente = Convert.ToInt32(txtCodCliente.Text);



                //  Atributos modificados
                escolhido.nome = novoNome;
                escolhido.cpf = novoCPF;
                escolhido.dt_nascimento = novaDataNascimento;
                escolhido.tel_principal = novoTelPrincipal;
                escolhido.tel_reserva = novoTelReserva;
                escolhido.email = novoEmail;


                if (BD.AtualizarDados_Cliente(escolhido))
                    MessageBox.Show("Dados alterados!");

                else
                    MessageBox.Show("Erro de alteração.");


                BD.Desconecta();


            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }


        //  Apagar cadastro
        private void btnDeletarCaadastro_Click(object sender, EventArgs e)
        {


            if (BD.Conecta())
            {


                if (BD.DeletarCadastro_Cliente(escolhido))
                {


                    MessageBox.Show("Dados excluídos!");


                    txtConsultarPorCodCliente.Text = string.Empty;
                    cbConsultarPorNome.Items.Clear();
                    cbConsultarPorNome.Text = string.Empty;

                    btnConsultarCadastro.Visible = true;
                    btnNovaConsulta.Visible = false;

                    txtNomeRetornado.Text = string.Empty;
                    mtxtCPFRetornado.Text = string.Empty;
                    mtxtDataCadastroRetornada.Text = string.Empty;
                    mtxtDataNascimentoRetornada.Text = string.Empty;
                    mtxtTelefonePrincipalRetornado.Text = string.Empty;
                    mtxtTelefoneReservaRetornado.Text = string.Empty;
                    txtEmailRetornado.Text = string.Empty;
                    txtCodCliente.Text = string.Empty;


                }

                else
                    MessageBox.Show("Erro de exclusão.");


                BD.Desconecta();


            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }

        private void txtConsultarPorCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
