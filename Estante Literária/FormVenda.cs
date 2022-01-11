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
    public partial class FormVenda : Form
    {


        public FormVenda()
        {


            InitializeComponent();


            //  Determinando a criação do código da primeira venda após inicializar o programa
            cod_venda_gerado = "";
            CriandoCodVenda();


            //  Elementos da tela de realizar compra ficam desativados
            lblCodProduto.Visible = false;
            txtCodProduto.Visible = false;
            btnProcurarProduto.Visible = false;
            lblTitulo.Visible = false;
            txtTitulo.Visible = false;
            lblAutor.Visible = false;
            txtNomeAutor.Visible = false;
            lblEditora.Visible = false;
            txtEditora.Visible = false;
            lblDataPublicacao.Visible = false;
            txtDataPublicacao.Visible = false;
            lblValorUnitario.Visible = false;
            txtValorUnitario.Visible = false;
            lblQuantidade.Visible = false;
            txtQuantidade.Visible = false;
            btnAdicionarProduto.Visible = false;
            btnRemoverProduto.Visible = false;
            txtValorTotal.Visible = false;
            lblCodCliente.Visible = false;
            txtCodCliente.Visible = false;
            lblValorTotalCompra.Visible = false;
            txtValorTotalCompra.Visible = false;
            btnFinalizarVenda.Visible = false;
            btnCancelarVenda.Visible = false;
            dgvListaDeProdutos.Visible = false;

            rbConsultarCodVenda.Checked = true;
            btnNovaConsulta.Visible = false;
            lblItensVenda.Visible = false;
            dgvItensVendaRealizada.Visible = false;


        }


        //  Variáveis
        string numeros_random_cod_venda = "123456789";
        string numeros_random_cod_itemvenda = "123456789";
        Random random_cod_venda;
        Random random_cod_itemvenda;

        string cod_venda_gerado = "";
        string cod_itemvenda_gerado = "";

        ItemVenda itemvenda;
        List<ItemVenda> lista_produtos = new List<ItemVenda>();

        Livro escolhido;
        List<AutorLivro> autoreslivro_encontrados;
        Autor autor;
        List<Autor> autores_encontrados = new List<Autor>();

        int cod_cliente;
        int cod_funcionario;
        int cod_autor;
        int numero_autoreslivro_corrido = 0;

        int cod_venda;
        int cod_itemvenda;
        string nome_autor = "";

        DateTime dt_registro;

        decimal valor_livro;
        int unidades;
        decimal valor_itemvenda;

        ValidarLogin funcionariologado;


        //  Se conectando ao banco de dados
        BancoDeDados BD = new BancoDeDados();


        //  Método para criação de cod_venda
        private void CriandoCodVenda()
        {


            random_cod_venda = new Random();

            for (int f = 0; f < 8; f++)
            {
                cod_venda_gerado = cod_venda_gerado + numeros_random_cod_venda.Substring(random_cod_venda.Next(0, numeros_random_cod_venda.Length - 1), 1);
            }

            cod_venda = Convert.ToInt32(cod_venda_gerado);


        }

        //  Método para criação de cod_itemvenda
        private void CriandoCodItemVenda()
        {


            random_cod_itemvenda = new Random();

            for (int f = 0; f < 8; f++)
            {
                cod_itemvenda_gerado = cod_itemvenda_gerado + numeros_random_cod_itemvenda.Substring(random_cod_itemvenda.Next(0, numeros_random_cod_itemvenda.Length - 1), 1);
            }

            cod_itemvenda = Convert.ToInt32(cod_itemvenda_gerado);


        }

        //  Configurando o datagridview!
        private void ConfigurandoDataGridView_dgvListaDeProdutos()
        {
            //dgvListaDeProdutos.Columns[0].Name = "Título";
            //dgvListaDeProdutos.Columns[1].Name = "Valor unitário";
            //dgvListaDeProdutos.Columns[2].Name = "Quantidade";
            //dgvListaDeProdutos.Columns[3].Name = "Valor total";
        }


        //  Iniciar sessão
        private void btnIniciarSessão_Click(object sender, EventArgs e)
        {


            //  O código de funcionário foi informado?
            if (txtCodFuncionario.Text != string.Empty)
            {


                int validar_cod_funcionario = Convert.ToInt32(txtCodFuncionario.Text);


                if (BD.Conecta())
                {


                    //  Verificando se o código existe
                    funcionariologado = BD.IniciarSessao(validar_cod_funcionario);


                    if (funcionariologado == null)
                    {


                        string title = "Dados inválidos";
                        string message = "Dados inseridos incorretamente ou inexistentes";
                        MessageBox.Show(message, title);


                    }

                    else
                    {


                        //  Escondendo parte i
                        lblCodFuncionario.Visible = false;
                        txtCodFuncionario.Visible = false;
                        btnIniciarSessão.Visible = false;


                        //  Atribuindo valor ao cod_funcionario
                        cod_funcionario = funcionariologado.cod_funcionario;


                        //  Desbloqueando elementos
                        lblCodProduto.Visible = true;
                        txtCodProduto.Visible = true;
                        btnProcurarProduto.Visible = true;
                        lblTitulo.Visible = true;
                        txtTitulo.Visible = true;
                        lblAutor.Visible = true;
                        txtNomeAutor.Visible = true;
                        lblEditora.Visible = true;
                        txtEditora.Visible = true;
                        lblDataPublicacao.Visible = true;
                        txtDataPublicacao.Visible = true;
                        lblValorUnitario.Visible = true;
                        txtValorUnitario.Visible = true;
                        lblQuantidade.Visible = true;
                        txtQuantidade.Visible = true;
                        btnAdicionarProduto.Visible = true;
                        btnRemoverProduto.Visible = true;
                        txtValorTotal.Visible = true;
                        lblCodCliente.Visible = true;
                        txtCodCliente.Visible = true;
                        lblValorTotalCompra.Visible = true;
                        txtValorTotalCompra.Visible = true;
                        btnFinalizarVenda.Visible = true;
                        btnCancelarVenda.Visible = true;
                        dgvListaDeProdutos.Visible = true;


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

            else
            {


                string title = "Campo em branco";
                string message = "Insira o código de funcionário";
                MessageBox.Show(message, title);


            }


        }


        //  Procurar produto
        private void btnProcurarProduto_Click(object sender, EventArgs e)
        {


            nome_autor = "";


            txtTitulo.Text = string.Empty;
            txtNomeAutor.Text = string.Empty;
            txtEditora.Text = string.Empty;
            txtDataPublicacao.Text = string.Empty;
            txtValorUnitario.Text = string.Empty;
            txtQuantidade.Text = string.Empty;


            escolhido = null;
            numero_autoreslivro_corrido = 0;


            //  O código do produto foi inserido?
            if (txtCodProduto.Text != string.Empty)
            {


                int search_cod_livro = Convert.ToInt32(txtCodProduto.Text);


                if (BD.Conecta())
                {


                    //  Localizando o livro
                    escolhido = BD.ConsultarLivro_Codigo(search_cod_livro);


                    if (escolhido == null)
                        MessageBox.Show("Livro não encontrado");

                    else
                    {
                        ProcurarCodAutor();
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

            else
                MessageBox.Show("Insira o código de produto");


        }

        private void ProcurarCodAutor()
        {


            if (BD.Conecta())
            {


                autoreslivro_encontrados = BD.ProcurarAutoresLivro_Codigo(Convert.ToInt32(txtCodProduto.Text));


                if (autoreslivro_encontrados != null)
                {


                    for (int i = 0; i < autoreslivro_encontrados.Count; i++)
                    {


                        cod_autor = autoreslivro_encontrados[i].cod_autor;
                        ProcurarNomeAutor();


                    }


                }

                else
                    MessageBox.Show("O livro não possui registro de autor. Por favor, atualize os dados do livro inserido");


                if (numero_autoreslivro_corrido == autoreslivro_encontrados.Count)
                {
                    txtTitulo.Text = escolhido.titulo;
                    txtNomeAutor.Text = nome_autor;
                    txtEditora.Text = escolhido.editora;
                    txtDataPublicacao.Text = Convert.ToString(escolhido.ano_publicacao);
                    txtValorUnitario.Text = Convert.ToString(escolhido.valor_livro);
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

        private void ProcurarNomeAutor()
        {


            numero_autoreslivro_corrido += 1;


            if (BD.Conecta())
            {


                autor = null;


                autor = BD.ProcurarAutores_Nome(cod_autor);


                if (autor != null)
                {


                    autores_encontrados.Add(autor);
                    nome_autor += autor.nome + ", ";


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


        //  Adicionar produto ao carrinho
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {


            //  Criando um código para o novo item
            cod_itemvenda_gerado = "";
            CriandoCodItemVenda();


            //  Calculando valor do item
            if (txtQuantidade.Text != string.Empty && escolhido.cod_livro != null)
            {


                //  Determinando variáveis
                valor_livro = escolhido.valor_livro;
                dt_registro = DateTime.Now;


                unidades = Convert.ToInt32(txtQuantidade.Text);


                if (unidades > 0)
                {


                    //  Calculando o valor do item
                    valor_itemvenda = Calculadora.ValorItemVenda_Adicionar(valor_livro, unidades);


                    //  Atualizando valores na tela
                    txtValorTotal.Text = Convert.ToString(valor_itemvenda);
                    txtValorTotalCompra.Text = Convert.ToString(Calculadora.valor_itemvenda);

                    if (txtValorTotal.ForeColor == Color.Firebrick)
                        txtValorTotal.ForeColor = Color.Black;


                    //  Adicionando o novo item a lista de produtos
                    itemvenda = new ItemVenda(cod_itemvenda, cod_venda, dt_registro, escolhido.cod_livro, valor_livro, unidades, valor_itemvenda);
                    lista_produtos.Add(itemvenda);


                    //  Adicionando o novo item ao datagridview
                    string[] linha_item = { escolhido.titulo, Convert.ToString(valor_livro), Convert.ToString(unidades),
                        Convert.ToString(valor_itemvenda) };

                    dgvListaDeProdutos.Rows.Add(linha_item);


                }

                else
                    MessageBox.Show("Não foi possível identificar a quantidade a ser comprada. Por favor, " +
                        "verifique as informações inseridas");


            }

            else
                MessageBox.Show("Ação inválida. Verifique os dados inseridos");


        }

        //  Remover produto do carrinho
        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {


            //  Criando um código para o novo item
            cod_itemvenda_gerado = "";
            CriandoCodItemVenda();

            
            int uni_inseridas = 0;


            //  Calculando valor do item
            if (txtQuantidade.Text != string.Empty && escolhido.cod_livro != 0)
            {


                //  Determinando variáveis
                valor_livro = escolhido.valor_livro;
                dt_registro = DateTime.Now;


                unidades = Convert.ToInt32(txtQuantidade.Text);


                if (unidades > 0)
                {


                    for (int i = 0; i < lista_produtos.Count; i++)
                    {


                        if (lista_produtos[i].cod_livro == escolhido.cod_livro)
                            uni_inseridas += lista_produtos[i].unidades;


                    }


                    if (uni_inseridas >= 0)
                    {


                        if (unidades <= uni_inseridas)
                        {


                            //  Calculando o valor do item a ser removido
                            valor_itemvenda = Calculadora.ValorItemVenda_Remover(valor_livro, unidades);


                            //  Atualizando valores na tela
                            txtValorTotal.Text = Convert.ToString(valor_itemvenda);
                            txtValorTotalCompra.Text = Convert.ToString(Calculadora.valor_itemvenda);

                            txtValorTotal.ForeColor = Color.Firebrick;


                            //  Adicionando o novo item a lista de produtos
                            itemvenda = new ItemVenda(cod_itemvenda, cod_venda, dt_registro, escolhido.cod_livro, valor_livro, (0 - unidades), valor_itemvenda);
                            lista_produtos.Add(itemvenda);

                            string[] linha_item = { escolhido.titulo, Convert.ToString(valor_livro), Convert.ToString((0 - unidades)),
                                Convert.ToString(valor_itemvenda) };

                            dgvListaDeProdutos.Rows.Add(linha_item);


                        }

                        else
                            MessageBox.Show("Ação inválida. A quantidade inserida é maior do que a registrada");


                    }


                }

                else
                    MessageBox.Show("Não foi possível identificar a quantidade a ser comprada. Por favor, " +
                        "verifique as informações inseridas");


            }

            else
                MessageBox.Show("Ação inválida. Verifique os dados inseridos");


        }


        //  Registrando venda
        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {


            if (Calculadora.valor_itemvenda != 0)
            {


                dt_registro = DateTime.Now;


                //  O cliente decide cadastrar a compra?
                if (txtCodCliente.Text != string.Empty)
                    cod_cliente = Convert.ToInt32(txtCodCliente.Text);
                else
                    cod_cliente = 0;


                //  Instanciando a classe Venda
                Venda novaVenda = new Venda(cod_venda, cod_cliente, cod_funcionario, dt_registro, Calculadora.valor_itemvenda);


                //  Cadastrando o novo autor
                if (BD.Conecta())
                {


                    //  Registrando a lista de produtos
                    for (int i = 0; i < lista_produtos.Count; i++)
                    {


                        if (BD.RegistrarListaProdutos(lista_produtos[i])) ;

                        else
                            MessageBox.Show("Erro de registro");


                    }


                    if (BD.RegistrarVenda(novaVenda))
                    {


                        string title = "Venda registrada";
                        string message = "A venda foi registrada com sucesso. O valor total foi de R$ " + Calculadora.valor_itemvenda;
                        MessageBox.Show(message, title);


                        //  Se preparando para a próxima venda
                        txtCodProduto.Text = string.Empty;
                        txtTitulo.Text = string.Empty;
                        txtNomeAutor.Text = string.Empty;
                        txtEditora.Text = string.Empty;
                        txtDataPublicacao.Text = string.Empty;
                        txtValorUnitario.Text = string.Empty;
                        txtQuantidade.Text = string.Empty;
                        txtValorTotal.Text = string.Empty;
                        txtCodCliente.Text = string.Empty;
                        txtValorTotalCompra.Text = string.Empty;
                        dgvListaDeProdutos.Rows.Clear();


                        cod_venda_gerado = "";
                        CriandoCodVenda();

                        itemvenda = null;
                        lista_produtos.Clear();
                        escolhido = null;
                        autoreslivro_encontrados.Clear();
                        autor = null;
                        autores_encontrados.Clear();
                        nome_autor = "";
                        numero_autoreslivro_corrido = 0;
                        Calculadora.valor_itemvenda = 0;



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
                MessageBox.Show("O valor da compra é nulo. Por favor, verifique a lista de produtos ou cancele a venda.");


        }


        //  Cancelando a venda
        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {


            DialogResult cancelarvenda = MessageBox.Show("Deseja cancelar a venda?",
                "Sim", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);


            if (cancelarvenda.ToString().ToUpper() == "YES")
            {


                string title = "Venda cancelada";
                string message = "A venda foi cancelada com sucesso.";
                MessageBox.Show(message, title);


                //  Se preparando para a próxima venda
                txtCodProduto.Text = string.Empty;
                txtTitulo.Text = string.Empty;
                txtNomeAutor.Text = string.Empty;
                txtEditora.Text = string.Empty;
                txtDataPublicacao.Text = string.Empty;
                txtValorUnitario.Text = string.Empty;
                txtQuantidade.Text = string.Empty;
                txtValorTotal.Text = string.Empty;
                txtCodCliente.Text = string.Empty;
                txtValorTotalCompra.Text = string.Empty;
                dgvListaDeProdutos.Rows.Clear();


                cod_venda_gerado = "";
                CriandoCodVenda();

                itemvenda = null;
                lista_produtos.Clear();
                escolhido = null;
                autoreslivro_encontrados.Clear();
                autor = null;
                autores_encontrados.Clear();
                nome_autor = "";
                numero_autoreslivro_corrido = 0;
                Calculadora.valor_itemvenda = 0;
            }


        }


        private void txtCodFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        //  Variáveis - Parte II
        Venda venda_escolhida;
        List<ItemVenda> itensvenda = new List<ItemVenda>();
        List<Venda> vendas_encontradas = new List<Venda>();
        int cod_livro;
        Livro livro_procurado;
        List<Livro> livros_encontrados = new List<Livro>();


        //  Consultar dados de venda
        private void btnConsultarDados_Click(object sender, EventArgs e)
        {


            //  Conectando ao banco de dados
            if (BD.Conecta())
            {


                //  Procurando por CodVenda
                if (rbConsultarCodVenda.Checked)
                {


                    if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                    {


                        MessageBox.Show("Insira o código da obra");


                    }

                    else
                    {


                        btnConsultarDados.Visible = false;
                        btnNovaConsulta.Visible = true;


                        int search_cod_venda = Convert.ToInt32(txtCodigo.Text);
                        venda_escolhida = BD.ConsultarVenda_CodigoVenda(search_cod_venda);

                        if (venda_escolhida == null)
                            MessageBox.Show("Venda não encontrada");

                        else
                        {
                            

                            //  Adicionando o novo item ao datagridview
                            string[] linha_item = { Convert.ToString(venda_escolhida.cod_venda), Convert.ToString(venda_escolhida.dt_registro),
                                    Convert.ToString(venda_escolhida.cod_funcionario), Convert.ToString(venda_escolhida.cod_cliente),
                                    Convert.ToString(venda_escolhida.valor_totalvenda) };

                            dgvVendaRealizada.Rows.Add(linha_item);


                            ProcurarItensVenda();
                        
                        
                        }


                    }


                }

                //  Procurando por CodFuncionario
                if (rbConsultarCodFuncionario.Checked)
                {


                    if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                    {


                        MessageBox.Show("Insira o código da obra");


                    }

                    else
                    {


                        btnConsultarDados.Visible = false;
                        btnNovaConsulta.Visible = true;


                        int search_cod_funcionario = Convert.ToInt32(txtCodigo.Text);
                        vendas_encontradas = BD.ConsultarVenda_CodigoFuncionario(search_cod_funcionario);


                        if (vendas_encontradas == null)
                            MessageBox.Show("O funcionário não fez nenhuma venda");

                        else
                        {


                            for (int i = 0; i < vendas_encontradas.Count; i++)
                            {


                                //  Adicionando o novo item ao datagridview
                                string[] linha_item = { Convert.ToString(vendas_encontradas[i].cod_venda), Convert.ToString(vendas_encontradas[i].dt_registro),
                                    Convert.ToString(vendas_encontradas[i].cod_funcionario), Convert.ToString(vendas_encontradas[i].cod_cliente),
                                    Convert.ToString(vendas_encontradas[i].valor_totalvenda) };

                                dgvVendaRealizada.Rows.Add(linha_item);


                            }


                        }


                    }


                }

                //  Procurando por CodCliente
                if (rbConsultarCodCliente.Checked)
                {


                    if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                    {


                        MessageBox.Show("Insira o código da obra");


                    }

                    else
                    {


                        btnConsultarDados.Visible = false;
                        btnNovaConsulta.Visible = true;


                        int search_cod_cliente = Convert.ToInt32(txtCodigo.Text);
                        vendas_encontradas = BD.ConsultarVenda_CodigoCliente(search_cod_cliente);


                        if (vendas_encontradas == null)
                            MessageBox.Show("Venda não encontrada");

                        else
                        {


                            for (int i = 0; i < vendas_encontradas.Count; i++)
                            {


                                //  Adicionando o novo item ao datagridview
                                string[] linha_item = { Convert.ToString(vendas_encontradas[i].cod_venda), Convert.ToString(vendas_encontradas[i].dt_registro),
                                    Convert.ToString(vendas_encontradas[i].cod_funcionario), Convert.ToString(vendas_encontradas[i].cod_cliente),
                                    Convert.ToString(vendas_encontradas[i].valor_totalvenda) };

                                dgvVendaRealizada.Rows.Add(linha_item);


                            }


                        }


                    }


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

        //  Procurar a lista de produtos
        private void ProcurarItensVenda()
        {


            if (BD.Conecta())
            {


                itensvenda = BD.ConsultarItemVenda(venda_escolhida.cod_venda);


                if (itensvenda != null)
                {


                    for (int i = 0; i < itensvenda.Count; i++)
                    {


                        cod_livro = itensvenda[i].cod_livro;
                        ProcurarTituloLivro();


                    }


                    lblItensVenda.Visible = true;
                    dgvItensVendaRealizada.Visible = true;


                    for (int i = 0; i < itensvenda.Count; i++)
                    {


                        //  Adicionando o novo item ao datagridview
                        string[] linha_item = { livros_encontrados[i].titulo, Convert.ToString(itensvenda[i].valor_livro),
                        Convert.ToString(itensvenda[i].unidades), Convert.ToString(itensvenda[i].valor_itemvenda)};

                        dgvItensVendaRealizada.Rows.Add(linha_item);


                    }


                }

                else
                    MessageBox.Show("Alguns dados da venda, como a lista de produtos, foram suprimidos manualmente.");


                BD.Desconecta();


            }

            else
            {


                string title = "Erro de conexão";
                string message = "Não foi possível se conectar ao banco de dados";
                MessageBox.Show(message, title);


            }


        }

        //  Procurar o título de cada livro
        private void ProcurarTituloLivro()
        {


            if (BD.Conecta())
            {


                livro_procurado = null;


                livro_procurado = BD.ConsultarLivro_Codigo(cod_livro);


                if (livro_procurado != null)
                    livros_encontrados.Add(livro_procurado);

                else
                {


                    livro_procurado = new Livro(0, "LIVRO NÃO ENCONTRADO", 1, "SEM EDITORA", "SEM DESCRIÇÃO", DateTime.Now, 1);
                    livros_encontrados.Add(livro_procurado);


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


        //  Zerando os dados
        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {


            venda_escolhida = null;
            itensvenda.Clear();
            vendas_encontradas.Clear();
            cod_livro = 0;
            livro_procurado = null;
            livros_encontrados.Clear();


            btnNovaConsulta.Visible = false;
            btnConsultarDados.Visible = true;
            txtCodigo.Text = string.Empty;


            lblItensVenda.Visible = false;
            dgvVendaRealizada.Rows.Clear();
            dgvItensVendaRealizada.Rows.Clear();
            dgvItensVendaRealizada.Visible = false;


        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
