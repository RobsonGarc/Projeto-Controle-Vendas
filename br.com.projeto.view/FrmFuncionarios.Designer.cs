
namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class FrmFuncionarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbnivel = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btncep = new System.Windows.Forms.Button();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabelaFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionários";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 86);
            this.panel1.TabIndex = 1;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabPage1);
            this.tabClientes.Controls.Add(this.tabPage2);
            this.tabClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClientes.Location = new System.Drawing.Point(0, 92);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(945, 468);
            this.tabClientes.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbnivel);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.cbcargo);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.txtsenha);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.btncep);
            this.tabPage1.Controls.Add(this.cbuf);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.txtcpf);
            this.tabPage1.Controls.Add(this.txtrg);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbnivel
            // 
            this.cbnivel.FormattingEnabled = true;
            this.cbnivel.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.cbnivel.Location = new System.Drawing.Point(622, 223);
            this.cbnivel.Name = "cbnivel";
            this.cbnivel.Size = new System.Drawing.Size(121, 28);
            this.cbnivel.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(567, 228);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 20);
            this.label19.TabIndex = 42;
            this.label19.Text = "Nível:";
            // 
            // cbcargo
            // 
            this.cbcargo.FormattingEnabled = true;
            this.cbcargo.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor",
            "Estagiário"});
            this.cbcargo.Location = new System.Drawing.Point(622, 173);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(121, 28);
            this.cbcargo.TabIndex = 41;
            this.cbcargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(560, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 20);
            this.label18.TabIndex = 40;
            this.label18.Text = "Cargo:";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(622, 126);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(209, 26);
            this.txtsenha.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(553, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 38;
            this.label17.Text = "Senha:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // btncep
            // 
            this.btncep.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncep.ForeColor = System.Drawing.Color.White;
            this.btncep.Location = new System.Drawing.Point(221, 223);
            this.btncep.Name = "btncep";
            this.btncep.Size = new System.Drawing.Size(95, 31);
            this.btncep.TabIndex = 37;
            this.btncep.Text = "Pesquisar";
            this.btncep.UseVisualStyleBackColor = false;
            // 
            // cbuf
            // 
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbuf.Location = new System.Drawing.Point(554, 371);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(88, 28);
            this.cbuf.TabIndex = 32;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(92, 225);
            this.txtcep.Mask = "00000-9999";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(113, 26);
            this.txtcep.TabIndex = 31;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(363, 175);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(134, 26);
            this.txtcelular.TabIndex = 30;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(92, 175);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(125, 26);
            this.txttelefone.TabIndex = 29;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(769, 74);
            this.txtcpf.Mask = "###.###.###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(149, 26);
            this.txtcpf.TabIndex = 28;
            this.txtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtcpf_MaskInputRejected);
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(554, 74);
            this.txtrg.Mask = "##.###.###-##";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(149, 26);
            this.txtrg.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(510, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "RG:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(719, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "CPF:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(802, 275);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 26);
            this.txtnumero.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(727, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Número:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(41, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "CEP:";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(92, 275);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(595, 26);
            this.txtendereco.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(4, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Endereço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(513, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "UF:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(554, 324);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(348, 26);
            this.txtcidade.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(485, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cidade:";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(126, 371);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(337, 26);
            this.txtbairro.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(57, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bairro:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(126, 324);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(337, 26);
            this.txtcomplemento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(1, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Complemento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(295, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(11, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone:";
            // 
            // txtemail
            // 
            this.txtemail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtemail.Location = new System.Drawing.Point(78, 126);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(419, 26);
            this.txtemail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(17, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "e-mail:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(78, 74);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(419, 26);
            this.txtnome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(86, 23);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 26);
            this.txtcodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabelaFuncionarios);
            this.tabPage2.Controls.Add(this.btnpesquisa);
            this.tabPage2.Controls.Add(this.txtpesquisa);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaFuncionarios
            // 
            this.tabelaFuncionarios.AllowUserToAddRows = false;
            this.tabelaFuncionarios.AllowUserToDeleteRows = false;
            this.tabelaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFuncionarios.Location = new System.Drawing.Point(32, 87);
            this.tabelaFuncionarios.Name = "tabelaFuncionarios";
            this.tabelaFuncionarios.ReadOnly = true;
            this.tabelaFuncionarios.Size = new System.Drawing.Size(866, 319);
            this.tabelaFuncionarios.TabIndex = 35;
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisa.ForeColor = System.Drawing.Color.White;
            this.btnpesquisa.Location = new System.Drawing.Point(546, 27);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(90, 32);
            this.btnpesquisa.TabIndex = 34;
            this.btnpesquisa.Text = "Pesquisar";
            this.btnpesquisa.UseVisualStyleBackColor = false;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(93, 33);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(419, 26);
            this.txtpesquisa.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(32, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome:";
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(608, 566);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(90, 32);
            this.btneditar.TabIndex = 40;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(492, 566);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(90, 32);
            this.btnexcluir.TabIndex = 39;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(377, 566);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(90, 32);
            this.btnsalvar.TabIndex = 38;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.Color.White;
            this.btnnovo.Location = new System.Drawing.Point(267, 566);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(90, 32);
            this.btnnovo.TabIndex = 37;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 629);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabClientes);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFuncionarios";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btncep;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tabelaFuncionarios;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.ComboBox cbcargo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbnivel;
        private System.Windows.Forms.Label label19;
    }
}