
namespace Estante_Literária
{
    partial class FormLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlLivros = new System.Windows.Forms.TabControl();
            this.tabPageCadastrarLivro = new System.Windows.Forms.TabPage();
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblInserirParte02 = new System.Windows.Forms.Label();
            this.panelParte2 = new System.Windows.Forms.Panel();
            this.btnRemoverAutor = new System.Windows.Forms.Button();
            this.dgvListaDeAutoresInseridos = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInserirParte02 = new System.Windows.Forms.Button();
            this.lblCodAutor = new System.Windows.Forms.Label();
            this.txtCodAutor = new System.Windows.Forms.TextBox();
            this.lblCadastrarCliente = new System.Windows.Forms.Label();
            this.panelParte1 = new System.Windows.Forms.Panel();
            this.txtValorLivro = new System.Windows.Forms.TextBox();
            this.lblValorLivro = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnInserirParte01 = new System.Windows.Forms.Button();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.mtxtAnoPublicacao = new System.Windows.Forms.MaskedTextBox();
            this.lblAnoPublicacao = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabPageConsultarDadosEOutrasOperacoes = new System.Windows.Forms.TabPage();
            this.btnRemoverAutorInserido = new System.Windows.Forms.Button();
            this.btnInserirNovoAutor = new System.Windows.Forms.Button();
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.lblInserirOuExcluirCodAutor = new System.Windows.Forms.Label();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.txtInserirOuExcluirCodAutor = new System.Windows.Forms.TextBox();
            this.mtxtDataCadastroRetornada = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.btnDeletarCadastro = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.dgvAutoresLivro = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConsultarDadosEOutrasOperacoes = new System.Windows.Forms.Label();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.btnConsultarCadastro = new System.Windows.Forms.Button();
            this.txtValorLivroRetornado = new System.Windows.Forms.TextBox();
            this.txtConsultarPorCodigo = new System.Windows.Forms.TextBox();
            this.lblValorLivroRetornado = new System.Windows.Forms.Label();
            this.cbConsultarPorTitulo = new System.Windows.Forms.ComboBox();
            this.txtDescricaoRetornada = new System.Windows.Forms.TextBox();
            this.rbConsultarCodLivro = new System.Windows.Forms.RadioButton();
            this.lblDescricaoRetornada = new System.Windows.Forms.Label();
            this.rbConsultarTitulo = new System.Windows.Forms.RadioButton();
            this.txtTituloRetornado = new System.Windows.Forms.TextBox();
            this.txtEditoraRetornada = new System.Windows.Forms.TextBox();
            this.lblTituloRetornado = new System.Windows.Forms.Label();
            this.lblEditoraRetornada = new System.Windows.Forms.Label();
            this.lblAnoPublicacaoRetornado = new System.Windows.Forms.Label();
            this.mtxtAnoPublicacaoRetornada = new System.Windows.Forms.MaskedTextBox();
            this.toolTipLivros = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlLivros.SuspendLayout();
            this.tabPageCadastrarLivro.SuspendLayout();
            this.panelParte2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeAutoresInseridos)).BeginInit();
            this.panelParte1.SuspendLayout();
            this.tabPageConsultarDadosEOutrasOperacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlLivros
            // 
            this.tabControlLivros.Controls.Add(this.tabPageCadastrarLivro);
            this.tabControlLivros.Controls.Add(this.tabPageConsultarDadosEOutrasOperacoes);
            this.tabControlLivros.Location = new System.Drawing.Point(12, 12);
            this.tabControlLivros.Name = "tabControlLivros";
            this.tabControlLivros.SelectedIndex = 0;
            this.tabControlLivros.Size = new System.Drawing.Size(1216, 612);
            this.tabControlLivros.TabIndex = 0;
            // 
            // tabPageCadastrarLivro
            // 
            this.tabPageCadastrarLivro.Controls.Add(this.btnCancelarCadastro);
            this.tabPageCadastrarLivro.Controls.Add(this.btnCadastrar);
            this.tabPageCadastrarLivro.Controls.Add(this.lblInserirParte02);
            this.tabPageCadastrarLivro.Controls.Add(this.panelParte2);
            this.tabPageCadastrarLivro.Controls.Add(this.lblCadastrarCliente);
            this.tabPageCadastrarLivro.Controls.Add(this.panelParte1);
            this.tabPageCadastrarLivro.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastrarLivro.Name = "tabPageCadastrarLivro";
            this.tabPageCadastrarLivro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastrarLivro.Size = new System.Drawing.Size(1208, 586);
            this.tabPageCadastrarLivro.TabIndex = 0;
            this.tabPageCadastrarLivro.Text = "CADASTRAR LIVRO";
            this.tabPageCadastrarLivro.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCancelarCadastro.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastro.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelarCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCadastro.Location = new System.Drawing.Point(830, 535);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancelarCadastro.Size = new System.Drawing.Size(195, 34);
            this.btnCancelarCadastro.TabIndex = 33;
            this.btnCancelarCadastro.Text = "CANCELAR CADASTRO";
            this.btnCancelarCadastro.UseVisualStyleBackColor = false;
            this.btnCancelarCadastro.Click += new System.EventHandler(this.btnCancelarCaadastro_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(634, 535);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(195, 34);
            this.btnCadastrar.TabIndex = 32;
            this.btnCadastrar.Text = "FINALIZAR CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblInserirParte02
            // 
            this.lblInserirParte02.AutoSize = true;
            this.lblInserirParte02.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.lblInserirParte02.Location = new System.Drawing.Point(183, 269);
            this.lblInserirParte02.Name = "lblInserirParte02";
            this.lblInserirParte02.Size = new System.Drawing.Size(414, 32);
            this.lblInserirParte02.TabIndex = 31;
            this.lblInserirParte02.Text = "ETAPA 02: Insira o código dos autores";
            // 
            // panelParte2
            // 
            this.panelParte2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParte2.Controls.Add(this.btnRemoverAutor);
            this.panelParte2.Controls.Add(this.dgvListaDeAutoresInseridos);
            this.panelParte2.Controls.Add(this.btnInserirParte02);
            this.panelParte2.Controls.Add(this.lblCodAutor);
            this.panelParte2.Controls.Add(this.txtCodAutor);
            this.panelParte2.Location = new System.Drawing.Point(189, 304);
            this.panelParte2.Name = "panelParte2";
            this.panelParte2.Size = new System.Drawing.Size(836, 225);
            this.panelParte2.TabIndex = 30;
            // 
            // btnRemoverAutor
            // 
            this.btnRemoverAutor.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemoverAutor.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnRemoverAutor.FlatAppearance.BorderSize = 0;
            this.btnRemoverAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnRemoverAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverAutor.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRemoverAutor.ForeColor = System.Drawing.Color.White;
            this.btnRemoverAutor.Location = new System.Drawing.Point(569, 24);
            this.btnRemoverAutor.Name = "btnRemoverAutor";
            this.btnRemoverAutor.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnRemoverAutor.Size = new System.Drawing.Size(195, 34);
            this.btnRemoverAutor.TabIndex = 44;
            this.btnRemoverAutor.Text = "REMOVER AUTOR";
            this.btnRemoverAutor.UseVisualStyleBackColor = false;
            this.btnRemoverAutor.Click += new System.EventHandler(this.btnRemoverAutor_Click);
            // 
            // dgvListaDeAutoresInseridos
            // 
            this.dgvListaDeAutoresInseridos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaDeAutoresInseridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeAutoresInseridos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.c,
            this.d});
            this.dgvListaDeAutoresInseridos.Location = new System.Drawing.Point(96, 81);
            this.dgvListaDeAutoresInseridos.Name = "dgvListaDeAutoresInseridos";
            this.dgvListaDeAutoresInseridos.Size = new System.Drawing.Size(643, 116);
            this.dgvListaDeAutoresInseridos.TabIndex = 41;
            // 
            // a
            // 
            this.a.HeaderText = "Título da obra";
            this.a.Name = "a";
            this.a.Width = 200;
            // 
            // b
            // 
            this.b.HeaderText = "Código do livro";
            this.b.Name = "b";
            // 
            // c
            // 
            this.c.HeaderText = "Nome do autor";
            this.c.Name = "c";
            this.c.Width = 200;
            // 
            // d
            // 
            this.d.HeaderText = "Código do autor";
            this.d.Name = "d";
            // 
            // btnInserirParte02
            // 
            this.btnInserirParte02.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInserirParte02.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnInserirParte02.FlatAppearance.BorderSize = 0;
            this.btnInserirParte02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnInserirParte02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirParte02.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInserirParte02.ForeColor = System.Drawing.Color.White;
            this.btnInserirParte02.Location = new System.Drawing.Point(373, 24);
            this.btnInserirParte02.Name = "btnInserirParte02";
            this.btnInserirParte02.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnInserirParte02.Size = new System.Drawing.Size(195, 34);
            this.btnInserirParte02.TabIndex = 32;
            this.btnInserirParte02.Text = "INSERIR AUTOR";
            this.btnInserirParte02.UseVisualStyleBackColor = false;
            this.btnInserirParte02.Click += new System.EventHandler(this.btnInserirParte02_Click);
            // 
            // lblCodAutor
            // 
            this.lblCodAutor.AutoSize = true;
            this.lblCodAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAutor.Location = new System.Drawing.Point(70, 34);
            this.lblCodAutor.Name = "lblCodAutor";
            this.lblCodAutor.Size = new System.Drawing.Size(104, 16);
            this.lblCodAutor.TabIndex = 43;
            this.lblCodAutor.Text = "Código de autor";
            // 
            // txtCodAutor
            // 
            this.txtCodAutor.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodAutor.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtCodAutor.ForeColor = System.Drawing.Color.Black;
            this.txtCodAutor.Location = new System.Drawing.Point(180, 30);
            this.txtCodAutor.MaxLength = 8;
            this.txtCodAutor.Name = "txtCodAutor";
            this.txtCodAutor.Size = new System.Drawing.Size(150, 25);
            this.txtCodAutor.TabIndex = 39;
            this.toolTipLivros.SetToolTip(this.txtCodAutor, "O código possui 8 digítos");
            this.txtCodAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodAutor_KeyPress);
            // 
            // lblCadastrarCliente
            // 
            this.lblCadastrarCliente.AutoSize = true;
            this.lblCadastrarCliente.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.lblCadastrarCliente.Location = new System.Drawing.Point(183, 18);
            this.lblCadastrarCliente.Name = "lblCadastrarCliente";
            this.lblCadastrarCliente.Size = new System.Drawing.Size(425, 32);
            this.lblCadastrarCliente.TabIndex = 28;
            this.lblCadastrarCliente.Text = "ETAPA 01: Insira as informações abaixo";
            // 
            // panelParte1
            // 
            this.panelParte1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParte1.Controls.Add(this.txtValorLivro);
            this.panelParte1.Controls.Add(this.lblValorLivro);
            this.panelParte1.Controls.Add(this.txtDescricao);
            this.panelParte1.Controls.Add(this.lblDescricao);
            this.panelParte1.Controls.Add(this.btnInserirParte01);
            this.panelParte1.Controls.Add(this.txtEditora);
            this.panelParte1.Controls.Add(this.lblEditora);
            this.panelParte1.Controls.Add(this.mtxtAnoPublicacao);
            this.panelParte1.Controls.Add(this.lblAnoPublicacao);
            this.panelParte1.Controls.Add(this.txtTitulo);
            this.panelParte1.Controls.Add(this.lblTitulo);
            this.panelParte1.Location = new System.Drawing.Point(189, 53);
            this.panelParte1.Name = "panelParte1";
            this.panelParte1.Size = new System.Drawing.Size(836, 213);
            this.panelParte1.TabIndex = 0;
            // 
            // txtValorLivro
            // 
            this.txtValorLivro.BackColor = System.Drawing.SystemColors.Control;
            this.txtValorLivro.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtValorLivro.ForeColor = System.Drawing.Color.Black;
            this.txtValorLivro.Location = new System.Drawing.Point(245, 157);
            this.txtValorLivro.MaxLength = 150;
            this.txtValorLivro.Name = "txtValorLivro";
            this.txtValorLivro.Size = new System.Drawing.Size(100, 25);
            this.txtValorLivro.TabIndex = 43;
            // 
            // lblValorLivro
            // 
            this.lblValorLivro.AutoSize = true;
            this.lblValorLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLivro.Location = new System.Drawing.Point(152, 161);
            this.lblValorLivro.Name = "lblValorLivro";
            this.lblValorLivro.Size = new System.Drawing.Size(87, 16);
            this.lblValorLivro.TabIndex = 42;
            this.lblValorLivro.Text = "Valor do livro";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescricao.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(245, 91);
            this.txtDescricao.MaxLength = 150;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(471, 60);
            this.txtDescricao.TabIndex = 38;
            this.toolTipLivros.SetToolTip(this.txtDescricao, "Texto curto sobre o livro");
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(169, 95);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(70, 16);
            this.lblDescricao.TabIndex = 37;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnInserirParte01
            // 
            this.btnInserirParte01.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInserirParte01.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnInserirParte01.FlatAppearance.BorderSize = 0;
            this.btnInserirParte01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnInserirParte01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirParte01.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInserirParte01.ForeColor = System.Drawing.Color.White;
            this.btnInserirParte01.Location = new System.Drawing.Point(521, 165);
            this.btnInserirParte01.Name = "btnInserirParte01";
            this.btnInserirParte01.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnInserirParte01.Size = new System.Drawing.Size(195, 34);
            this.btnInserirParte01.TabIndex = 29;
            this.btnInserirParte01.Text = "INSERIR DADOS";
            this.btnInserirParte01.UseVisualStyleBackColor = false;
            this.btnInserirParte01.Click += new System.EventHandler(this.btnInserirParte01_Click);
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.SystemColors.Control;
            this.txtEditora.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtEditora.ForeColor = System.Drawing.Color.Black;
            this.txtEditora.Location = new System.Drawing.Point(466, 60);
            this.txtEditora.MaxLength = 150;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(250, 25);
            this.txtEditora.TabIndex = 9;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.lblEditora.Location = new System.Drawing.Point(410, 63);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(50, 17);
            this.lblEditora.TabIndex = 8;
            this.lblEditora.Text = "Editora";
            // 
            // mtxtAnoPublicacao
            // 
            this.mtxtAnoPublicacao.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtAnoPublicacao.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtAnoPublicacao.Location = new System.Drawing.Point(245, 60);
            this.mtxtAnoPublicacao.Mask = "0000";
            this.mtxtAnoPublicacao.Name = "mtxtAnoPublicacao";
            this.mtxtAnoPublicacao.Size = new System.Drawing.Size(100, 25);
            this.mtxtAnoPublicacao.TabIndex = 36;
            this.toolTipLivros.SetToolTip(this.mtxtAnoPublicacao, "Ex.: 1989");
            this.mtxtAnoPublicacao.ValidatingType = typeof(System.DateTime);
            // 
            // lblAnoPublicacao
            // 
            this.lblAnoPublicacao.AutoSize = true;
            this.lblAnoPublicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAnoPublicacao.Location = new System.Drawing.Point(118, 64);
            this.lblAnoPublicacao.Name = "lblAnoPublicacao";
            this.lblAnoPublicacao.Size = new System.Drawing.Size(121, 16);
            this.lblAnoPublicacao.TabIndex = 35;
            this.lblAnoPublicacao.Text = "Ano da publicação";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(245, 29);
            this.txtTitulo.MaxLength = 150;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(471, 25);
            this.txtTitulo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(148, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 16);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Título da obra";
            // 
            // tabPageConsultarDadosEOutrasOperacoes
            // 
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.btnRemoverAutorInserido);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.btnInserirNovoAutor);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.txtCodLivro);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.lblInserirOuExcluirCodAutor);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.lblCodFuncionario);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.txtInserirOuExcluirCodAutor);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.mtxtDataCadastroRetornada);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.lblDataCadastro);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.btnDeletarCadastro);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.btnAtualizarDados);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.dgvAutoresLivro);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.lblConsultarDadosEOutrasOperacoes);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.btnNovaConsulta);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.btnConsultarCadastro);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.txtValorLivroRetornado);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.txtConsultarPorCodigo);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.lblValorLivroRetornado);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.cbConsultarPorTitulo);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.txtDescricaoRetornada);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.rbConsultarCodLivro);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.lblDescricaoRetornada);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.rbConsultarTitulo);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.txtTituloRetornado);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.txtEditoraRetornada);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.lblTituloRetornado);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.lblEditoraRetornada);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.lblAnoPublicacaoRetornado);
            this.tabPageConsultarDadosEOutrasOperacoes.Controls.Add(this.mtxtAnoPublicacaoRetornada);
            this.tabPageConsultarDadosEOutrasOperacoes.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultarDadosEOutrasOperacoes.Name = "tabPageConsultarDadosEOutrasOperacoes";
            this.tabPageConsultarDadosEOutrasOperacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultarDadosEOutrasOperacoes.Size = new System.Drawing.Size(1208, 586);
            this.tabPageConsultarDadosEOutrasOperacoes.TabIndex = 1;
            this.tabPageConsultarDadosEOutrasOperacoes.Text = "CONSULTAR DADOS E OUTRAS OPERAÇÕES";
            this.tabPageConsultarDadosEOutrasOperacoes.UseVisualStyleBackColor = true;
            // 
            // btnRemoverAutorInserido
            // 
            this.btnRemoverAutorInserido.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemoverAutorInserido.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnRemoverAutorInserido.FlatAppearance.BorderSize = 0;
            this.btnRemoverAutorInserido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnRemoverAutorInserido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverAutorInserido.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRemoverAutorInserido.ForeColor = System.Drawing.Color.White;
            this.btnRemoverAutorInserido.Location = new System.Drawing.Point(964, 438);
            this.btnRemoverAutorInserido.Name = "btnRemoverAutorInserido";
            this.btnRemoverAutorInserido.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnRemoverAutorInserido.Size = new System.Drawing.Size(195, 34);
            this.btnRemoverAutorInserido.TabIndex = 48;
            this.btnRemoverAutorInserido.Text = "REMOVER AUTOR";
            this.btnRemoverAutorInserido.UseVisualStyleBackColor = false;
            this.btnRemoverAutorInserido.Click += new System.EventHandler(this.btnRemoverAutorInserido_Click);
            // 
            // btnInserirNovoAutor
            // 
            this.btnInserirNovoAutor.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInserirNovoAutor.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnInserirNovoAutor.FlatAppearance.BorderSize = 0;
            this.btnInserirNovoAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnInserirNovoAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirNovoAutor.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInserirNovoAutor.ForeColor = System.Drawing.Color.White;
            this.btnInserirNovoAutor.Location = new System.Drawing.Point(964, 398);
            this.btnInserirNovoAutor.Name = "btnInserirNovoAutor";
            this.btnInserirNovoAutor.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnInserirNovoAutor.Size = new System.Drawing.Size(195, 34);
            this.btnInserirNovoAutor.TabIndex = 45;
            this.btnInserirNovoAutor.Text = "INSERIR AUTOR";
            this.btnInserirNovoAutor.UseVisualStyleBackColor = false;
            this.btnInserirNovoAutor.Click += new System.EventHandler(this.btnInserirNovoAutor_Click);
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodLivro.Enabled = false;
            this.txtCodLivro.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtCodLivro.ForeColor = System.Drawing.Color.Black;
            this.txtCodLivro.Location = new System.Drawing.Point(485, 197);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.ReadOnly = true;
            this.txtCodLivro.Size = new System.Drawing.Size(150, 25);
            this.txtCodLivro.TabIndex = 67;
            // 
            // lblInserirOuExcluirCodAutor
            // 
            this.lblInserirOuExcluirCodAutor.AutoSize = true;
            this.lblInserirOuExcluirCodAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInserirOuExcluirCodAutor.Location = new System.Drawing.Point(681, 426);
            this.lblInserirOuExcluirCodAutor.Name = "lblInserirOuExcluirCodAutor";
            this.lblInserirOuExcluirCodAutor.Size = new System.Drawing.Size(104, 16);
            this.lblInserirOuExcluirCodAutor.TabIndex = 47;
            this.lblInserirOuExcluirCodAutor.Text = "Código de autor";
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFuncionario.Location = new System.Drawing.Point(382, 201);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(99, 16);
            this.lblCodFuncionario.TabIndex = 66;
            this.lblCodFuncionario.Text = "Código do livro";
            // 
            // txtInserirOuExcluirCodAutor
            // 
            this.txtInserirOuExcluirCodAutor.BackColor = System.Drawing.SystemColors.Control;
            this.txtInserirOuExcluirCodAutor.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtInserirOuExcluirCodAutor.ForeColor = System.Drawing.Color.Black;
            this.txtInserirOuExcluirCodAutor.Location = new System.Drawing.Point(791, 422);
            this.txtInserirOuExcluirCodAutor.MaxLength = 8;
            this.txtInserirOuExcluirCodAutor.Name = "txtInserirOuExcluirCodAutor";
            this.txtInserirOuExcluirCodAutor.Size = new System.Drawing.Size(150, 25);
            this.txtInserirOuExcluirCodAutor.TabIndex = 46;
            this.toolTipLivros.SetToolTip(this.txtInserirOuExcluirCodAutor, "O código possui 8 digítos");
            this.txtInserirOuExcluirCodAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInserirOuExcluirCodAutor_KeyPress);
            // 
            // mtxtDataCadastroRetornada
            // 
            this.mtxtDataCadastroRetornada.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtDataCadastroRetornada.Enabled = false;
            this.mtxtDataCadastroRetornada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtDataCadastroRetornada.Location = new System.Drawing.Point(485, 450);
            this.mtxtDataCadastroRetornada.Mask = "00/00/0000 90:00";
            this.mtxtDataCadastroRetornada.Name = "mtxtDataCadastroRetornada";
            this.mtxtDataCadastroRetornada.ReadOnly = true;
            this.mtxtDataCadastroRetornada.Size = new System.Drawing.Size(150, 25);
            this.mtxtDataCadastroRetornada.TabIndex = 64;
            this.mtxtDataCadastroRetornada.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.Location = new System.Drawing.Point(367, 454);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(112, 16);
            this.lblDataCadastro.TabIndex = 63;
            this.lblDataCadastro.Text = "Data de cadastro";
            // 
            // btnDeletarCadastro
            // 
            this.btnDeletarCadastro.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeletarCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnDeletarCadastro.FlatAppearance.BorderSize = 0;
            this.btnDeletarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnDeletarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarCadastro.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeletarCadastro.ForeColor = System.Drawing.Color.White;
            this.btnDeletarCadastro.Location = new System.Drawing.Point(605, 517);
            this.btnDeletarCadastro.Name = "btnDeletarCadastro";
            this.btnDeletarCadastro.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnDeletarCadastro.Size = new System.Drawing.Size(250, 34);
            this.btnDeletarCadastro.TabIndex = 56;
            this.btnDeletarCadastro.Text = "APAGAR LIVRO";
            this.btnDeletarCadastro.UseVisualStyleBackColor = false;
            this.btnDeletarCadastro.Click += new System.EventHandler(this.btnDeletarCadastro_Click);
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAtualizarDados.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAtualizarDados.FlatAppearance.BorderSize = 0;
            this.btnAtualizarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnAtualizarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarDados.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtualizarDados.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarDados.Location = new System.Drawing.Point(353, 517);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAtualizarDados.Size = new System.Drawing.Size(250, 34);
            this.btnAtualizarDados.TabIndex = 55;
            this.btnAtualizarDados.Text = "ATUALIZAR DADOS";
            this.btnAtualizarDados.UseVisualStyleBackColor = false;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // dgvAutoresLivro
            // 
            this.dgvAutoresLivro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAutoresLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoresLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvAutoresLivro.Location = new System.Drawing.Point(684, 179);
            this.dgvAutoresLivro.Name = "dgvAutoresLivro";
            this.dgvAutoresLivro.Size = new System.Drawing.Size(475, 183);
            this.dgvAutoresLivro.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do autor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 306;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Código do autor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // lblConsultarDadosEOutrasOperacoes
            // 
            this.lblConsultarDadosEOutrasOperacoes.AutoSize = true;
            this.lblConsultarDadosEOutrasOperacoes.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.lblConsultarDadosEOutrasOperacoes.Location = new System.Drawing.Point(88, 31);
            this.lblConsultarDadosEOutrasOperacoes.Name = "lblConsultarDadosEOutrasOperacoes";
            this.lblConsultarDadosEOutrasOperacoes.Size = new System.Drawing.Size(648, 32);
            this.lblConsultarDadosEOutrasOperacoes.TabIndex = 41;
            this.lblConsultarDadosEOutrasOperacoes.Text = "CONSULTAR DADOS DE CADASTRO E OUTRAS OPERAÇÕES";
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNovaConsulta.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNovaConsulta.FlatAppearance.BorderSize = 0;
            this.btnNovaConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNovaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaConsulta.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNovaConsulta.ForeColor = System.Drawing.Color.White;
            this.btnNovaConsulta.Location = new System.Drawing.Point(926, 108);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnNovaConsulta.Size = new System.Drawing.Size(195, 34);
            this.btnNovaConsulta.TabIndex = 41;
            this.btnNovaConsulta.Text = "NOVA CONSULTA";
            this.btnNovaConsulta.UseVisualStyleBackColor = false;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
            // 
            // btnConsultarCadastro
            // 
            this.btnConsultarCadastro.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarCadastro.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarCadastro.FlatAppearance.BorderSize = 0;
            this.btnConsultarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCadastro.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConsultarCadastro.ForeColor = System.Drawing.Color.White;
            this.btnConsultarCadastro.Location = new System.Drawing.Point(730, 108);
            this.btnConsultarCadastro.Name = "btnConsultarCadastro";
            this.btnConsultarCadastro.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnConsultarCadastro.Size = new System.Drawing.Size(195, 34);
            this.btnConsultarCadastro.TabIndex = 42;
            this.btnConsultarCadastro.Text = "CONSULTAR CADASTRO";
            this.btnConsultarCadastro.UseVisualStyleBackColor = false;
            this.btnConsultarCadastro.Click += new System.EventHandler(this.btnConsultarCadastro_Click);
            // 
            // txtValorLivroRetornado
            // 
            this.txtValorLivroRetornado.BackColor = System.Drawing.SystemColors.Control;
            this.txtValorLivroRetornado.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtValorLivroRetornado.ForeColor = System.Drawing.Color.Black;
            this.txtValorLivroRetornado.Location = new System.Drawing.Point(184, 450);
            this.txtValorLivroRetornado.MaxLength = 150;
            this.txtValorLivroRetornado.Name = "txtValorLivroRetornado";
            this.txtValorLivroRetornado.Size = new System.Drawing.Size(100, 25);
            this.txtValorLivroRetornado.TabIndex = 54;
            // 
            // txtConsultarPorCodigo
            // 
            this.txtConsultarPorCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtConsultarPorCodigo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtConsultarPorCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtConsultarPorCodigo.Location = new System.Drawing.Point(297, 108);
            this.txtConsultarPorCodigo.MaxLength = 8;
            this.txtConsultarPorCodigo.Name = "txtConsultarPorCodigo";
            this.txtConsultarPorCodigo.Size = new System.Drawing.Size(150, 25);
            this.txtConsultarPorCodigo.TabIndex = 47;
            // 
            // lblValorLivroRetornado
            // 
            this.lblValorLivroRetornado.AutoSize = true;
            this.lblValorLivroRetornado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLivroRetornado.Location = new System.Drawing.Point(91, 454);
            this.lblValorLivroRetornado.Name = "lblValorLivroRetornado";
            this.lblValorLivroRetornado.Size = new System.Drawing.Size(87, 16);
            this.lblValorLivroRetornado.TabIndex = 53;
            this.lblValorLivroRetornado.Text = "Valor do livro";
            // 
            // cbConsultarPorTitulo
            // 
            this.cbConsultarPorTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.cbConsultarPorTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.cbConsultarPorTitulo.FormattingEnabled = true;
            this.cbConsultarPorTitulo.Location = new System.Drawing.Point(285, 139);
            this.cbConsultarPorTitulo.Name = "cbConsultarPorTitulo";
            this.cbConsultarPorTitulo.Size = new System.Drawing.Size(300, 25);
            this.cbConsultarPorTitulo.TabIndex = 44;
            this.cbConsultarPorTitulo.SelectedIndexChanged += new System.EventHandler(this.cbConsultarPorTitulo_SelectedIndexChanged);
            // 
            // txtDescricaoRetornada
            // 
            this.txtDescricaoRetornada.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescricaoRetornada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtDescricaoRetornada.ForeColor = System.Drawing.Color.Black;
            this.txtDescricaoRetornada.Location = new System.Drawing.Point(94, 384);
            this.txtDescricaoRetornada.MaxLength = 150;
            this.txtDescricaoRetornada.Multiline = true;
            this.txtDescricaoRetornada.Name = "txtDescricaoRetornada";
            this.txtDescricaoRetornada.Size = new System.Drawing.Size(541, 60);
            this.txtDescricaoRetornada.TabIndex = 52;
            this.toolTipLivros.SetToolTip(this.txtDescricaoRetornada, "Texto curto sobre o livro");
            // 
            // rbConsultarCodLivro
            // 
            this.rbConsultarCodLivro.AutoSize = true;
            this.rbConsultarCodLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConsultarCodLivro.Location = new System.Drawing.Point(94, 110);
            this.rbConsultarCodLivro.Name = "rbConsultarCodLivro";
            this.rbConsultarCodLivro.Size = new System.Drawing.Size(197, 20);
            this.rbConsultarCodLivro.TabIndex = 46;
            this.rbConsultarCodLivro.TabStop = true;
            this.rbConsultarCodLivro.Text = "Consultar por código do livro";
            this.rbConsultarCodLivro.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoRetornada
            // 
            this.lblDescricaoRetornada.AutoSize = true;
            this.lblDescricaoRetornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoRetornada.Location = new System.Drawing.Point(141, 365);
            this.lblDescricaoRetornada.Name = "lblDescricaoRetornada";
            this.lblDescricaoRetornada.Size = new System.Drawing.Size(70, 16);
            this.lblDescricaoRetornada.TabIndex = 51;
            this.lblDescricaoRetornada.Text = "Descrição";
            // 
            // rbConsultarTitulo
            // 
            this.rbConsultarTitulo.AutoSize = true;
            this.rbConsultarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConsultarTitulo.Location = new System.Drawing.Point(94, 141);
            this.rbConsultarTitulo.Name = "rbConsultarTitulo";
            this.rbConsultarTitulo.Size = new System.Drawing.Size(185, 20);
            this.rbConsultarTitulo.TabIndex = 45;
            this.rbConsultarTitulo.TabStop = true;
            this.rbConsultarTitulo.Text = "Consultar por título da obra";
            this.rbConsultarTitulo.UseVisualStyleBackColor = true;
            // 
            // txtTituloRetornado
            // 
            this.txtTituloRetornado.BackColor = System.Drawing.SystemColors.Control;
            this.txtTituloRetornado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTituloRetornado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTituloRetornado.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtTituloRetornado.ForeColor = System.Drawing.Color.Black;
            this.txtTituloRetornado.Location = new System.Drawing.Point(94, 275);
            this.txtTituloRetornado.MaxLength = 150;
            this.txtTituloRetornado.Name = "txtTituloRetornado";
            this.txtTituloRetornado.Size = new System.Drawing.Size(541, 25);
            this.txtTituloRetornado.TabIndex = 46;
            // 
            // txtEditoraRetornada
            // 
            this.txtEditoraRetornada.BackColor = System.Drawing.SystemColors.Control;
            this.txtEditoraRetornada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtEditoraRetornada.ForeColor = System.Drawing.Color.Black;
            this.txtEditoraRetornada.Location = new System.Drawing.Point(385, 306);
            this.txtEditoraRetornada.MaxLength = 150;
            this.txtEditoraRetornada.Name = "txtEditoraRetornada";
            this.txtEditoraRetornada.Size = new System.Drawing.Size(250, 25);
            this.txtEditoraRetornada.TabIndex = 47;
            // 
            // lblTituloRetornado
            // 
            this.lblTituloRetornado.AutoSize = true;
            this.lblTituloRetornado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRetornado.Location = new System.Drawing.Point(141, 256);
            this.lblTituloRetornado.Name = "lblTituloRetornado";
            this.lblTituloRetornado.Size = new System.Drawing.Size(91, 16);
            this.lblTituloRetornado.TabIndex = 44;
            this.lblTituloRetornado.Text = "Título da obra";
            // 
            // lblEditoraRetornada
            // 
            this.lblEditoraRetornada.AutoSize = true;
            this.lblEditoraRetornada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.lblEditoraRetornada.Location = new System.Drawing.Point(329, 309);
            this.lblEditoraRetornada.Name = "lblEditoraRetornada";
            this.lblEditoraRetornada.Size = new System.Drawing.Size(50, 17);
            this.lblEditoraRetornada.TabIndex = 45;
            this.lblEditoraRetornada.Text = "Editora";
            // 
            // lblAnoPublicacaoRetornado
            // 
            this.lblAnoPublicacaoRetornado.AutoSize = true;
            this.lblAnoPublicacaoRetornado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAnoPublicacaoRetornado.Location = new System.Drawing.Point(91, 310);
            this.lblAnoPublicacaoRetornado.Name = "lblAnoPublicacaoRetornado";
            this.lblAnoPublicacaoRetornado.Size = new System.Drawing.Size(121, 16);
            this.lblAnoPublicacaoRetornado.TabIndex = 49;
            this.lblAnoPublicacaoRetornado.Text = "Ano da publicação";
            // 
            // mtxtAnoPublicacaoRetornada
            // 
            this.mtxtAnoPublicacaoRetornada.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtAnoPublicacaoRetornada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtAnoPublicacaoRetornada.Location = new System.Drawing.Point(218, 306);
            this.mtxtAnoPublicacaoRetornada.Mask = "0000";
            this.mtxtAnoPublicacaoRetornada.Name = "mtxtAnoPublicacaoRetornada";
            this.mtxtAnoPublicacaoRetornada.Size = new System.Drawing.Size(100, 25);
            this.mtxtAnoPublicacaoRetornada.TabIndex = 50;
            this.toolTipLivros.SetToolTip(this.mtxtAnoPublicacaoRetornada, "Ex.: 1989");
            this.mtxtAnoPublicacaoRetornada.ValidatingType = typeof(System.DateTime);
            // 
            // FormLivro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1240, 636);
            this.Controls.Add(this.tabControlLivros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLivro";
            this.Text = "FormLivro1";
            this.tabControlLivros.ResumeLayout(false);
            this.tabPageCadastrarLivro.ResumeLayout(false);
            this.tabPageCadastrarLivro.PerformLayout();
            this.panelParte2.ResumeLayout(false);
            this.panelParte2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeAutoresInseridos)).EndInit();
            this.panelParte1.ResumeLayout(false);
            this.panelParte1.PerformLayout();
            this.tabPageConsultarDadosEOutrasOperacoes.ResumeLayout(false);
            this.tabPageConsultarDadosEOutrasOperacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLivros;
        private System.Windows.Forms.TabPage tabPageCadastrarLivro;
        private System.Windows.Forms.TabPage tabPageConsultarDadosEOutrasOperacoes;
        private System.Windows.Forms.Panel panelParte1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox mtxtAnoPublicacao;
        private System.Windows.Forms.Label lblAnoPublicacao;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtValorLivro;
        private System.Windows.Forms.Label lblValorLivro;
        private System.Windows.Forms.Label lblCadastrarCliente;
        private System.Windows.Forms.Label lblInserirParte02;
        private System.Windows.Forms.Panel panelParte2;
        private System.Windows.Forms.Button btnInserirParte01;
        private System.Windows.Forms.Label lblCodAutor;
        private System.Windows.Forms.TextBox txtCodAutor;
        private System.Windows.Forms.Button btnInserirParte02;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private System.Windows.Forms.DataGridView dgvListaDeAutoresInseridos;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.Button btnRemoverAutor;
        private System.Windows.Forms.ToolTip toolTipLivros;
        private System.Windows.Forms.TextBox txtValorLivroRetornado;
        private System.Windows.Forms.TextBox txtConsultarPorCodigo;
        private System.Windows.Forms.Label lblValorLivroRetornado;
        private System.Windows.Forms.ComboBox cbConsultarPorTitulo;
        private System.Windows.Forms.TextBox txtDescricaoRetornada;
        private System.Windows.Forms.RadioButton rbConsultarCodLivro;
        private System.Windows.Forms.Label lblDescricaoRetornada;
        private System.Windows.Forms.RadioButton rbConsultarTitulo;
        private System.Windows.Forms.TextBox txtTituloRetornado;
        private System.Windows.Forms.TextBox txtEditoraRetornada;
        private System.Windows.Forms.Label lblTituloRetornado;
        private System.Windows.Forms.Label lblEditoraRetornada;
        private System.Windows.Forms.Label lblAnoPublicacaoRetornado;
        private System.Windows.Forms.MaskedTextBox mtxtAnoPublicacaoRetornada;
        private System.Windows.Forms.Button btnNovaConsulta;
        private System.Windows.Forms.Button btnConsultarCadastro;
        private System.Windows.Forms.Label lblConsultarDadosEOutrasOperacoes;
        private System.Windows.Forms.DataGridView dgvAutoresLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnDeletarCadastro;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.MaskedTextBox mtxtDataCadastroRetornada;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.Label lblCodFuncionario;
        private System.Windows.Forms.Button btnRemoverAutorInserido;
        private System.Windows.Forms.Button btnInserirNovoAutor;
        private System.Windows.Forms.Label lblInserirOuExcluirCodAutor;
        private System.Windows.Forms.TextBox txtInserirOuExcluirCodAutor;
    }
}