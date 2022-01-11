
namespace Estante_Literária
{
    partial class FormCliente
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
            this.lblCadastrarCliente = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelDadosCadastrados = new System.Windows.Forms.Panel();
            this.mtxtTelefoneReserva = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefonePrincipal = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefonePrincipal = new System.Windows.Forms.Label();
            this.lblTelefoneReserva = new System.Windows.Forms.Label();
            this.mtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblConsultarDadosEOutrasOperacoes = new System.Windows.Forms.Label();
            this.panelConsultarDadosEOutrasOperacoes = new System.Windows.Forms.Panel();
            this.mtxtDataCadastroRetornada = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefoneReservaRetornado = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefonePrincipalRetornado = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataNascimentoRetornada = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeRetornado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtCPFRetornado = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailRetornado = new System.Windows.Forms.TextBox();
            this.btnConsultarCadastro = new System.Windows.Forms.Button();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtConsultarPorCodCliente = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.rbConsultarCodCliente = new System.Windows.Forms.RadioButton();
            this.rbConsultarNome = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbConsultarPorNome = new System.Windows.Forms.ComboBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.lblNomeRetornado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletarCaadastro = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.toolTipClientes = new System.Windows.Forms.ToolTip(this.components);
            this.panelDadosCadastrados.SuspendLayout();
            this.panelConsultarDadosEOutrasOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastrarCliente
            // 
            this.lblCadastrarCliente.AutoSize = true;
            this.lblCadastrarCliente.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.lblCadastrarCliente.Location = new System.Drawing.Point(199, 37);
            this.lblCadastrarCliente.Name = "lblCadastrarCliente";
            this.lblCadastrarCliente.Size = new System.Drawing.Size(240, 32);
            this.lblCadastrarCliente.TabIndex = 27;
            this.lblCadastrarCliente.Text = "CADASTRAR CLIENTE";
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
            this.btnCadastrar.Location = new System.Drawing.Point(846, 226);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(195, 34);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "CADASTRAR CLIENTE";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panelDadosCadastrados
            // 
            this.panelDadosCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.panelDadosCadastrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDadosCadastrados.Controls.Add(this.mtxtTelefoneReserva);
            this.panelDadosCadastrados.Controls.Add(this.mtxtTelefonePrincipal);
            this.panelDadosCadastrados.Controls.Add(this.mtxtCPF);
            this.panelDadosCadastrados.Controls.Add(this.txtEmail);
            this.panelDadosCadastrados.Controls.Add(this.lblTelefonePrincipal);
            this.panelDadosCadastrados.Controls.Add(this.lblTelefoneReserva);
            this.panelDadosCadastrados.Controls.Add(this.mtxtDataNascimento);
            this.panelDadosCadastrados.Controls.Add(this.txtNome);
            this.panelDadosCadastrados.Controls.Add(this.lblEmail);
            this.panelDadosCadastrados.Controls.Add(this.lblCPF);
            this.panelDadosCadastrados.Controls.Add(this.lblDataNascimento);
            this.panelDadosCadastrados.Controls.Add(this.lblNome);
            this.panelDadosCadastrados.Location = new System.Drawing.Point(205, 72);
            this.panelDadosCadastrados.Name = "panelDadosCadastrados";
            this.panelDadosCadastrados.Size = new System.Drawing.Size(836, 148);
            this.panelDadosCadastrados.TabIndex = 25;
            // 
            // mtxtTelefoneReserva
            // 
            this.mtxtTelefoneReserva.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtTelefoneReserva.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtTelefoneReserva.Location = new System.Drawing.Point(663, 60);
            this.mtxtTelefoneReserva.Mask = "(00)00000-0000";
            this.mtxtTelefoneReserva.Name = "mtxtTelefoneReserva";
            this.mtxtTelefoneReserva.Size = new System.Drawing.Size(150, 25);
            this.mtxtTelefoneReserva.TabIndex = 35;
            // 
            // mtxtTelefonePrincipal
            // 
            this.mtxtTelefonePrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtTelefonePrincipal.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtTelefonePrincipal.Location = new System.Drawing.Point(663, 30);
            this.mtxtTelefonePrincipal.Mask = "(00)00000-0000";
            this.mtxtTelefonePrincipal.Name = "mtxtTelefonePrincipal";
            this.mtxtTelefonePrincipal.Size = new System.Drawing.Size(150, 25);
            this.mtxtTelefonePrincipal.TabIndex = 33;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtCPF.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtCPF.Location = new System.Drawing.Point(244, 61);
            this.mtxtCPF.Mask = "000.000.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(150, 25);
            this.mtxtCPF.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(513, 91);
            this.txtEmail.MaxLength = 150;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 25);
            this.txtEmail.TabIndex = 7;
            // 
            // lblTelefonePrincipal
            // 
            this.lblTelefonePrincipal.AutoSize = true;
            this.lblTelefonePrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTelefonePrincipal.Location = new System.Drawing.Point(572, 34);
            this.lblTelefonePrincipal.Name = "lblTelefonePrincipal";
            this.lblTelefonePrincipal.Size = new System.Drawing.Size(85, 16);
            this.lblTelefonePrincipal.TabIndex = 2;
            this.lblTelefonePrincipal.Text = "Tel. principal";
            // 
            // lblTelefoneReserva
            // 
            this.lblTelefoneReserva.AutoSize = true;
            this.lblTelefoneReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTelefoneReserva.Location = new System.Drawing.Point(514, 65);
            this.lblTelefoneReserva.Name = "lblTelefoneReserva";
            this.lblTelefoneReserva.Size = new System.Drawing.Size(143, 16);
            this.lblTelefoneReserva.TabIndex = 3;
            this.lblTelefoneReserva.Text = "Tel. reserva (opcional)";
            // 
            // mtxtDataNascimento
            // 
            this.mtxtDataNascimento.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtDataNascimento.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtDataNascimento.Location = new System.Drawing.Point(245, 92);
            this.mtxtDataNascimento.Mask = "00/00/0000";
            this.mtxtDataNascimento.Name = "mtxtDataNascimento";
            this.mtxtDataNascimento.Size = new System.Drawing.Size(150, 25);
            this.mtxtDataNascimento.TabIndex = 34;
            this.mtxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(245, 30);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 25);
            this.txtNome.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.lblEmail.Location = new System.Drawing.Point(463, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCPF.Location = new System.Drawing.Point(205, 65);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 16);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDataNascimento.Location = new System.Drawing.Point(22, 96);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(217, 16);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "Data de nascimento (dd/mm/aaaa)";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNome.Location = new System.Drawing.Point(135, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(104, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome completo";
            // 
            // lblConsultarDadosEOutrasOperacoes
            // 
            this.lblConsultarDadosEOutrasOperacoes.AutoSize = true;
            this.lblConsultarDadosEOutrasOperacoes.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.lblConsultarDadosEOutrasOperacoes.Location = new System.Drawing.Point(199, 269);
            this.lblConsultarDadosEOutrasOperacoes.Name = "lblConsultarDadosEOutrasOperacoes";
            this.lblConsultarDadosEOutrasOperacoes.Size = new System.Drawing.Size(648, 32);
            this.lblConsultarDadosEOutrasOperacoes.TabIndex = 28;
            this.lblConsultarDadosEOutrasOperacoes.Text = "CONSULTAR DADOS DE CADASTRO E OUTRAS OPERAÇÕES";
            // 
            // panelConsultarDadosEOutrasOperacoes
            // 
            this.panelConsultarDadosEOutrasOperacoes.BackColor = System.Drawing.Color.Transparent;
            this.panelConsultarDadosEOutrasOperacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.mtxtDataCadastroRetornada);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.mtxtTelefoneReservaRetornado);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.mtxtTelefonePrincipalRetornado);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.mtxtDataNascimentoRetornada);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.txtNomeRetornado);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.label2);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.mtxtCPFRetornado);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.txtEmailRetornado);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.btnConsultarCadastro);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.txtCodCliente);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.txtConsultarPorCodCliente);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.lblDataCadastro);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.rbConsultarCodCliente);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.rbConsultarNome);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.label1);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.label5);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.cbConsultarPorNome);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.lblCodCliente);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.lblNomeRetornado);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.label4);
            this.panelConsultarDadosEOutrasOperacoes.Controls.Add(this.label3);
            this.panelConsultarDadosEOutrasOperacoes.Location = new System.Drawing.Point(205, 304);
            this.panelConsultarDadosEOutrasOperacoes.Name = "panelConsultarDadosEOutrasOperacoes";
            this.panelConsultarDadosEOutrasOperacoes.Size = new System.Drawing.Size(836, 256);
            this.panelConsultarDadosEOutrasOperacoes.TabIndex = 29;
            // 
            // mtxtDataCadastroRetornada
            // 
            this.mtxtDataCadastroRetornada.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtDataCadastroRetornada.Enabled = false;
            this.mtxtDataCadastroRetornada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtDataCadastroRetornada.Location = new System.Drawing.Point(660, 108);
            this.mtxtDataCadastroRetornada.Mask = "00/00/0000 90:00";
            this.mtxtDataCadastroRetornada.Name = "mtxtDataCadastroRetornada";
            this.mtxtDataCadastroRetornada.ReadOnly = true;
            this.mtxtDataCadastroRetornada.Size = new System.Drawing.Size(153, 25);
            this.mtxtDataCadastroRetornada.TabIndex = 58;
            this.mtxtDataCadastroRetornada.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtTelefoneReservaRetornado
            // 
            this.mtxtTelefoneReservaRetornado.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtTelefoneReservaRetornado.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtTelefoneReservaRetornado.Location = new System.Drawing.Point(663, 169);
            this.mtxtTelefoneReservaRetornado.Mask = "(00)00000-0000";
            this.mtxtTelefoneReservaRetornado.Name = "mtxtTelefoneReservaRetornado";
            this.mtxtTelefoneReservaRetornado.Size = new System.Drawing.Size(150, 25);
            this.mtxtTelefoneReservaRetornado.TabIndex = 57;
            // 
            // mtxtTelefonePrincipalRetornado
            // 
            this.mtxtTelefonePrincipalRetornado.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtTelefonePrincipalRetornado.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtTelefonePrincipalRetornado.Location = new System.Drawing.Point(663, 138);
            this.mtxtTelefonePrincipalRetornado.Mask = "(00)00000-0000";
            this.mtxtTelefonePrincipalRetornado.Name = "mtxtTelefonePrincipalRetornado";
            this.mtxtTelefonePrincipalRetornado.Size = new System.Drawing.Size(150, 25);
            this.mtxtTelefonePrincipalRetornado.TabIndex = 56;
            // 
            // mtxtDataNascimentoRetornada
            // 
            this.mtxtDataNascimentoRetornada.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtDataNascimentoRetornada.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtDataNascimentoRetornada.Location = new System.Drawing.Point(243, 200);
            this.mtxtDataNascimentoRetornada.Mask = "00/00/0000";
            this.mtxtDataNascimentoRetornada.Name = "mtxtDataNascimentoRetornada";
            this.mtxtDataNascimentoRetornada.Size = new System.Drawing.Size(150, 25);
            this.mtxtDataNascimentoRetornada.TabIndex = 36;
            this.mtxtDataNascimentoRetornada.ValidatingType = typeof(System.DateTime);
            // 
            // txtNomeRetornado
            // 
            this.txtNomeRetornado.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomeRetornado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeRetornado.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtNomeRetornado.ForeColor = System.Drawing.Color.Black;
            this.txtNomeRetornado.Location = new System.Drawing.Point(244, 138);
            this.txtNomeRetornado.Name = "txtNomeRetornado";
            this.txtNomeRetornado.Size = new System.Drawing.Size(300, 25);
            this.txtNomeRetornado.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(461, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "E-mail";
            // 
            // mtxtCPFRetornado
            // 
            this.mtxtCPFRetornado.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtCPFRetornado.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.mtxtCPFRetornado.Location = new System.Drawing.Point(243, 169);
            this.mtxtCPFRetornado.Mask = "000.000.000-00";
            this.mtxtCPFRetornado.Name = "mtxtCPFRetornado";
            this.mtxtCPFRetornado.Size = new System.Drawing.Size(150, 25);
            this.mtxtCPFRetornado.TabIndex = 55;
            // 
            // txtEmailRetornado
            // 
            this.txtEmailRetornado.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmailRetornado.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtEmailRetornado.ForeColor = System.Drawing.Color.Black;
            this.txtEmailRetornado.Location = new System.Drawing.Point(513, 200);
            this.txtEmailRetornado.Name = "txtEmailRetornado";
            this.txtEmailRetornado.Size = new System.Drawing.Size(300, 25);
            this.txtEmailRetornado.TabIndex = 50;
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
            this.btnConsultarCadastro.Location = new System.Drawing.Point(618, 30);
            this.btnConsultarCadastro.Name = "btnConsultarCadastro";
            this.btnConsultarCadastro.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnConsultarCadastro.Size = new System.Drawing.Size(195, 34);
            this.btnConsultarCadastro.TabIndex = 18;
            this.btnConsultarCadastro.Text = "CONSULTAR CADASTRO";
            this.btnConsultarCadastro.UseVisualStyleBackColor = false;
            this.btnConsultarCadastro.Click += new System.EventHandler(this.btnConsultarCadastro_Click);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtCodCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCodCliente.Location = new System.Drawing.Point(244, 107);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(150, 25);
            this.txtCodCliente.TabIndex = 39;
            // 
            // txtConsultarPorCodCliente
            // 
            this.txtConsultarPorCodCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtConsultarPorCodCliente.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.txtConsultarPorCodCliente.ForeColor = System.Drawing.Color.Black;
            this.txtConsultarPorCodCliente.Location = new System.Drawing.Point(243, 30);
            this.txtConsultarPorCodCliente.MaxLength = 8;
            this.txtConsultarPorCodCliente.Name = "txtConsultarPorCodCliente";
            this.txtConsultarPorCodCliente.Size = new System.Drawing.Size(150, 25);
            this.txtConsultarPorCodCliente.TabIndex = 38;
            this.toolTipClientes.SetToolTip(this.txtConsultarPorCodCliente, "O código possui 8 digítos");
            this.txtConsultarPorCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultarPorCodCliente_KeyPress);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDataCadastro.Location = new System.Drawing.Point(542, 112);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(112, 16);
            this.lblDataCadastro.TabIndex = 36;
            this.lblDataCadastro.Text = "Data de cadastro";
            // 
            // rbConsultarCodCliente
            // 
            this.rbConsultarCodCliente.AutoSize = true;
            this.rbConsultarCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbConsultarCodCliente.Location = new System.Drawing.Point(26, 32);
            this.rbConsultarCodCliente.Name = "rbConsultarCodCliente";
            this.rbConsultarCodCliente.Size = new System.Drawing.Size(211, 20);
            this.rbConsultarCodCliente.TabIndex = 21;
            this.rbConsultarCodCliente.TabStop = true;
            this.rbConsultarCodCliente.Text = "Consultar por código de cliente";
            this.rbConsultarCodCliente.UseVisualStyleBackColor = true;
            // 
            // rbConsultarNome
            // 
            this.rbConsultarNome.AutoSize = true;
            this.rbConsultarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbConsultarNome.Location = new System.Drawing.Point(27, 63);
            this.rbConsultarNome.Name = "rbConsultarNome";
            this.rbConsultarNome.Size = new System.Drawing.Size(142, 20);
            this.rbConsultarNome.TabIndex = 20;
            this.rbConsultarNome.TabStop = true;
            this.rbConsultarNome.Text = "Consultar por nome";
            this.rbConsultarNome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(20, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Data de nascimento (dd/mm/aaaa)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(203, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "CPF";
            // 
            // cbConsultarPorNome
            // 
            this.cbConsultarPorNome.BackColor = System.Drawing.SystemColors.Control;
            this.cbConsultarPorNome.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.cbConsultarPorNome.FormattingEnabled = true;
            this.cbConsultarPorNome.Location = new System.Drawing.Point(175, 61);
            this.cbConsultarPorNome.Name = "cbConsultarPorNome";
            this.cbConsultarPorNome.Size = new System.Drawing.Size(300, 25);
            this.cbConsultarPorNome.TabIndex = 16;
            this.toolTipClientes.SetToolTip(this.cbConsultarPorNome, "Nome ou parte do nome do cliente");
            this.cbConsultarPorNome.SelectedIndexChanged += new System.EventHandler(this.cbConsultarPorNome_SelectedIndexChanged);
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCodCliente.Location = new System.Drawing.Point(126, 111);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(113, 16);
            this.lblCodCliente.TabIndex = 35;
            this.lblCodCliente.Text = "Código de cliente";
            // 
            // lblNomeRetornado
            // 
            this.lblNomeRetornado.AutoSize = true;
            this.lblNomeRetornado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNomeRetornado.Location = new System.Drawing.Point(135, 142);
            this.lblNomeRetornado.Name = "lblNomeRetornado";
            this.lblNomeRetornado.Size = new System.Drawing.Size(104, 16);
            this.lblNomeRetornado.TabIndex = 43;
            this.lblNomeRetornado.Text = "Nome completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(572, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Tel. principal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(514, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tel. reserva (opcional)";
            // 
            // btnDeletarCaadastro
            // 
            this.btnDeletarCaadastro.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeletarCaadastro.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnDeletarCaadastro.FlatAppearance.BorderSize = 0;
            this.btnDeletarCaadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnDeletarCaadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarCaadastro.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeletarCaadastro.ForeColor = System.Drawing.Color.White;
            this.btnDeletarCaadastro.Location = new System.Drawing.Point(791, 566);
            this.btnDeletarCaadastro.Name = "btnDeletarCaadastro";
            this.btnDeletarCaadastro.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnDeletarCaadastro.Size = new System.Drawing.Size(250, 34);
            this.btnDeletarCaadastro.TabIndex = 31;
            this.btnDeletarCaadastro.Text = "APAGAR CADASTRO DE CLIENTE";
            this.btnDeletarCaadastro.UseVisualStyleBackColor = false;
            this.btnDeletarCaadastro.Click += new System.EventHandler(this.btnDeletarCaadastro_Click);
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
            this.btnAtualizarDados.Location = new System.Drawing.Point(595, 566);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAtualizarDados.Size = new System.Drawing.Size(195, 34);
            this.btnAtualizarDados.TabIndex = 30;
            this.btnAtualizarDados.Text = "ATUALIZAR DADOS";
            this.btnAtualizarDados.UseVisualStyleBackColor = false;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
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
            this.btnNovaConsulta.Location = new System.Drawing.Point(399, 566);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnNovaConsulta.Size = new System.Drawing.Size(195, 34);
            this.btnNovaConsulta.TabIndex = 32;
            this.btnNovaConsulta.Text = "NOVA CONSULTA";
            this.btnNovaConsulta.UseVisualStyleBackColor = false;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 636);
            this.Controls.Add(this.btnNovaConsulta);
            this.Controls.Add(this.btnDeletarCaadastro);
            this.Controls.Add(this.btnAtualizarDados);
            this.Controls.Add(this.panelConsultarDadosEOutrasOperacoes);
            this.Controls.Add(this.lblConsultarDadosEOutrasOperacoes);
            this.Controls.Add(this.lblCadastrarCliente);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panelDadosCadastrados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.panelDadosCadastrados.ResumeLayout(false);
            this.panelDadosCadastrados.PerformLayout();
            this.panelConsultarDadosEOutrasOperacoes.ResumeLayout(false);
            this.panelConsultarDadosEOutrasOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastrarCliente;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelDadosCadastrados;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefoneReserva;
        private System.Windows.Forms.Label lblTelefonePrincipal;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblConsultarDadosEOutrasOperacoes;
        private System.Windows.Forms.Panel panelConsultarDadosEOutrasOperacoes;
        private System.Windows.Forms.TextBox txtEmailRetornado;
        private System.Windows.Forms.TextBox txtNomeRetornado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNomeRetornado;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtConsultarPorCodCliente;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.RadioButton rbConsultarCodCliente;
        private System.Windows.Forms.RadioButton rbConsultarNome;
        private System.Windows.Forms.Button btnConsultarCadastro;
        private System.Windows.Forms.ComboBox cbConsultarPorNome;
        private System.Windows.Forms.Button btnDeletarCaadastro;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Button btnNovaConsulta;
        private System.Windows.Forms.MaskedTextBox mtxtTelefoneReserva;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonePrincipal;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimento;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCPFRetornado;
        private System.Windows.Forms.MaskedTextBox mtxtTelefoneReservaRetornado;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonePrincipalRetornado;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimentoRetornada;
        private System.Windows.Forms.MaskedTextBox mtxtDataCadastroRetornada;
        private System.Windows.Forms.ToolTip toolTipClientes;
    }
}