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
    public partial class FormInicial : Form
    {


        //  Foco no txtCodFuncionario
        private void FormInicial_Load(object sender, EventArgs e)
        {


            txtCodFuncionario.Focus();
            txtCodFuncionario.Select();


        }


        //  Apenas números no txtCodFuncionario
        private void txtCodFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) 
            {
                e.Handled = true; 
            }


        }


        public FormInicial()
        {


            InitializeComponent();


            //  Botões invisíveis
            panelLateralEsquerda.Visible = false;
            btnVendas.Visible = false;
            btnClientes.Visible = false;
            btnLivros.Visible = false;
            btnAutores.Visible = false;
            btnFuncionarios.Visible = false;
            panelLateralDireita.Visible = false;


        }


        //  Controlar formulários - método
        private void OpenForm<Forms>() where Forms : Form, new()
        {


            Form controle;
            controle = panelPrincipal.Controls.OfType<Forms>().FirstOrDefault();


            if (controle == null)
            {


                controle = new Forms();
                controle.TopLevel = false;
                panelPrincipal.Controls.Add(controle);
                panelPrincipal.Tag = controle;
                controle.Show();
                controle.BringToFront();


            }

            else
            {


                if (controle.WindowState == FormWindowState.Minimized)
                    controle.WindowState = FormWindowState.Normal;
                    controle.BringToFront();


            }


        }


        //  Se ligando ao banco de dados
        BancoDeDados BD = new BancoDeDados();


        //  Variável de login
        ValidarLogin validar;


        //  Validar de login
        private void btnEntrar_Click(object sender, EventArgs e)
        {


            //  Caixas de texto estão preenchidas?
            if (txtCodFuncionario.Text != string.Empty && txtChaveAcesso.Text != string.Empty)
            {


                int cod_funcionario = Convert.ToInt32(txtCodFuncionario.Text);
                string chave_acesso = txtChaveAcesso.Text;

                int validar_cod_funcionario = cod_funcionario;
                string validar_chave_acesso = chave_acesso;

                
                if (BD.Conecta())
                {


                    //  Instanciando a classe ValidarLogin
                    validar = BD.ValidarLogin(validar_cod_funcionario, validar_chave_acesso);


                    if (validar == null)
                    {


                        string title = "Dados inválidos";
                        string message = "Dados inseridos incorretamente ou inexistentes";
                        MessageBox.Show(message, title);


                    }

                    else
                    {


                        panelFazerLogin.Visible = false;
                        lblFazerLogin.Visible = false;
                        lblCodFuncionario.Visible = false;
                        lblChaveAcesso.Visible = false;
                        txtCodFuncionario.Visible = false;
                        txtChaveAcesso.Visible = false;
                        btnEntrar.Visible = false;

                        panelLateralEsquerda.Visible = true;
                        btnVendas.Visible = true;
                        btnClientes.Visible = true;
                        btnLivros.Visible = true;
                        btnAutores.Visible = true;
                        btnFuncionarios.Visible = true;
                        panelLateralDireita.Visible = true;


                        OpenForm<FormVenda>();


                    }


                }

                else
                {


                    string title = "Erro de conexão";
                    string message = "Não foi possível se conectar ao banco de dados";
                    MessageBox.Show(message, title);


                }


            }

            else
            {


                string title = "Campo em branco";
                string message = "Preencha todos os campos de texto";
                MessageBox.Show(message, title);


            }


        }


        //  Controlar formulários - execução
        private void btnVendas_Click(object sender, EventArgs e)
        {
            OpenForm<FormVenda>();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenForm<FormCliente>();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            OpenForm<FormAutor>();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            OpenForm<FormLivro>();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {


            if (validar.cargo != "GERENTE")
                OpenForm<FormFuncionario>();

            else
            {


                string title = "Área restrita";
                string message = "Você não pode acessar essa seção.";
                MessageBox.Show(message, title);


            }
                

        }
    }
}
