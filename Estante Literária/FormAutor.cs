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
    public partial class FormAutor : Form
    {


        public FormAutor()
        {


            InitializeComponent();


            //  Botão btnNovaConsulta inicialmente invisível
            btnNovaConsulta.Visible = false;

            //  Um dos radio buttons sempre será selecionado!
            rbConsultarCodAutor.Checked = true;


        }


        //  Variáveis
        string nome;
        string dt_nascimento_sem_formatacao;
        string descricao;
        int cod_autor;
        List<Autor> autores = new List<Autor>();
        Autor escolhido;


        //  Se ligando ao banco de dados
        BancoDeDados BD = new BancoDeDados();


        //  Cadastrando novo autor
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

            dt_nascimento_sem_formatacao = mtxtDataNascimento.Text;
            DateTime dt_nascimento = DateTime.Parse(dt_nascimento_sem_formatacao);

            DateTime dt_cadastro = DateTime.Now;
            descricao = txtDescricao.Text;
            cod_autor = Convert.ToInt32(cod_gerado);


            //  Instanciando a classe Autor
            Autor novoAutor = new Autor(cod_autor, nome, dt_nascimento, descricao, dt_cadastro);


            //  Cadastrando o novo autor
            if (BD.Conecta())
            {


                if (BD.CadastrarAutor(novoAutor))
                {


                    MessageBox.Show("Autor cadastrado com sucesso");


                    txtNome.Text = string.Empty;
                    mtxtDataNascimento.Text = string.Empty;
                    txtDescricao.Text = string.Empty;


                }

                else
                    MessageBox.Show("O autor já possui cadastro");


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


                        MessageBox.Show("Insira o nome do autor");
                    
                    
                    }

                    else
                    {


                        cbConsultarPorNome.Items.Clear();


                        string parteNome = cbConsultarPorNome.Text;
                        autores = BD.ConsultarAutor_Nome(parteNome);


                        for (int i = 0; i < autores.Count; i++)
                        {
                            cbConsultarPorNome.Items.Add(autores[i].nome);
                        }


                        btnConsultarCadastro.Visible = false;
                        btnNovaConsulta.Visible = true;


                    }


                }

                else
                {


                    if (string.IsNullOrWhiteSpace(txtConsultarPorCodAutor.Text))
                    {
                        MessageBox.Show("Insira o código do autor.");
                    }

                    else
                    {


                        int search_cod_autor = Convert.ToInt32(txtConsultarPorCodAutor.Text);
                        escolhido = BD.ConsultarAutor_Codigo(search_cod_autor);


                        if (escolhido == null)
                            MessageBox.Show("Autor não encontrado");

                        else
                        {


                            txtCodAutor.Text = Convert.ToString(escolhido.cod_autor);
                            txtNomeRetornado.Text = escolhido.nome;
                            mtxtDataNascimentoRetornada.Text = Convert.ToString(escolhido.dt_nascimento);
                            txtDescricaoRetornada.Text = escolhido.descricao;
                            mtxtDataCadastroRetornada.Text = Convert.ToString(escolhido.dt_cadastro);

                            btnConsultarCadastro.Visible = false;
                            btnNovaConsulta.Visible = true;


                        }


                    }


                }


                BD.Desconecta();


            }


        }

        private void cbConsultarPorNome_SelectedIndexChanged(object sender, EventArgs e)
        {


            int element_cb = cbConsultarPorNome.SelectedIndex;
            escolhido = autores[element_cb];
            txtCodAutor.Text = Convert.ToString(escolhido.cod_autor);
            txtNomeRetornado.Text = escolhido.nome;
            mtxtDataNascimentoRetornada.Text = Convert.ToString(escolhido.dt_nascimento);
            txtDescricaoRetornada.Text = escolhido.descricao;
            mtxtDataCadastroRetornada.Text = Convert.ToString(escolhido.dt_cadastro);


        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {


            txtConsultarPorCodAutor.Text = string.Empty;
            cbConsultarPorNome.Items.Clear();
            cbConsultarPorNome.Text = string.Empty;


            btnConsultarCadastro.Visible = true;
            btnNovaConsulta.Visible = false;


            txtCodAutor.Text = string.Empty;
            txtNomeRetornado.Text = string.Empty;
            mtxtDataNascimentoRetornada.Text = string.Empty;
            txtDescricaoRetornada.Text = string.Empty;
            mtxtDataCadastroRetornada.Text = string.Empty;


        }


        //  Atualizar dados
        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {


            string novoNome = txtNomeRetornado.Text;

            string dt_nascimento_sem_formatacao = mtxtDataNascimentoRetornada.Text;
            DateTime novaDataNascimento = DateTime.Parse(dt_nascimento_sem_formatacao);

            string novaDescricao = txtDescricaoRetornada.Text;


            if (BD.Conecta())
            {


                //  Chave primária
                escolhido.cod_autor = Convert.ToInt32(txtCodAutor.Text);


                //  Atributos modificados
                escolhido.nome = novoNome;
                escolhido.dt_nascimento = novaDataNascimento;
                escolhido.descricao = novaDescricao;


                if (BD.AtualizarDados_Autor(escolhido))
                    MessageBox.Show("Dados alterados!");

                else
                    MessageBox.Show("Erro de alteração.");


                BD.Desconecta();


            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }


        //  Deletar cadastro
        private void btnDeletarCadastro_Click(object sender, EventArgs e)
        {


            if (BD.Conecta())
            {


                if (BD.DeletarCadastro_Autor(escolhido))
                {


                    MessageBox.Show("Dados excluídos!");


                    txtConsultarPorCodAutor.Text = string.Empty;
                    cbConsultarPorNome.Items.Clear();
                    cbConsultarPorNome.Text = string.Empty;

                    btnConsultarCadastro.Visible = true;
                    btnNovaConsulta.Visible = false;

                    txtCodAutor.Text = string.Empty;
                    txtNomeRetornado.Text = string.Empty;
                    mtxtDataNascimentoRetornada.Text = string.Empty;
                    txtDescricaoRetornada.Text = string.Empty;
                    mtxtDataCadastroRetornada.Text = string.Empty;


                }

                else
                    MessageBox.Show("Erro de exclusão.");


                BD.Desconecta();


            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }


        private void txtConsultarPorCodAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
