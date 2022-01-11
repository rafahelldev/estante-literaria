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
    public partial class FormLivro : Form
    {


        private void txtCodAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        public FormLivro()
        {


            InitializeComponent();


            //  Escondendo parte 2 e botões
            lblInserirParte02.Visible = false;
            lblCodAutor.Visible = false;
            txtCodAutor.Text = string.Empty;
            btnInserirParte02.Visible = false;

            dgvListaDeAutoresInseridos.Rows.Clear();
            dgvListaDeAutoresInseridos.Visible = false;

            panelParte2.Visible = false;

            btnCadastrar.Visible = false;
            btnCancelarCadastro.Visible = false;


            //  Botão btnNovaConsulta inicialmente invisível
            btnNovaConsulta.Visible = false;
            btnAtualizarDados.Visible = false;
            btnDeletarCadastro.Visible = false;

            lblInserirOuExcluirCodAutor.Visible = false;
            txtInserirOuExcluirCodAutor.Visible = false;
            btnInserirNovoAutor.Visible = false;
            btnRemoverAutorInserido.Visible = false;

            //  Um dos radio buttons sempre será selecionado!
            rbConsultarCodLivro.Checked = true;


        }


        //  Variáveis - Cadastro
        string titulo;
        int ano_publicacao;
        string editora;
        string descricao;
        decimal valor_livro;
        int cod_livro;
        int cod_autorlivro;

        int search_cod_autor;
        Livro livro;
        AutorLivro autorlivro;
        List<AutorLivro> autoreslivro = new List<AutorLivro>();
        Autor autor;


        //  Variáveis - Consulta e outras operações
        Livro escolhido;
        List<Livro> livros = new List<Livro>();
        List<AutorLivro> autoreslivro_encontrados = new List<AutorLivro>();
        int cod_autor;
        Autor autor_consultaeoutrasop;
        List<Autor> autores_encontrados = new List<Autor>();
        AutorLivro autorlivro_inseriroudeletar;
        List<AutorLivro> autores_novos = new List<AutorLivro>();
        List<AutorLivro> autores_para_deletar = new List<AutorLivro>();


        //  Se conectando ao banco de dados
        BancoDeDados BD = new BancoDeDados();


        //  Inserindo os dados da primeiro parte
        private void btnInserirParte01_Click(object sender, EventArgs e)
        {


            //  Há um cadastro em andamento?
            if (livro == null)
            {


                //  Criando um código para o novo cadastro
                string numeros1 = "123456789";
                string cod_livro_gerado = "";

                Random random1 = new Random();
                for (int f = 0; f < 8; f++)
                {
                    cod_livro_gerado = cod_livro_gerado + numeros1.Substring(random1.Next(0, numeros1.Length - 1), 1);
                }


                //  Definindo dados
                titulo = txtTitulo.Text;
                ano_publicacao = Convert.ToInt32(mtxtAnoPublicacao.Text);
                editora = txtEditora.Text;
                descricao = txtDescricao.Text;
                valor_livro = Convert.ToDecimal(txtValorLivro.Text);

                cod_livro = Convert.ToInt32(cod_livro_gerado);
                DateTime dt_cadastro = DateTime.Now;


                //  Instanciando a classe Livro
                livro = new Livro(cod_livro, titulo, ano_publicacao, editora, descricao, dt_cadastro, valor_livro);


                //  Mostrando parte 2 e botões
                lblInserirParte02.Visible = true;
                lblCodAutor.Visible = true;
                txtCodAutor.Text = string.Empty;
                btnInserirParte02.Visible = true;

                dgvListaDeAutoresInseridos.Rows.Clear();
                dgvListaDeAutoresInseridos.Visible = true;

                panelParte2.Visible = true;

                btnCadastrar.Visible = true;
                btnCancelarCadastro.Visible = true;

            }

            else
                MessageBox.Show("Há um cadastro em andamento");


        }


        //  Inserindo os códigos dos autores
        private void btnInserirParte02_Click(object sender, EventArgs e)
        {


            //  A caixa de código está preenchida?
            if (txtCodAutor.Text != string.Empty)
            {


                search_cod_autor = Convert.ToInt32(txtCodAutor.Text);
                int verificandoexistenciadodado = 0;


                //  Verificando se o autor já foi inserido
                for (int i = 0; i < autoreslivro.Count; i++)
                {


                    if (autoreslivro[i].cod_autor == search_cod_autor)
                        verificandoexistenciadodado += 1;


                }


                //  Se é um novo autor sendo inserido, então o if será rodado
                if (verificandoexistenciadodado == 0)
                {


                    if (BD.Conecta())
                    {


                        //  Verificando se o autor existe
                        autor = BD.ConsultarAutor_Codigo(search_cod_autor);


                        if (autor != null)
                        {


                            //  Criando um código para o novo cadastro
                            string numeros2 = "123456789";
                            string cod_autorlivro_gerado = "";

                            Random random2 = new Random();
                            for (int f = 0; f < 8; f++)
                            {
                                cod_autorlivro_gerado = cod_autorlivro_gerado + numeros2.Substring(random2.Next(0, numeros2.Length - 1), 1);
                            }


                            cod_autorlivro = Convert.ToInt32(cod_autorlivro_gerado);


                            //  Instanciando a classe AutorLivro
                            autorlivro = new AutorLivro(cod_autorlivro, autor.cod_autor, livro.cod_livro);
                            autoreslivro.Add(autorlivro);


                            //  Adicionando o novo item ao datagridview
                            string[] linha_item = { titulo, Convert.ToString(cod_livro), autor.nome,
                            Convert.ToString(autor.cod_autor) };

                            dgvListaDeAutoresInseridos.Rows.Add(linha_item);


                            MessageBox.Show("Autor inserido com sucesso!");


                        }

                        else
                            MessageBox.Show("Autor não encontrado. Por favor, verifique o código inserido");


                        BD.Desconecta();


                    }

                    else
                        MessageBox.Show("Não foi possível conectar o servidor.");


                }

                else
                    MessageBox.Show("Esse autor já foi inserido");

            }

            else
                MessageBox.Show("Informe o código do autor");


        }

        //  Retirando o código de cadastro de um autor
        private void btnRemoverAutor_Click(object sender, EventArgs e)
        {


            //  A caixa de código está preenchida?
            if (txtCodAutor.Text != string.Empty)
            {


                int verificandoexistenciadodado = 0;


                for (int i = 0; i < autoreslivro.Count; i++)
                {


                    if (autoreslivro[i].cod_autor == search_cod_autor)
                    {


                        //  Cancelando autorlivro desejado
                        autoreslivro[i].cod_autorlivro = 0;
                        autoreslivro[i].cod_autor = 0;


                        verificandoexistenciadodado += 1;


                    }


                }


                if (verificandoexistenciadodado != 0)
                    MessageBox.Show("Autor removido do cadastro. Atenção: os dados do autor ainda constarão na tabela");

                else
                    MessageBox.Show("O autor não foi inserido neste cadastro. Por favor, verifique o código apresentado");


            }

            else
                MessageBox.Show("Insira o código do autor");


        }


        //  Finalizar venda registrando todos os dados armazenados!
        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            //  O usuário deseja finalizar o cadastro?
            DialogResult finalizarcadastro = MessageBox.Show("Deseja finalizar o cadastro?",
               "Sim", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button2);


            if (finalizarcadastro.ToString().ToUpper() == "YES")
            {


                //  Verificando se há dados armazenados 
                if (autor != null && autoreslivro != null)
                {


                    if (BD.Conecta())
                    {


                        //  Cadastrando dados da primeira parte
                        if (BD.CadastrarLivro(livro))
                        {


                            //  Registrando a lista de autores
                            for (int i = 0; i < autoreslivro.Count; i++)
                            {


                                if (autoreslivro[i].cod_autorlivro != 0)
                                {


                                    if (BD.CadastrarAutorLivro(autoreslivro[i])) ;

                                    else
                                        MessageBox.Show("Erro de registro");


                                }


                            }


                            //  Se preparando para a próxima venda
                            titulo = string.Empty;
                            ano_publicacao = 0;
                            editora = string.Empty;
                            descricao = string.Empty;
                            valor_livro = 0;

                            cod_livro = 0;

                            search_cod_autor = 0;
                            cod_autorlivro = 0;
                            livro = null;
                            autor = null;
                            autorlivro = null;
                            autoreslivro.Clear();

                            txtTitulo.Text = string.Empty;
                            mtxtAnoPublicacao.Text = string.Empty;
                            txtEditora.Text = string.Empty;
                            txtDescricao.Text = string.Empty;
                            txtValorLivro.Text = string.Empty;


                            //  Escondendo parte 2 e botões
                            lblInserirParte02.Visible = false;
                            lblCodAutor.Visible = false;
                            txtCodAutor.Text = string.Empty;
                            btnInserirParte02.Visible = false;

                            dgvListaDeAutoresInseridos.Rows.Clear();
                            dgvListaDeAutoresInseridos.Visible = false;

                            panelParte2.Visible = false;

                            btnCadastrar.Visible = false;
                            btnCancelarCadastro.Visible = false;


                            //  Mensagem bonita :)
                            string title = "Livro cadastrado";
                            string message = "O livro foi cadastrado com sucesso";
                            MessageBox.Show(message, title);


                        }

                        else
                            MessageBox.Show("Erro de registro");


                        BD.Desconecta();


                    }

                    else
                    {


                        string title = "Erro de conexão";
                        string message = "Não foi possível se conectar ao banco de dados";
                        MessageBox.Show(message, title);


                    }


                }

                else
                    MessageBox.Show("Não há nenhum dado armazenado");


            }


        }


        //  Cancelar cadastro
        private void btnCancelarCaadastro_Click(object sender, EventArgs e)
        {


            //  O usuário deseja RECOMEÇAR DO ZERO?
            DialogResult cancelarcadastro = MessageBox.Show("Deseja cancelar o cadastro?",
               "Sim", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button2);


            if (cancelarcadastro.ToString().ToUpper() == "YES")
            {


                string title = "Cadastro cancelado";
                string message = "O cadastro foi cancelado com sucesso.";
                MessageBox.Show(message, title);


                //  Se preparando para a próxima venda
                titulo = string.Empty;
                ano_publicacao = 0;
                editora = string.Empty;
                descricao = string.Empty;
                valor_livro = 0;

                cod_livro = 0;

                search_cod_autor = 0;
                cod_autorlivro = 0;
                livro = null;
                autor = null;
                autorlivro = null;
                autoreslivro.Clear();

                txtTitulo.Text = string.Empty;
                mtxtAnoPublicacao.Text = string.Empty;
                txtEditora.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtValorLivro.Text = string.Empty;


                //  Escondendo parte 2 e botões
                lblInserirParte02.Visible = false;
                lblCodAutor.Visible = false;
                txtCodAutor.Text = string.Empty;
                btnInserirParte02.Visible = false;

                dgvListaDeAutoresInseridos.Rows.Clear();
                dgvListaDeAutoresInseridos.Visible = false;

                panelParte2.Visible = false;

                btnCadastrar.Visible = false;
                btnCancelarCadastro.Visible = false;


            }


        }


        //  Consultar dados de venda
        private void btnConsultarCadastro_Click(object sender, EventArgs e)
        {


            if (BD.Conecta())
            {


                if (rbConsultarTitulo.Checked)
                {


                    if (string.IsNullOrWhiteSpace(cbConsultarPorTitulo.Text))
                    {


                        MessageBox.Show("Insira o título da obra");


                    }

                    else
                    {


                        cbConsultarPorTitulo.Items.Clear();


                        string parteTitulo = cbConsultarPorTitulo.Text;
                        livros = BD.ConsultarLivro_Titulo(parteTitulo);


                        for (int i = 0; i < livros.Count; i++)
                        {
                            cbConsultarPorTitulo.Items.Add(livros[i].titulo);
                        }


                        btnConsultarCadastro.Visible = false;


                    }


                }

                else
                {


                    if (string.IsNullOrWhiteSpace(txtConsultarPorCodigo.Text))
                    {


                        MessageBox.Show("Insira o código do livro.");


                    }

                    else
                    {


                        int search_cod_livro = Convert.ToInt32(txtConsultarPorCodigo.Text);
                        escolhido = BD.ConsultarLivro_Codigo(search_cod_livro);


                        if (escolhido == null)
                            MessageBox.Show("Livro não encontrado");

                        else
                        {


                            txtCodLivro.Text = Convert.ToString(escolhido.cod_livro);
                            txtTituloRetornado.Text = escolhido.titulo;
                            mtxtAnoPublicacaoRetornada.Text = Convert.ToString(escolhido.ano_publicacao);
                            txtEditoraRetornada.Text = escolhido.editora;
                            txtDescricaoRetornada.Text = escolhido.descricao;
                            txtValorLivroRetornado.Text = Convert.ToString(escolhido.valor_livro);
                            mtxtDataCadastroRetornada.Text = Convert.ToString(escolhido.dt_cadastro);

                            btnConsultarCadastro.Visible = false;


                            ProcurarCodigos();


                        }


                    }


                }


                BD.Desconecta();


            }


        }

        private void cbConsultarPorTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {


            lblCodAutor.Visible = true;
            txtCodAutor.Visible = true;
            btnInserirNovoAutor.Visible = true;
            btnRemoverAutorInserido.Visible = true;


            dgvAutoresLivro.Rows.Clear();


            int element_cb = cbConsultarPorTitulo.SelectedIndex;
            escolhido = livros[element_cb];

            txtCodLivro.Text = Convert.ToString(escolhido.cod_livro);
            txtTituloRetornado.Text = escolhido.titulo;
            mtxtAnoPublicacaoRetornada.Text = Convert.ToString(escolhido.ano_publicacao);
            txtEditoraRetornada.Text = escolhido.editora;
            txtDescricaoRetornada.Text = escolhido.descricao;
            mtxtDataCadastroRetornada.Text = Convert.ToString(escolhido.dt_cadastro);
            txtValorLivroRetornado.Text = Convert.ToString(escolhido.valor_livro);


            ProcurarCodigos();


        }

        private void ProcurarCodigos()
        {


            if (BD.Conecta())
            {


                autoreslivro_encontrados = BD.ProcurarAutoresLivro_Codigo(escolhido.cod_livro);


                if (autoreslivro_encontrados != null)
                {


                    for (int i = 0; i < autoreslivro_encontrados.Count; i++)
                    {


                        cod_autor = autoreslivro_encontrados[i].cod_autor;
                        ProcurarAutores();


                    }


                    lblCodAutor.Visible = true;
                    txtCodAutor.Visible = true;
                    btnInserirNovoAutor.Visible = true;
                    btnRemoverAutorInserido.Visible = true;


                }

                else
                    MessageBox.Show("O livro não possui registro de autor. Por favor, atualize os dados do livro inserido de forma manual, no banco de dados");


                BD.Desconecta();


            }

            else
            {


                string title = "Erro de conexão";
                string message = "Não foi possível se conectar ao banco de dados";
                MessageBox.Show(message, title);


            }


        }

        private void ProcurarAutores()
        {

            
            if (BD.Conecta())
            {


                autor_consultaeoutrasop = null;


                autor_consultaeoutrasop = BD.ProcurarAutores_Nome(cod_autor);


                if (autor_consultaeoutrasop != null)
                {


                    autores_encontrados.Add(autor_consultaeoutrasop);


                    //  Adicionando o novo item ao datagridview
                    string[] linha_item = { autor_consultaeoutrasop.nome, Convert.ToString(autor_consultaeoutrasop.cod_autor) };

                    dgvAutoresLivro.Rows.Add(linha_item);


                    //  Botão btnNovaConsulta ficam visíveis
                    btnNovaConsulta.Visible = true;
                    btnAtualizarDados.Visible = true;
                    btnDeletarCadastro.Visible = true;

                }


                BD.Desconecta();


            }

            else
            {


                string title = "Erro de conexão";
                string message = "Não foi possível se conectar ao banco de dados";
                MessageBox.Show(message, title);


            }


        }

        
        //  Zerando dados
        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {


            //  Botão btnNovaConsulta voltam ao invisível
            btnNovaConsulta.Visible = false;
            btnAtualizarDados.Visible = false;
            btnDeletarCadastro.Visible = false;

            lblCodAutor.Visible = false;
            txtCodAutor.Visible = false;
            btnInserirNovoAutor.Visible = false;
            btnRemoverAutorInserido.Visible = false;


            //  Nova consulta já disponível
            btnConsultarCadastro.Visible = true;


            txtCodLivro.Text = string.Empty;
            txtTituloRetornado.Text = string.Empty;
            mtxtAnoPublicacaoRetornada.Text = string.Empty;
            txtEditoraRetornada.Text = string.Empty;
            txtDescricaoRetornada.Text = string.Empty;
            mtxtDataCadastroRetornada.Text = string.Empty;
            txtValorLivroRetornado.Text = string.Empty;


            txtConsultarPorCodigo.Text = string.Empty;
            cbConsultarPorTitulo.Items.Clear();


            escolhido = null;
            livros.Clear();
            autoreslivro_encontrados.Clear();
            cod_autor = 0;
            autor_consultaeoutrasop = null;
            autores_encontrados.Clear();


            dgvAutoresLivro.Rows.Clear();

            autores_novos.Clear();
            autores_para_deletar.Clear();
            txtCodAutor.Text = string.Empty;
            cod_autor = 0;


        }


        //  Atualizando dados
        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {


            string novoTitulo = txtTituloRetornado.Text;
            int novoAnoPublicacao = Convert.ToInt32(mtxtAnoPublicacaoRetornada.Text);
            string novaEditora = txtEditoraRetornada.Text;
            string novaDescricao = txtDescricaoRetornada.Text;
            decimal novoValorLivro = Convert.ToDecimal(txtValorLivroRetornado.Text);


            if (BD.Conecta())
            {


                //  Chave primária
                escolhido.cod_livro = Convert.ToInt32(txtCodLivro.Text);


                //  Atributos modificados
                escolhido.titulo = novoTitulo;
                escolhido.ano_publicacao = novoAnoPublicacao;
                escolhido.editora = novaEditora;
                escolhido.descricao = novaDescricao;
                escolhido.valor_livro = novoValorLivro;


                if (BD.AtualizarDados_Livro(escolhido))
                {


                    MessageBox.Show("Dados alterados!");


                    if (autores_novos != null)
                    {


                        for (int i = 0; i < autores_novos.Count; i++)
                        {


                            if (BD.CadastrarAutorLivro(autores_novos[i])) ;

                            else
                                MessageBox.Show("Erro de registro");


                        }


                    }


                    if (autores_para_deletar != null)
                    {


                        for (int i = 0; i < autores_para_deletar.Count; i++)
                        {


                            if (BD.DeletarAutorLivro(autores_para_deletar[i])) ;

                            else
                                MessageBox.Show("Erro de registro");


                        }


                    }


                }

                else
                    MessageBox.Show("Erro de alteração.");


                BD.Desconecta();


            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }


        //  Deletar cadastro de livro
        private void btnDeletarCadastro_Click(object sender, EventArgs e)
        {


            if (BD.Conecta())
            {


                if (BD.DeletarCadastro_Livro(escolhido))
                {


                    MessageBox.Show("Dados excluídos!");


                    //  Botão btnNovaConsulta voltam ao invisível
                    btnNovaConsulta.Visible = false;
                    btnAtualizarDados.Visible = false;
                    btnDeletarCadastro.Visible = false;


                    //  Nova consulta já disponível
                    btnConsultarCadastro.Visible = true;


                    txtCodLivro.Text = string.Empty;
                    txtTituloRetornado.Text = string.Empty;
                    mtxtAnoPublicacaoRetornada.Text = string.Empty;
                    txtEditoraRetornada.Text = string.Empty;
                    txtDescricaoRetornada.Text = string.Empty;
                    mtxtDataCadastroRetornada.Text = string.Empty;
                    txtValorLivroRetornado.Text = string.Empty;


                    txtConsultarPorCodigo.Text = string.Empty;
                    cbConsultarPorTitulo.Items.Clear();


                    escolhido = null;
                    livros.Clear();
                    autoreslivro_encontrados.Clear();
                    cod_autor = 0;
                    autor_consultaeoutrasop = null;
                    autores_encontrados.Clear();


                    dgvAutoresLivro.Rows.Clear();


                }

                else
                    MessageBox.Show("Erro de exclusão.");


                BD.Desconecta();


            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }


        //  Adicionar um novo autor aos dados cadastrados
        private void btnInserirNovoAutor_Click(object sender, EventArgs e)
        {


            if (BD.Conecta())
            {


                Autor existeounao = BD.ConsultarAutor_Codigo(Convert.ToInt32(txtInserirOuExcluirCodAutor.Text));


                if (existeounao != null)
                {


                    int contador = 0;


                    for (int i = 0; i < autoreslivro_encontrados.Count; i++)
                    {


                        if (autoreslivro_encontrados[i].cod_autor == Convert.ToInt32(txtInserirOuExcluirCodAutor.Text))
                            contador += 1;


                    }


                    if (autores_novos != null)
                    {


                        for (int i = 0; i < autores_novos.Count; i++)
                        {


                            if (autores_novos[i].cod_autor == Convert.ToInt32(txtInserirOuExcluirCodAutor.Text))
                                contador += 1;


                        }


                    }


                    if (contador == 0)
                    {


                        //  Criando um código para o novo cadastro
                        string numeros3 = "123456789";
                        string cod_novo_autorlivro_gerado = "";

                        Random random3 = new Random();
                        for (int f = 0; f < 8; f++)
                        {
                            cod_novo_autorlivro_gerado = cod_novo_autorlivro_gerado + numeros3.Substring(random3.Next(0, numeros3.Length - 1), 1);
                        }


                        autorlivro_inseriroudeletar = null;
                        autorlivro_inseriroudeletar = new AutorLivro(Convert.ToInt32(cod_novo_autorlivro_gerado), Convert.ToInt32(txtInserirOuExcluirCodAutor.Text), escolhido.cod_livro);
                        autores_novos.Add(autorlivro_inseriroudeletar);


                        //  Adicionando o novo item ao datagridview
                        string[] linha_item = { existeounao.nome, Convert.ToString(existeounao.cod_autor) };

                        dgvAutoresLivro.Rows.Add(linha_item);


                        MessageBox.Show("Autor listado para inclusão. ATENÇÃO: a ação só será confirmada após a finalização da atualização de dados");


                    }

                    else
                        MessageBox.Show("Esse autor já foi cadastrado");


                }

                else
                    MessageBox.Show("Autor não encontrado. Por favor, verifique o código inserido");


            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }

        //  Remover um autor já listado
        private void btnRemoverAutorInserido_Click(object sender, EventArgs e)
        {


            if (BD.Conecta())
            {


                Autor existeounao = BD.ConsultarAutor_Codigo(Convert.ToInt32(txtInserirOuExcluirCodAutor.Text));


                if (existeounao != null)
                {


                    int contador = 0;


                    for (int i = 0; i < autoreslivro_encontrados.Count; i++)
                    {


                        if (autoreslivro_encontrados[i].cod_autor == Convert.ToInt32(txtInserirOuExcluirCodAutor.Text))
                        {


                            autores_para_deletar.Add(autoreslivro_encontrados[i]);
                            contador += 1;


                        }


                    }


                    if (autores_para_deletar != null)
                    {


                        for (int i = 0; i < autores_novos.Count; i++)
                        {


                            if (autores_novos[i].cod_autor == Convert.ToInt32(txtInserirOuExcluirCodAutor.Text))
                            {


                                autores_para_deletar.Add(autores_novos[i]);
                                contador += 1;


                            }


                        }


                    }

                    if (contador == 1)
                        MessageBox.Show("Autor listado para exclusão. ATENÇÃO: a ação só será confirmada após a finalização da atualização de dados");

                    else
                        MessageBox.Show("Esse autor não é um dos autores do livro");


                }

                else
                    MessageBox.Show("Autor não encontrado. Por favor, verifique o código inserido");

            }

            else
                MessageBox.Show("Não foi possível conectar o servidor.");


        }



        private void txtInserirOuExcluirCodAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


    }
}
