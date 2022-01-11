
namespace Estante_Literária
{
    partial class FormAutor
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
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.btnDeletarCadastro = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.panelConsultarDadosEOutrasOperacoes = new System.Windows.Forms.Panel();
            this.mtxtDataNascimentoRetornada = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricaoRetornada = new System.Windows.Forms.TextBox();
            this.txtNomeRetornado = new System.Windows.Forms.TextBox();
            this.lblDataNascimentoRetornada = new System.Windows.Forms.Label();
            this.lblDescricaoRetornada = new System.Windows.Forms.Label();
            this.lblNomeRetornado = new System.Windows.Forms.Label();
            this.mtxtDataCadastroRetornada = new System.Windows.Forms.MaskedTextBox();
            this.txtCodAutor = new System.Windows.Forms.TextBox();
            this.btnConsultarCadastro = new System.Windows.Forms.Button();
            this.txtConsultarPorCodAutor = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblCodAutor = new System.Windows.Forms.Label();
            this.rbConsultarCodAutor = new System.Windows.Forms.RadioButton();
            this.rbConsultarNome = new System.Windows.Forms.RadioButton();
            this.cbConsultarPorNome = new System.Windows.Forms.ComboBox();
            this.lblConsultarDadosEOutrasOperacoes = new System.Windows.Forms.Label();
            this.lblCadastrarAutor = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelDadosCadastrados = new System.Windows.Forms.Panel();
            this.mtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.toolTipAutores = new System.Windows.Forms.ToolTip(this.components);
            this.panelConsultarDadosEOutrasOperacoes.SuspendLayout();
            this.panelDadosCadastrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNovaConsulta.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnNovaConsulta.FlatAppearance.BorderSize = 0;
            this.btnNovaConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnNovaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaConsulta.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNovaConsulta.ForeColor = System.Drawing.Color.White;
            this.btnNovaConsulta.Location = new System.Drawing.Point(399, 597);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnNovaConsulta.Size = new System.Drawing.Size(195, 34);
            this.btnNovaConsulta.TabIndex = 40;
            this.btnNovaConsulta.Text = "NOVA CONSULTA";
            this.btnNovaConsulta.UseVisualStyleBackColor = false;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
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
            this.btnDeletarCadastro.Location = new System.Drawing.Point(791, 597);
            this.btnDeletarCadastro.Name = "btnDeletarCadastro";
            this.btnDeletarCadastro.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnDeletarCadastro.Size = new System.Drawing.Size(250, 34);
            this.btnDeletarCadastro.TabIndex = 39;
            this.btnDeletarCadastro.Text = "APAGAR CADASTRO DE AUTOR";
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
            this.btnAtualizarDados.Location = new System.Drawing.Point(595, 597);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAtualizarDados.Size = new System.Drawing.Size(195, 34);
            this.btnAtualizarDados.TabIndex = 38;
            this.btnAtualizarDados.Text = "ATUALIZAR DADOS";
            this.btnAtualizarDados.UseVisualStyleBackColor = false;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // panelConsultarDadosEOutrasOperacoes
            // 
            this.panelConsultarDadosEOutrasOperacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.mtxtDataNascimentoRetornada);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.txtDescricaoRetornada);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.txtNomeRetornado);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.lblDataNascimentoRetornada);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.lblDescricaoRetornada);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.lblNomeRetornado);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.mtxtDataCadastroRetornada);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.txtCodAutor);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.btnConsultarCadastro);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.txtConsultarPorCodAutor);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.lblDataCadastro);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.lblCodAutor);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.rbConsultarCodAutor);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.rbConsultarNome);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.cbConsultarPorNome);
            this.panelConsultarDadosEOutrasOperacoes.Location = new System.Drawing.Point(205, 303);
            this.panelConsultarDadosEOutrasOperacoes.Name = "panelConsultarDadosEOutrasOperacoes";
            this.panelConsultarDadosEOutrasOperacoes.Size = new System.Drawing.Size(836, 288);
            this.panelConsultarDadosEOutrasOperacoes.TabIndex = 37;
            // 
            // mtxtDataNascimentoRetornada
            // 
            this.mtxtDataNascimentoRetornada.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtDataNascimentoRetornada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtDataNascimentoRetornada.Location = new System.Drawing.Point(317, 166);
            this.mtxtDataNascimentoRetornada.Mask = "00/00/0000";
            this.mtxtDataNascimentoRetornada.Name = "mtxtDataNascimentoRetornada";
            this.mtxtDataNascimentoRetornada.Size = new System.Drawing.Size(150, 25);
            this.mtxtDataNascimentoRetornada.TabIndex = 64;
            this.mtxtDataNascimentoRetornada.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescricaoRetornada
            // 
            this.txtDescricaoRetornada.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescricaoRetornada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtDescricaoRetornada.ForeColor = System.Drawing.Color.Black;
            this.txtDescricaoRetornada.Location = new System.Drawing.Point(317, 197);
            this.txtDescricaoRetornada.MaxLength = 150;
            this.txtDescricaoRetornada.Multiline = true;
            this.txtDescricaoRetornada.Name = "txtDescricaoRetornada";
            this.txtDescricaoRetornada.Size = new System.Drawing.Size(471, 60);
            this.txtDescricaoRetornada.TabIndex = 63;
            // 
            // txtNomeRetornado
            // 
            this.txtNomeRetornado.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomeRetornado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeRetornado.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtNomeRetornado.ForeColor = System.Drawing.Color.Black;
            this.txtNomeRetornado.Location = new System.Drawing.Point(317, 135);
            this.txtNomeRetornado.MaxLength = 150;
            this.txtNomeRetornado.Name = "txtNomeRetornado";
            this.txtNomeRetornado.Size = new System.Drawing.Size(471, 25);
            this.txtNomeRetornado.TabIndex = 62;
            // 
            // lblDataNascimentoRetornada
            // 
            this.lblDataNascimentoRetornada.AutoSize = true;
            this.lblDataNascimentoRetornada.Location = new System.Drawing.Point(94, 170);
            this.lblDataNascimentoRetornada.Name = "lblDataNascimentoRetornada";
            this.lblDataNascimentoRetornada.Size = new System.Drawing.Size(217, 16);
            this.lblDataNascimentoRetornada.TabIndex = 61;
            this.lblDataNascimentoRetornada.Text = "Data de nascimento (dd/mm/aaaa)";
            // 
            // lblDescricaoRetornada
            // 
            this.lblDescricaoRetornada.AutoSize = true;
            this.lblDescricaoRetornada.Location = new System.Drawing.Point(240, 201);
            this.lblDescricaoRetornada.Name = "lblDescricaoRetornada";
            this.lblDescricaoRetornada.Size = new System.Drawing.Size(70, 16);
            this.lblDescricaoRetornada.TabIndex = 60;
            this.lblDescricaoRetornada.Text = "Descrição";
            // 
            // lblNomeRetornado
            // 
            this.lblNomeRetornado.AutoSize = true;
            this.lblNomeRetornado.Location = new System.Drawing.Point(265, 139);
            this.lblNomeRetornado.Name = "lblNomeRetornado";
            this.lblNomeRetornado.Size = new System.Drawing.Size(45, 16);
            this.lblNomeRetornado.TabIndex = 59;
            this.lblNomeRetornado.Text = "Nome";
            // 
            // mtxtDataCadastroRetornada
            // 
            this.mtxtDataCadastroRetornada.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtDataCadastroRetornada.Enabled = false;
            this.mtxtDataCadastroRetornada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtDataCadastroRetornada.Location = new System.Drawing.Point(637, 104);
            this.mtxtDataCadastroRetornada.Mask = "00/00/0000 90:00";
            this.mtxtDataCadastroRetornada.Name = "mtxtDataCadastroRetornada";
            this.mtxtDataCadastroRetornada.ReadOnly = true;
            this.mtxtDataCadastroRetornada.Size = new System.Drawing.Size(150, 25);
            this.mtxtDataCadastroRetornada.TabIndex = 58;
            this.mtxtDataCadastroRetornada.ValidatingType = typeof(System.DateTime);
            // 
            // txtCodAutor
            // 
            this.txtCodAutor.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodAutor.Enabled = false;
            this.txtCodAutor.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtCodAutor.ForeColor = System.Drawing.Color.Black;
            this.txtCodAutor.Location = new System.Drawing.Point(317, 104);
            this.txtCodAutor.Name = "txtCodAutor";
            this.txtCodAutor.ReadOnly = true;
            this.txtCodAutor.Size = new System.Drawing.Size(100, 25);
            this.txtCodAutor.TabIndex = 39;
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
            this.btnConsultarCadastro.Location = new System.Drawing.Point(593, 31);
            this.btnConsultarCadastro.Name = "btnConsultarCadastro";
            this.btnConsultarCadastro.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnConsultarCadastro.Size = new System.Drawing.Size(195, 34);
            this.btnConsultarCadastro.TabIndex = 18;
            this.btnConsultarCadastro.Text = "CONSULTAR CADASTRO";
            this.btnConsultarCadastro.UseVisualStyleBackColor = false;
            this.btnConsultarCadastro.Click += new System.EventHandler(this.btnConsultarCadastro_Click);
            // 
            // txtConsultarPorCodAutor
            // 
            this.txtConsultarPorCodAutor.BackColor = System.Drawing.SystemColors.Control;
            this.txtConsultarPorCodAutor.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtConsultarPorCodAutor.ForeColor = System.Drawing.Color.Black;
            this.txtConsultarPorCodAutor.Location = new System.Drawing.Point(254, 29);
            this.txtConsultarPorCodAutor.MaxLength = 8;
            this.txtConsultarPorCodAutor.Name = "txtConsultarPorCodAutor";
            this.txtConsultarPorCodAutor.Size = new System.Drawing.Size(150, 25);
            this.txtConsultarPorCodAutor.TabIndex = 38;
            this.toolTipAutores.SetToolTip(this.txtConsultarPorCodAutor, "O código possui 8 digítos");
            this.txtConsultarPorCodAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultarPorCodAutor_KeyPress);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(519, 108);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(112, 16);
            this.lblDataCadastro.TabIndex = 36;
            this.lblDataCadastro.Text = "Data de cadastro";
            // 
            // lblCodAutor
            // 
            this.lblCodAutor.AutoSize = true;
            this.lblCodAutor.Location = new System.Drawing.Point(207, 108);
            this.lblCodAutor.Name = "lblCodAutor";
            this.lblCodAutor.Size = new System.Drawing.Size(104, 16);
            this.lblCodAutor.TabIndex = 35;
            this.lblCodAutor.Text = "Código de autor";
            // 
            // rbConsultarCodAutor
            // 
            this.rbConsultarCodAutor.AutoSize = true;
            this.rbConsultarCodAutor.Location = new System.Drawing.Point(46, 31);
            this.rbConsultarCodAutor.Name = "rbConsultarCodAutor";
            this.rbConsultarCodAutor.Size = new System.Drawing.Size(202, 20);
            this.rbConsultarCodAutor.TabIndex = 21;
            this.rbConsultarCodAutor.TabStop = true;
            this.rbConsultarCodAutor.Text = "Consultar por código de autor";
            this.rbConsultarCodAutor.UseVisualStyleBackColor = true;
            // 
            // rbConsultarNome
            // 
            this.rbConsultarNome.AutoSize = true;
            this.rbConsultarNome.Location = new System.Drawing.Point(46, 62);
            this.rbConsultarNome.Name = "rbConsultarNome";
            this.rbConsultarNome.Size = new System.Drawing.Size(142, 20);
            this.rbConsultarNome.TabIndex = 20;
            this.rbConsultarNome.TabStop = true;
            this.rbConsultarNome.Text = "Consultar por nome";
            this.rbConsultarNome.UseVisualStyleBackColor = true;
            // 
            // cbConsultarPorNome
            // 
            this.cbConsultarPorNome.BackColor = System.Drawing.SystemColors.Control;
            this.cbConsultarPorNome.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.cbConsultarPorNome.FormattingEnabled = true;
            this.cbConsultarPorNome.Location = new System.Drawing.Point(194, 60);
            this.cbConsultarPorNome.Name = "cbConsultarPorNome";
            this.cbConsultarPorNome.Size = new System.Drawing.Size(300, 25);
            this.cbConsultarPorNome.TabIndex = 16;
            this.toolTipAutores.SetToolTip(this.cbConsultarPorNome, "Nome ou parte do nome do autor");
            this.cbConsultarPorNome.SelectedIndexChanged += new System.EventHandler(this.cbConsultarPorNome_SelectedIndexChanged);
            // 
            // lblConsultarDadosEOutrasOperacoes
            // 
            this.lblConsultarDadosEOutrasOperacoes.AutoSize = true;
            this.lblConsultarDadosEOutrasOperacoes.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.lblConsultarDadosEOutrasOperacoes.Location = new System.Drawing.Point(199, 268);
            this.lblConsultarDadosEOutrasOperacoes.Name = "lblConsultarDadosEOutrasOperacoes";
            this.lblConsultarDadosEOutrasOperacoes.Size = new System.Drawing.Size(648, 32);
            this.lblConsultarDadosEOutrasOperacoes.TabIndex = 36;
            this.lblConsultarDadosEOutrasOperacoes.Text = "CONSULTAR DADOS DE CADASTRO E OUTRAS OPERAÇÕES";
            // 
            // lblCadastrarAutor
            // 
            this.lblCadastrarAutor.AutoSize = true;
            this.lblCadastrarAutor.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.lblCadastrarAutor.Location = new System.Drawing.Point(202, 5);
            this.lblCadastrarAutor.Name = "lblCadastrarAutor";
            this.lblCadastrarAutor.Size = new System.Drawing.Size(229, 32);
            this.lblCadastrarAutor.TabIndex = 35;
            this.lblCadastrarAutor.Text = "CADASTRAR AUTOR";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(846, 231);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(195, 34);
            this.btnCadastrar.TabIndex = 34;
            this.btnCadastrar.Text = "CADASTRAR AUTOR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panelDadosCadastrados
            // 
            this.panelDadosCadastrados.BackColor = System.Drawing.SystemColors.Control;
            this.panelDadosCadastrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDadosCadastrados.Controls.Add(this.mtxtDataNascimento);
            this.panelDadosCadastrados.Controls.Add(this.txtDescricao);
            this.panelDadosCadastrados.Controls.Add(this.txtNome);
            this.panelDadosCadastrados.Controls.Add(this.lblDataNascimento);
            this.panelDadosCadastrados.Controls.Add(this.lblDescricao);
            this.panelDadosCadastrados.Controls.Add(this.lblNome);
            this.panelDadosCadastrados.Location = new System.Drawing.Point(205, 41);
            this.panelDadosCadastrados.Name = "panelDadosCadastrados";
            this.panelDadosCadastrados.Size = new System.Drawing.Size(836, 184);
            this.panelDadosCadastrados.TabIndex = 33;
            // 
            // mtxtDataNascimento
            // 
            this.mtxtDataNascimento.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtDataNascimento.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtDataNascimento.Location = new System.Drawing.Point(293, 61);
            this.mtxtDataNascimento.Mask = "00/00/0000";
            this.mtxtDataNascimento.Name = "mtxtDataNascimento";
            this.mtxtDataNascimento.Size = new System.Drawing.Size(150, 25);
            this.mtxtDataNascimento.TabIndex = 34;
            this.mtxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescricao.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(293, 92);
            this.txtDescricao.MaxLength = 150;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(471, 60);
            this.txtDescricao.TabIndex = 7;
            this.toolTipAutores.SetToolTip(this.txtDescricao, "Texto curto sobre a bibliografia do autor");
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(293, 30);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(471, 25);
            this.txtNome.TabIndex = 6;
            this.toolTipAutores.SetToolTip(this.txtNome, "Nome presente nas obras do autor");
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(70, 65);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(217, 16);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "Data de nascimento (dd/mm/aaaa)\r\n";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(217, 96);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(70, 16);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(240, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // FormAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 636);
            this.Controls.Add(this.btnNovaConsulta);
            this.Controls.Add(this.btnDeletarCadastro);
            this.Controls.Add(this.btnAtualizarDados);
            this.Controls.Add(this.panelConsultarDadosEOutrasOperacoes);
            this.Controls.Add(this.lblConsultarDadosEOutrasOperacoes);
            this.Controls.Add(this.lblCadastrarAutor);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panelDadosCadastrados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAutor";
            this.Text = "FormAutor";
            this.panelConsultarDadosEOutrasOperacoes.ResumeLayout(false);
            this.panelConsultarDadosEOutrasOperacoes.PerformLayout();
            this.panelDadosCadastrados.ResumeLayout(false);
            this.panelDadosCadastrados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaConsulta;
        private System.Windows.Forms.Button btnDeletarCadastro;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Panel panelConsultarDadosEOutrasOperacoes;
        private System.Windows.Forms.MaskedTextBox mtxtDataCadastroRetornada;
        private System.Windows.Forms.TextBox txtCodAutor;
        private System.Windows.Forms.TextBox txtConsultarPorCodAutor;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblCodAutor;
        private System.Windows.Forms.RadioButton rbConsultarCodAutor;
        private System.Windows.Forms.RadioButton rbConsultarNome;
        private System.Windows.Forms.Button btnConsultarCadastro;
        private System.Windows.Forms.ComboBox cbConsultarPorNome;
        private System.Windows.Forms.Label lblConsultarDadosEOutrasOperacoes;
        private System.Windows.Forms.Label lblCadastrarAutor;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelDadosCadastrados;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimento;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimentoRetornada;
        private System.Windows.Forms.TextBox txtDescricaoRetornada;
        private System.Windows.Forms.TextBox txtNomeRetornado;
        private System.Windows.Forms.Label lblDataNascimentoRetornada;
        private System.Windows.Forms.Label lblDescricaoRetornada;
        private System.Windows.Forms.Label lblNomeRetornado;
        private System.Windows.Forms.ToolTip toolTipAutores;
    }
}