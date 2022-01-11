
namespace Estante_Literária
{
    partial class FormVenda
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
            this.lblCadastrarAutor = new System.Windows.Forms.Label();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.dgvListaDeProdutos = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblValorTotalCompra = new System.Windows.Forms.Label();
            this.txtValorTotalCompra = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnProcurarProduto = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.lblDataPublicacao = new System.Windows.Forms.Label();
            this.txtDataPublicacao = new System.Windows.Forms.TextBox();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.tabControlVendas = new System.Windows.Forms.TabControl();
            this.tabPageRealizarVenda = new System.Windows.Forms.TabPage();
            this.btnIniciarSessão = new System.Windows.Forms.Button();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageConsultarVenda = new System.Windows.Forms.TabPage();
            this.lblMetodoBusca = new System.Windows.Forms.Label();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.btnConsultarDados = new System.Windows.Forms.Button();
            this.rbConsultarCodCliente = new System.Windows.Forms.RadioButton();
            this.rbConsultarCodVenda = new System.Windows.Forms.RadioButton();
            this.rbConsultarCodFuncionario = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblItensVenda = new System.Windows.Forms.Label();
            this.dgvItensVendaRealizada = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVendaRealizada = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipVendas = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeProdutos)).BeginInit();
            this.tabControlVendas.SuspendLayout();
            this.tabPageRealizarVenda.SuspendLayout();
            this.tabPageConsultarVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVendaRealizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaRealizada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastrarAutor
            // 
            this.lblCadastrarAutor.AutoSize = true;
            this.lblCadastrarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarAutor.Location = new System.Drawing.Point(-35, -39);
            this.lblCadastrarAutor.Name = "lblCadastrarAutor";
            this.lblCadastrarAutor.Size = new System.Drawing.Size(213, 29);
            this.lblCadastrarAutor.TabIndex = 36;
            this.lblCadastrarAutor.Text = "REALIZAR VENDA";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdicionarProduto.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnAdicionarProduto.FlatAppearance.BorderSize = 0;
            this.btnAdicionarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarProduto.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(791, 348);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAdicionarProduto.Size = new System.Drawing.Size(179, 34);
            this.btnAdicionarProduto.TabIndex = 37;
            this.btnAdicionarProduto.Text = "ADICIONAR ITEM";
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodProduto.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtCodProduto.ForeColor = System.Drawing.Color.Black;
            this.txtCodProduto.Location = new System.Drawing.Point(59, 74);
            this.txtCodProduto.MaxLength = 8;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(191, 25);
            this.txtCodProduto.TabIndex = 39;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipVendas.SetToolTip(this.txtCodProduto, "O código possui 8 digítos");
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            // 
            // dgvListaDeProdutos
            // 
            this.dgvListaDeProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaDeProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.c,
            this.d});
            this.dgvListaDeProdutos.Location = new System.Drawing.Point(59, 115);
            this.dgvListaDeProdutos.Name = "dgvListaDeProdutos";
            this.dgvListaDeProdutos.Size = new System.Drawing.Size(643, 361);
            this.dgvListaDeProdutos.TabIndex = 40;
            // 
            // a
            // 
            this.a.HeaderText = "Título da obra";
            this.a.Name = "a";
            this.a.Width = 300;
            // 
            // b
            // 
            this.b.HeaderText = "Valor unitário";
            this.b.Name = "b";
            // 
            // c
            // 
            this.c.HeaderText = "Unidades compradas";
            this.c.Name = "c";
            // 
            // d
            // 
            this.d.HeaderText = "Valor total do item";
            this.d.Name = "d";
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(54, 41);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(260, 30);
            this.lblCodProduto.TabIndex = 41;
            this.lblCodProduto.Text = "Insira o código do produto";
            // 
            // lblValorTotalCompra
            // 
            this.lblValorTotalCompra.AutoSize = true;
            this.lblValorTotalCompra.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalCompra.Location = new System.Drawing.Point(76, 490);
            this.lblValorTotalCompra.Name = "lblValorTotalCompra";
            this.lblValorTotalCompra.Size = new System.Drawing.Size(328, 45);
            this.lblValorTotalCompra.TabIndex = 43;
            this.lblValorTotalCompra.Text = "Valor total da compra";
            // 
            // txtValorTotalCompra
            // 
            this.txtValorTotalCompra.BackColor = System.Drawing.SystemColors.Control;
            this.txtValorTotalCompra.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.txtValorTotalCompra.ForeColor = System.Drawing.Color.Black;
            this.txtValorTotalCompra.Location = new System.Drawing.Point(420, 482);
            this.txtValorTotalCompra.MaxLength = 8;
            this.txtValorTotalCompra.Multiline = true;
            this.txtValorTotalCompra.Name = "txtValorTotalCompra";
            this.txtValorTotalCompra.ReadOnly = true;
            this.txtValorTotalCompra.Size = new System.Drawing.Size(282, 60);
            this.txtValorTotalCompra.TabIndex = 42;
            this.txtValorTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lblQuantidade.Location = new System.Drawing.Point(895, 319);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(94, 21);
            this.lblQuantidade.TabIndex = 45;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantidade.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.Location = new System.Drawing.Point(999, 317);
            this.txtQuantidade.MaxLength = 8;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(150, 25);
            this.txtQuantidade.TabIndex = 44;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtValorTotal.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.txtValorTotal.ForeColor = System.Drawing.Color.Black;
            this.txtValorTotal.Location = new System.Drawing.Point(791, 388);
            this.txtValorTotal.MaxLength = 8;
            this.txtValorTotal.Multiline = true;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(358, 52);
            this.txtValorTotal.TabIndex = 48;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipVendas.SetToolTip(this.txtValorTotal, "Valor do item");
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFinalizarVenda.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnFinalizarVenda.FlatAppearance.BorderSize = 0;
            this.btnFinalizarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarVenda.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(791, 477);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnFinalizarVenda.Size = new System.Drawing.Size(360, 34);
            this.btnFinalizarVenda.TabIndex = 52;
            this.btnFinalizarVenda.Text = "FINALIZAR VENDA";
            this.btnFinalizarVenda.UseVisualStyleBackColor = false;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarVenda.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCancelarVenda.FlatAppearance.BorderSize = 0;
            this.btnCancelarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenda.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelarVenda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarVenda.Location = new System.Drawing.Point(791, 517);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancelarVenda.Size = new System.Drawing.Size(360, 34);
            this.btnCancelarVenda.TabIndex = 50;
            this.btnCancelarVenda.Text = "CANCELAR VENDA";
            this.btnCancelarVenda.UseVisualStyleBackColor = false;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // btnProcurarProduto
            // 
            this.btnProcurarProduto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProcurarProduto.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnProcurarProduto.FlatAppearance.BorderSize = 0;
            this.btnProcurarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarProduto.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarProduto.ForeColor = System.Drawing.Color.White;
            this.btnProcurarProduto.Location = new System.Drawing.Point(386, 58);
            this.btnProcurarProduto.Name = "btnProcurarProduto";
            this.btnProcurarProduto.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnProcurarProduto.Size = new System.Drawing.Size(207, 34);
            this.btnProcurarProduto.TabIndex = 53;
            this.btnProcurarProduto.Text = "PROCURAR PRODUTO";
            this.btnProcurarProduto.UseVisualStyleBackColor = false;
            this.btnProcurarProduto.Click += new System.EventHandler(this.btnProcurarProduto_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(791, 50);
            this.txtTitulo.MaxLength = 150;
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(358, 40);
            this.txtTitulo.TabIndex = 55;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(841, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 16);
            this.lblTitulo.TabIndex = 54;
            this.lblTitulo.Text = "Título da obra";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomeAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeAutor.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtNomeAutor.ForeColor = System.Drawing.Color.Black;
            this.txtNomeAutor.Location = new System.Drawing.Point(791, 114);
            this.txtNomeAutor.MaxLength = 150;
            this.txtNomeAutor.Multiline = true;
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.ReadOnly = true;
            this.txtNomeAutor.Size = new System.Drawing.Size(359, 40);
            this.txtNomeAutor.TabIndex = 57;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(841, 95);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(39, 16);
            this.lblAutor.TabIndex = 56;
            this.lblAutor.Text = "Autor";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitario.Location = new System.Drawing.Point(841, 253);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(86, 16);
            this.lblValorUnitario.TabIndex = 59;
            this.lblValorUnitario.Text = "Valor unitário";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.BackColor = System.Drawing.SystemColors.Control;
            this.txtValorUnitario.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtValorUnitario.ForeColor = System.Drawing.Color.Black;
            this.txtValorUnitario.Location = new System.Drawing.Point(791, 272);
            this.txtValorUnitario.MaxLength = 8;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.ReadOnly = true;
            this.txtValorUnitario.Size = new System.Drawing.Size(359, 25);
            this.txtValorUnitario.TabIndex = 58;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Location = new System.Drawing.Point(841, 159);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(51, 16);
            this.lblEditora.TabIndex = 61;
            this.lblEditora.Text = "Editora";
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.SystemColors.Control;
            this.txtEditora.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtEditora.ForeColor = System.Drawing.Color.Black;
            this.txtEditora.Location = new System.Drawing.Point(791, 178);
            this.txtEditora.MaxLength = 8;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.ReadOnly = true;
            this.txtEditora.Size = new System.Drawing.Size(359, 25);
            this.txtEditora.TabIndex = 60;
            // 
            // lblDataPublicacao
            // 
            this.lblDataPublicacao.AutoSize = true;
            this.lblDataPublicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPublicacao.Location = new System.Drawing.Point(841, 206);
            this.lblDataPublicacao.Name = "lblDataPublicacao";
            this.lblDataPublicacao.Size = new System.Drawing.Size(121, 16);
            this.lblDataPublicacao.TabIndex = 63;
            this.lblDataPublicacao.Text = "Ano de publicação";
            // 
            // txtDataPublicacao
            // 
            this.txtDataPublicacao.BackColor = System.Drawing.SystemColors.Control;
            this.txtDataPublicacao.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtDataPublicacao.ForeColor = System.Drawing.Color.Black;
            this.txtDataPublicacao.Location = new System.Drawing.Point(791, 225);
            this.txtDataPublicacao.MaxLength = 8;
            this.txtDataPublicacao.Name = "txtDataPublicacao";
            this.txtDataPublicacao.ReadOnly = true;
            this.txtDataPublicacao.Size = new System.Drawing.Size(359, 25);
            this.txtDataPublicacao.TabIndex = 62;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemoverProduto.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnRemoverProduto.FlatAppearance.BorderSize = 0;
            this.btnRemoverProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnRemoverProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverProduto.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRemoverProduto.ForeColor = System.Drawing.Color.White;
            this.btnRemoverProduto.Location = new System.Drawing.Point(971, 348);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnRemoverProduto.Size = new System.Drawing.Size(179, 34);
            this.btnRemoverProduto.TabIndex = 64;
            this.btnRemoverProduto.Text = "REMOVER ITEM";
            this.btnRemoverProduto.UseVisualStyleBackColor = false;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lblCodCliente.Location = new System.Drawing.Point(855, 448);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(134, 21);
            this.lblCodCliente.TabIndex = 66;
            this.lblCodCliente.Text = "Código do cliente:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodCliente.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtCodCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCodCliente.Location = new System.Drawing.Point(1000, 446);
            this.txtCodCliente.MaxLength = 8;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(150, 25);
            this.txtCodCliente.TabIndex = 65;
            this.toolTipVendas.SetToolTip(this.txtCodCliente, "O código possui 8 digítos");
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCliente_KeyPress);
            // 
            // tabControlVendas
            // 
            this.tabControlVendas.Controls.Add(this.tabPageRealizarVenda);
            this.tabControlVendas.Controls.Add(this.tabPageConsultarVenda);
            this.tabControlVendas.Location = new System.Drawing.Point(12, 12);
            this.tabControlVendas.Name = "tabControlVendas";
            this.tabControlVendas.SelectedIndex = 0;
            this.tabControlVendas.Size = new System.Drawing.Size(1216, 612);
            this.tabControlVendas.TabIndex = 67;
            // 
            // tabPageRealizarVenda
            // 
            this.tabPageRealizarVenda.Controls.Add(this.btnIniciarSessão);
            this.tabPageRealizarVenda.Controls.Add(this.lblCodFuncionario);
            this.tabPageRealizarVenda.Controls.Add(this.txtCodFuncionario);
            this.tabPageRealizarVenda.Controls.Add(this.label1);
            this.tabPageRealizarVenda.Controls.Add(this.btnProcurarProduto);
            this.tabPageRealizarVenda.Controls.Add(this.lblValorTotalCompra);
            this.tabPageRealizarVenda.Controls.Add(this.lblCodCliente);
            this.tabPageRealizarVenda.Controls.Add(this.txtValorTotalCompra);
            this.tabPageRealizarVenda.Controls.Add(this.btnAdicionarProduto);
            this.tabPageRealizarVenda.Controls.Add(this.lblCodProduto);
            this.tabPageRealizarVenda.Controls.Add(this.txtCodCliente);
            this.tabPageRealizarVenda.Controls.Add(this.dgvListaDeProdutos);
            this.tabPageRealizarVenda.Controls.Add(this.txtCodProduto);
            this.tabPageRealizarVenda.Controls.Add(this.txtQuantidade);
            this.tabPageRealizarVenda.Controls.Add(this.lblCadastrarAutor);
            this.tabPageRealizarVenda.Controls.Add(this.btnRemoverProduto);
            this.tabPageRealizarVenda.Controls.Add(this.lblQuantidade);
            this.tabPageRealizarVenda.Controls.Add(this.lblDataPublicacao);
            this.tabPageRealizarVenda.Controls.Add(this.txtValorTotal);
            this.tabPageRealizarVenda.Controls.Add(this.txtDataPublicacao);
            this.tabPageRealizarVenda.Controls.Add(this.lblEditora);
            this.tabPageRealizarVenda.Controls.Add(this.btnCancelarVenda);
            this.tabPageRealizarVenda.Controls.Add(this.txtEditora);
            this.tabPageRealizarVenda.Controls.Add(this.btnFinalizarVenda);
            this.tabPageRealizarVenda.Controls.Add(this.lblValorUnitario);
            this.tabPageRealizarVenda.Controls.Add(this.lblTitulo);
            this.tabPageRealizarVenda.Controls.Add(this.txtValorUnitario);
            this.tabPageRealizarVenda.Controls.Add(this.txtTitulo);
            this.tabPageRealizarVenda.Controls.Add(this.txtNomeAutor);
            this.tabPageRealizarVenda.Controls.Add(this.lblAutor);
            this.tabPageRealizarVenda.Location = new System.Drawing.Point(4, 25);
            this.tabPageRealizarVenda.Name = "tabPageRealizarVenda";
            this.tabPageRealizarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRealizarVenda.Size = new System.Drawing.Size(1208, 583);
            this.tabPageRealizarVenda.TabIndex = 0;
            this.tabPageRealizarVenda.Text = "REALIZAR VENDA";
            this.tabPageRealizarVenda.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSessão
            // 
            this.btnIniciarSessão.BackColor = System.Drawing.Color.SeaGreen;
            this.btnIniciarSessão.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnIniciarSessão.FlatAppearance.BorderSize = 0;
            this.btnIniciarSessão.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnIniciarSessão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSessão.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSessão.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSessão.Location = new System.Drawing.Point(474, 12);
            this.btnIniciarSessão.Name = "btnIniciarSessão";
            this.btnIniciarSessão.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnIniciarSessão.Size = new System.Drawing.Size(207, 34);
            this.btnIniciarSessão.TabIndex = 72;
            this.btnIniciarSessão.Text = "INICIAR SESSÃO";
            this.btnIniciarSessão.UseVisualStyleBackColor = false;
            this.btnIniciarSessão.Click += new System.EventHandler(this.btnIniciarSessão_Click);
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lblCodFuncionario.Location = new System.Drawing.Point(55, 18);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(216, 21);
            this.lblCodFuncionario.TabIndex = 71;
            this.lblCodFuncionario.Text = "Insira o código de funcionário";
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodFuncionario.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtCodFuncionario.ForeColor = System.Drawing.Color.Black;
            this.txtCodFuncionario.Location = new System.Drawing.Point(277, 16);
            this.txtCodFuncionario.MaxLength = 8;
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.Size = new System.Drawing.Size(191, 25);
            this.txtCodFuncionario.TabIndex = 70;
            this.txtCodFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipVendas.SetToolTip(this.txtCodFuncionario, "O código possui 8 digítos");
            this.txtCodFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFuncionario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 69;
            // 
            // tabPageConsultarVenda
            // 
            this.tabPageConsultarVenda.Controls.Add(this.lblMetodoBusca);
            this.tabPageConsultarVenda.Controls.Add(this.btnNovaConsulta);
            this.tabPageConsultarVenda.Controls.Add(this.btnConsultarDados);
            this.tabPageConsultarVenda.Controls.Add(this.rbConsultarCodCliente);
            this.tabPageConsultarVenda.Controls.Add(this.rbConsultarCodVenda);
            this.tabPageConsultarVenda.Controls.Add(this.rbConsultarCodFuncionario);
            this.tabPageConsultarVenda.Controls.Add(this.txtCodigo);
            this.tabPageConsultarVenda.Controls.Add(this.lblItensVenda);
            this.tabPageConsultarVenda.Controls.Add(this.dgvItensVendaRealizada);
            this.tabPageConsultarVenda.Controls.Add(this.dgvVendaRealizada);
            this.tabPageConsultarVenda.Location = new System.Drawing.Point(4, 25);
            this.tabPageConsultarVenda.Name = "tabPageConsultarVenda";
            this.tabPageConsultarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultarVenda.Size = new System.Drawing.Size(1208, 583);
            this.tabPageConsultarVenda.TabIndex = 1;
            this.tabPageConsultarVenda.Text = "CONSULTAR DADOS DE VENDA";
            this.tabPageConsultarVenda.UseVisualStyleBackColor = true;
            // 
            // lblMetodoBusca
            // 
            this.lblMetodoBusca.AutoSize = true;
            this.lblMetodoBusca.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoBusca.Location = new System.Drawing.Point(54, 115);
            this.lblMetodoBusca.Name = "lblMetodoBusca";
            this.lblMetodoBusca.Size = new System.Drawing.Size(175, 30);
            this.lblMetodoBusca.TabIndex = 71;
            this.lblMetodoBusca.Text = "Método de busca";
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
            this.btnNovaConsulta.Location = new System.Drawing.Point(255, 261);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnNovaConsulta.Size = new System.Drawing.Size(195, 34);
            this.btnNovaConsulta.TabIndex = 74;
            this.btnNovaConsulta.Text = "NOVA CONSULTA";
            this.btnNovaConsulta.UseVisualStyleBackColor = false;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
            // 
            // btnConsultarDados
            // 
            this.btnConsultarDados.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarDados.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarDados.FlatAppearance.BorderSize = 0;
            this.btnConsultarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarDados.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConsultarDados.ForeColor = System.Drawing.Color.White;
            this.btnConsultarDados.Location = new System.Drawing.Point(59, 261);
            this.btnConsultarDados.Name = "btnConsultarDados";
            this.btnConsultarDados.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnConsultarDados.Size = new System.Drawing.Size(195, 34);
            this.btnConsultarDados.TabIndex = 68;
            this.btnConsultarDados.Text = "CONSULTAR DADOS";
            this.btnConsultarDados.UseVisualStyleBackColor = false;
            this.btnConsultarDados.Click += new System.EventHandler(this.btnConsultarDados_Click);
            // 
            // rbConsultarCodCliente
            // 
            this.rbConsultarCodCliente.AutoSize = true;
            this.rbConsultarCodCliente.Location = new System.Drawing.Point(59, 200);
            this.rbConsultarCodCliente.Name = "rbConsultarCodCliente";
            this.rbConsultarCodCliente.Size = new System.Drawing.Size(211, 20);
            this.rbConsultarCodCliente.TabIndex = 73;
            this.rbConsultarCodCliente.TabStop = true;
            this.rbConsultarCodCliente.Text = "Consultar por código de cliente";
            this.rbConsultarCodCliente.UseVisualStyleBackColor = true;
            // 
            // rbConsultarCodVenda
            // 
            this.rbConsultarCodVenda.AutoSize = true;
            this.rbConsultarCodVenda.Location = new System.Drawing.Point(59, 148);
            this.rbConsultarCodVenda.Name = "rbConsultarCodVenda";
            this.rbConsultarCodVenda.Size = new System.Drawing.Size(210, 20);
            this.rbConsultarCodVenda.TabIndex = 72;
            this.rbConsultarCodVenda.TabStop = true;
            this.rbConsultarCodVenda.Text = "Consultar por código de venda";
            this.rbConsultarCodVenda.UseVisualStyleBackColor = true;
            // 
            // rbConsultarCodFuncionario
            // 
            this.rbConsultarCodFuncionario.AutoSize = true;
            this.rbConsultarCodFuncionario.Location = new System.Drawing.Point(59, 174);
            this.rbConsultarCodFuncionario.Name = "rbConsultarCodFuncionario";
            this.rbConsultarCodFuncionario.Size = new System.Drawing.Size(237, 20);
            this.rbConsultarCodFuncionario.TabIndex = 71;
            this.rbConsultarCodFuncionario.TabStop = true;
            this.rbConsultarCodFuncionario.Text = "Consultar por código de funcionário";
            this.rbConsultarCodFuncionario.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(59, 226);
            this.txtCodigo.MaxLength = 8;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(191, 25);
            this.txtCodigo.TabIndex = 68;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipVendas.SetToolTip(this.txtCodigo, "O código possui 8 digítos");
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblItensVenda
            // 
            this.lblItensVenda.AutoSize = true;
            this.lblItensVenda.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItensVenda.Location = new System.Drawing.Point(500, 329);
            this.lblItensVenda.Name = "lblItensVenda";
            this.lblItensVenda.Size = new System.Drawing.Size(238, 30);
            this.lblItensVenda.TabIndex = 70;
            this.lblItensVenda.Text = "Itens da venda realizada";
            // 
            // dgvItensVendaRealizada
            // 
            this.dgvItensVendaRealizada.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItensVendaRealizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVendaRealizada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvItensVendaRealizada.Location = new System.Drawing.Point(505, 362);
            this.dgvItensVendaRealizada.Name = "dgvItensVendaRealizada";
            this.dgvItensVendaRealizada.Size = new System.Drawing.Size(643, 180);
            this.dgvItensVendaRealizada.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Título da obra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor unitário";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Unidades compradas";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Valor total do item";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dgvVendaRealizada
            // 
            this.dgvVendaRealizada.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVendaRealizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendaRealizada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ValorVenda});
            this.dgvVendaRealizada.Location = new System.Drawing.Point(505, 115);
            this.dgvVendaRealizada.Name = "dgvVendaRealizada";
            this.dgvVendaRealizada.Size = new System.Drawing.Size(643, 180);
            this.dgvVendaRealizada.TabIndex = 68;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código da venda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Data da venda";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Código funcionário";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Código do cliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // ValorVenda
            // 
            this.ValorVenda.HeaderText = "Valor da venda";
            this.ValorVenda.Name = "ValorVenda";
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 636);
            this.Controls.Add(this.tabControlVendas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeProdutos)).EndInit();
            this.tabControlVendas.ResumeLayout(false);
            this.tabPageRealizarVenda.ResumeLayout(false);
            this.tabPageRealizarVenda.PerformLayout();
            this.tabPageConsultarVenda.ResumeLayout(false);
            this.tabPageConsultarVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVendaRealizada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaRealizada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCadastrarAutor;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.DataGridView dgvListaDeProdutos;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblValorTotalCompra;
        private System.Windows.Forms.TextBox txtValorTotalCompra;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnProcurarProduto;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lblDataPublicacao;
        private System.Windows.Forms.TextBox txtDataPublicacao;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TabControl tabControlVendas;
        private System.Windows.Forms.TabPage tabPageRealizarVenda;
        private System.Windows.Forms.TabPage tabPageConsultarVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarSessão;
        private System.Windows.Forms.Label lblCodFuncionario;
        private System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.ToolTip toolTipVendas;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblItensVenda;
        private System.Windows.Forms.DataGridView dgvItensVendaRealizada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dgvVendaRealizada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.RadioButton rbConsultarCodVenda;
        private System.Windows.Forms.RadioButton rbConsultarCodFuncionario;
        private System.Windows.Forms.RadioButton rbConsultarCodCliente;
        private System.Windows.Forms.Button btnConsultarDados;
        private System.Windows.Forms.Button btnNovaConsulta;
        private System.Windows.Forms.Label lblMetodoBusca;
    }
}