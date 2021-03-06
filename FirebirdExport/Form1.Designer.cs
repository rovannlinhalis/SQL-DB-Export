
namespace DBSQLExport
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxSGDB = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCharSet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDialect = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPorta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxServidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxSQLQuery = new System.Windows.Forms.TextBox();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPastaExportar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSeparador = new System.Windows.Forms.TextBox();
            this.buttonExecutaQuery = new System.Windows.Forms.Button();
            this.buttonAbrirArquivo = new System.Windows.Forms.Button();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonSQLQuery = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTabela = new System.Windows.Forms.Button();
            this.buttonExportarTodasTabelas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExecutaQuery);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBoxSGDB);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.buttonAbrirArquivo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxCharSet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxDialect);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxPorta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxDatabase);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxServidor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxSenha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxUsuario);
            this.panel1.Controls.Add(this.buttonConectar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 152);
            this.panel1.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(79, 107);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 21);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.Text = "SQL Query";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 107);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 21);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tabelas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Driver Conexão";
            // 
            // comboBoxSGDB
            // 
            this.comboBoxSGDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSGDB.FormattingEnabled = true;
            this.comboBoxSGDB.Location = new System.Drawing.Point(501, 74);
            this.comboBoxSGDB.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSGDB.Name = "comboBoxSGDB";
            this.comboBoxSGDB.Size = new System.Drawing.Size(196, 23);
            this.comboBoxSGDB.TabIndex = 19;
            // 
            // labelStatus
            // 
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStatus.Location = new System.Drawing.Point(0, 133);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(1126, 19);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelStatus.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Charset";
            // 
            // textBoxCharSet
            // 
            this.textBoxCharSet.Location = new System.Drawing.Point(381, 74);
            this.textBoxCharSet.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCharSet.Name = "textBoxCharSet";
            this.textBoxCharSet.Size = new System.Drawing.Size(112, 24);
            this.textBoxCharSet.TabIndex = 14;
            this.textBoxCharSet.Text = "ISO8859_1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dialect";
            // 
            // textBoxDialect
            // 
            this.textBoxDialect.Location = new System.Drawing.Point(381, 28);
            this.textBoxDialect.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDialect.Name = "textBoxDialect";
            this.textBoxDialect.Size = new System.Drawing.Size(112, 24);
            this.textBoxDialect.TabIndex = 12;
            this.textBoxDialect.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Porta";
            // 
            // textBoxPorta
            // 
            this.textBoxPorta.Location = new System.Drawing.Point(262, 28);
            this.textBoxPorta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPorta.Name = "textBoxPorta";
            this.textBoxPorta.Size = new System.Drawing.Size(112, 24);
            this.textBoxPorta.TabIndex = 10;
            this.textBoxPorta.Text = "3050";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Banco de Dados";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(137, 74);
            this.textBoxDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(197, 24);
            this.textBoxDatabase.TabIndex = 8;
            this.textBoxDatabase.Text = "arquivo.fdb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Servidor";
            // 
            // textBoxServidor
            // 
            this.textBoxServidor.Location = new System.Drawing.Point(137, 28);
            this.textBoxServidor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxServidor.Name = "textBoxServidor";
            this.textBoxServidor.Size = new System.Drawing.Size(116, 24);
            this.textBoxServidor.TabIndex = 6;
            this.textBoxServidor.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(14, 74);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(116, 24);
            this.textBoxSenha.TabIndex = 4;
            this.textBoxSenha.Text = "masterkey";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(14, 28);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(116, 24);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.Text = "SYSDBA";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 152);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSQLQuery);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewDados);
            this.splitContainer1.Size = new System.Drawing.Size(1126, 307);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 307);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxSQLQuery
            // 
            this.textBoxSQLQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxSQLQuery.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.textBoxSQLQuery.Location = new System.Drawing.Point(228, 0);
            this.textBoxSQLQuery.Multiline = true;
            this.textBoxSQLQuery.Name = "textBoxSQLQuery";
            this.textBoxSQLQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSQLQuery.Size = new System.Drawing.Size(100, 307);
            this.textBoxSQLQuery.TabIndex = 1;
            this.textBoxSQLQuery.Visible = false;
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AllowUserToDeleteRows = false;
            this.dataGridViewDados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDados.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDados.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.ReadOnly = true;
            this.dataGridViewDados.Size = new System.Drawing.Size(794, 307);
            this.dataGridViewDados.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSQLQuery);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxPastaExportar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxSeparador);
            this.panel2.Controls.Add(this.buttonTabela);
            this.panel2.Controls.Add(this.buttonExportarTodasTabelas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 101);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Pasta Destino";
            // 
            // textBoxPastaExportar
            // 
            this.textBoxPastaExportar.Location = new System.Drawing.Point(11, 22);
            this.textBoxPastaExportar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPastaExportar.Name = "textBoxPastaExportar";
            this.textBoxPastaExportar.Size = new System.Drawing.Size(265, 24);
            this.textBoxPastaExportar.TabIndex = 14;
            this.textBoxPastaExportar.Text = "\\Exportado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Separador";
            // 
            // textBoxSeparador
            // 
            this.textBoxSeparador.Location = new System.Drawing.Point(324, 24);
            this.textBoxSeparador.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSeparador.Name = "textBoxSeparador";
            this.textBoxSeparador.Size = new System.Drawing.Size(112, 24);
            this.textBoxSeparador.TabIndex = 12;
            this.textBoxSeparador.Text = ";";
            // 
            // buttonExecutaQuery
            // 
            this.buttonExecutaQuery.Enabled = false;
            this.buttonExecutaQuery.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonExecutaQuery.FlatAppearance.BorderSize = 2;
            this.buttonExecutaQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExecutaQuery.Image = global::DBSQLExport.Properties.Resources.arrowright;
            this.buttonExecutaQuery.Location = new System.Drawing.Point(174, 101);
            this.buttonExecutaQuery.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExecutaQuery.Name = "buttonExecutaQuery";
            this.buttonExecutaQuery.Size = new System.Drawing.Size(32, 32);
            this.buttonExecutaQuery.TabIndex = 22;
            this.buttonExecutaQuery.UseVisualStyleBackColor = true;
            this.buttonExecutaQuery.Click += new System.EventHandler(this.buttonExecutaQuery_Click);
            // 
            // buttonAbrirArquivo
            // 
            this.buttonAbrirArquivo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAbrirArquivo.FlatAppearance.BorderSize = 2;
            this.buttonAbrirArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrirArquivo.Image = global::DBSQLExport.Properties.Resources.opened_folder_24;
            this.buttonAbrirArquivo.Location = new System.Drawing.Point(342, 66);
            this.buttonAbrirArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAbrirArquivo.Name = "buttonAbrirArquivo";
            this.buttonAbrirArquivo.Size = new System.Drawing.Size(32, 32);
            this.buttonAbrirArquivo.TabIndex = 16;
            this.buttonAbrirArquivo.UseVisualStyleBackColor = true;
            this.buttonAbrirArquivo.Click += new System.EventHandler(this.buttonAbrirArquivo_Click);
            // 
            // buttonConectar
            // 
            this.buttonConectar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonConectar.FlatAppearance.BorderSize = 2;
            this.buttonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConectar.Image = global::DBSQLExport.Properties.Resources.connected_48;
            this.buttonConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConectar.Location = new System.Drawing.Point(920, 10);
            this.buttonConectar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Padding = new System.Windows.Forms.Padding(15, 0, 50, 0);
            this.buttonConectar.Size = new System.Drawing.Size(193, 86);
            this.buttonConectar.TabIndex = 1;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonSQLQuery
            // 
            this.buttonSQLQuery.Enabled = false;
            this.buttonSQLQuery.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonSQLQuery.FlatAppearance.BorderSize = 2;
            this.buttonSQLQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSQLQuery.Image = global::DBSQLExport.Properties.Resources.symlink_directory_48;
            this.buttonSQLQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSQLQuery.Location = new System.Drawing.Point(451, 8);
            this.buttonSQLQuery.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSQLQuery.Name = "buttonSQLQuery";
            this.buttonSQLQuery.Padding = new System.Windows.Forms.Padding(15, 0, 50, 0);
            this.buttonSQLQuery.Size = new System.Drawing.Size(216, 86);
            this.buttonSQLQuery.TabIndex = 19;
            this.buttonSQLQuery.Text = "SQL Query";
            this.buttonSQLQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSQLQuery.UseVisualStyleBackColor = true;
            this.buttonSQLQuery.Click += new System.EventHandler(this.buttonSQLQuery_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DBSQLExport.Properties.Resources.opened_folder_24;
            this.button2.Location = new System.Drawing.Point(284, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonFolderExport_Click);
            // 
            // buttonTabela
            // 
            this.buttonTabela.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonTabela.FlatAppearance.BorderSize = 2;
            this.buttonTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabela.Image = global::DBSQLExport.Properties.Resources.symlink_directory_48;
            this.buttonTabela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabela.Location = new System.Drawing.Point(675, 8);
            this.buttonTabela.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTabela.Name = "buttonTabela";
            this.buttonTabela.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.buttonTabela.Size = new System.Drawing.Size(216, 86);
            this.buttonTabela.TabIndex = 1;
            this.buttonTabela.Text = "Tabela Selecionada";
            this.buttonTabela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTabela.UseVisualStyleBackColor = true;
            this.buttonTabela.Click += new System.EventHandler(this.buttonExportarSelecionada_Click);
            // 
            // buttonExportarTodasTabelas
            // 
            this.buttonExportarTodasTabelas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonExportarTodasTabelas.FlatAppearance.BorderSize = 2;
            this.buttonExportarTodasTabelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportarTodasTabelas.Image = global::DBSQLExport.Properties.Resources.symlink_directory_48;
            this.buttonExportarTodasTabelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExportarTodasTabelas.Location = new System.Drawing.Point(899, 8);
            this.buttonExportarTodasTabelas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExportarTodasTabelas.Name = "buttonExportarTodasTabelas";
            this.buttonExportarTodasTabelas.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonExportarTodasTabelas.Size = new System.Drawing.Size(216, 86);
            this.buttonExportarTodasTabelas.TabIndex = 0;
            this.buttonExportarTodasTabelas.Text = "Todas as Tabelas";
            this.buttonExportarTodasTabelas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExportarTodasTabelas.UseVisualStyleBackColor = true;
            this.buttonExportarTodasTabelas.Click += new System.EventHandler(this.buttonExportarTabelas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1126, 560);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "DB SQL Export Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonExportarTodasTabelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCharSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDialect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPorta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxServidor;
        private System.Windows.Forms.Button buttonAbrirArquivo;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonTabela;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPastaExportar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSeparador;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxSGDB;
        private System.Windows.Forms.Button buttonSQLQuery;
        private System.Windows.Forms.TextBox textBoxSQLQuery;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonExecutaQuery;
    }
}

