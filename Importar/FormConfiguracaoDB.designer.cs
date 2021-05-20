namespace Importar
{
    partial class FormConfiguracaoDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracaoDB));
            this.tlpMenu = new System.Windows.Forms.ToolStrip();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnOk = new System.Windows.Forms.ToolStripButton();
            this.txtTesteConexao = new System.Windows.Forms.ToolStripLabel();
            this.statusOk = new System.Windows.Forms.ToolStripLabel();
            this.statusFalhou = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditarDados = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnTesteConexao = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMenu
            // 
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelar,
            this.btnOk,
            this.txtTesteConexao,
            this.statusOk,
            this.statusFalhou});
            this.tlpMenu.Location = new System.Drawing.Point(0, 281);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.Size = new System.Drawing.Size(486, 25);
            this.tlpMenu.TabIndex = 1;
            this.tlpMenu.Text = "toolStrip1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(40, 22);
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTesteConexao
            // 
            this.txtTesteConexao.Name = "txtTesteConexao";
            this.txtTesteConexao.Size = new System.Drawing.Size(50, 22);
            this.txtTesteConexao.Text = "Conexao";
            this.txtTesteConexao.Visible = false;
            // 
            // statusOk
            // 
            this.statusOk.Image = ((System.Drawing.Image)(resources.GetObject("statusOk.Image")));
            this.statusOk.Name = "statusOk";
            this.statusOk.Size = new System.Drawing.Size(16, 22);
            this.statusOk.Visible = false;
            // 
            // statusFalhou
            // 
            this.statusFalhou.Image = ((System.Drawing.Image)(resources.GetObject("statusFalhou.Image")));
            this.statusFalhou.Name = "statusFalhou";
            this.statusFalhou.Size = new System.Drawing.Size(16, 22);
            this.statusFalhou.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Central de Conexão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conexão com o banco de dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Informe o endereço do servidor onde está instalado o SQL Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Indique o endereço de IP do Servidor SQL Server com pontos, ex: 192.168.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Se este micro for servidor, basta deixar o endereço como: localhost ou 127.0.0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "As \"configurações avançadas\" contém os dados para acesso ao SQL Server, por\r\npadr" +
    "ão elas já estão informadas(em alguns casos a única alteração é no campo senha)." +
    "\r\nTeste a sua conexão...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditarDados);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtDb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(5, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 61);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações avançadas de conexão";
            // 
            // btnEditarDados
            // 
            this.btnEditarDados.FlatAppearance.BorderSize = 0;
            this.btnEditarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDados.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarDados.Image")));
            this.btnEditarDados.Location = new System.Drawing.Point(431, 16);
            this.btnEditarDados.Name = "btnEditarDados";
            this.btnEditarDados.Size = new System.Drawing.Size(39, 39);
            this.btnEditarDados.TabIndex = 8;
            this.btnEditarDados.UseVisualStyleBackColor = true;
            this.btnEditarDados.Click += new System.EventHandler(this.btnEditarDados_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(276, 32);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(149, 21);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(161, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(106, 21);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = "sa";
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtDb
            // 
            this.txtDb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDb.Enabled = false;
            this.txtDb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDb.Location = new System.Drawing.Point(11, 32);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(142, 21);
            this.txtDb.TabIndex = 3;
            this.txtDb.Text = "ECCINF";
            this.txtDb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDb_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Usuário SQL Server";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome do banco de dados";
            // 
            // txtServer
            // 
            this.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtServer.Location = new System.Drawing.Point(10, 70);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(471, 26);
            this.txtServer.TabIndex = 13;
            this.txtServer.Text = "localhost";
            this.txtServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyDown_1);
            // 
            // btnTesteConexao
            // 
            this.btnTesteConexao.Enabled = false;
            this.btnTesteConexao.FlatAppearance.BorderSize = 0;
            this.btnTesteConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesteConexao.Image = ((System.Drawing.Image)(resources.GetObject("btnTesteConexao.Image")));
            this.btnTesteConexao.Location = new System.Drawing.Point(436, 236);
            this.btnTesteConexao.Name = "btnTesteConexao";
            this.btnTesteConexao.Size = new System.Drawing.Size(39, 39);
            this.btnTesteConexao.TabIndex = 2;
            this.btnTesteConexao.UseVisualStyleBackColor = true;
            this.btnTesteConexao.Click += new System.EventHandler(this.btnTesteConexao_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormConfiguracaoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 306);
            this.ControlBox = false;
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnTesteConexao);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlpMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfiguracaoDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tlpMenu.ResumeLayout(false);
            this.tlpMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlpMenu;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnOk;
        private System.Windows.Forms.ToolStripLabel txtTesteConexao;
        private System.Windows.Forms.ToolStripLabel statusOk;
        private System.Windows.Forms.ToolStripLabel statusFalhou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEditarDados;
        private System.Windows.Forms.Button btnTesteConexao;
        private System.Windows.Forms.TextBox txtServer;
    }
}