namespace Importar
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.gbListaTerminais = new System.Windows.Forms.GroupBox();
            this.btnAtualizarLista = new DevExpress.XtraEditors.SimpleButton();
            this.lista_terminais_conectados = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblVersao = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusVersao = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tbpLog = new DevExpress.XtraTab.XtraTabPage();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tbpProdutos = new DevExpress.XtraTab.XtraTabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gdcBuscaPreco = new DevExpress.XtraGrid.GridControl();
            this.gdvBuscaPreco = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcCodBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcFoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlLocalizaArquivo = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnLocalizar = new DevExpress.XtraEditors.SimpleButton();
            this.txtLocalizar = new DevExpress.XtraEditors.TextEdit();
            this.lblExaminar = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblItensExibicao = new DevExpress.XtraEditors.LabelControl();
            this.lblContador = new DevExpress.XtraEditors.LabelControl();
            this.lblBuscaPreco = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlspMenu = new System.Windows.Forms.ToolStrip();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.btnExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbpConfiguracoes = new DevExpress.XtraTab.XtraTabPage();
            this.chkModoExportImport = new DevExpress.XtraEditors.CheckEdit();
            this.chkIniciaWindows = new DevExpress.XtraEditors.CheckEdit();
            this.gbMsgRap = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimeExib = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEnviarMsgRap = new System.Windows.Forms.Button();
            this.txtLine2 = new System.Windows.Forms.TextBox();
            this.txtLine1 = new System.Windows.Forms.TextBox();
            this.gbConfigMsg = new System.Windows.Forms.GroupBox();
            this.btnRecebDoTerm = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsg1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMsg2 = new System.Windows.Forms.TextBox();
            this.txtTexib = new System.Windows.Forms.TextBox();
            this.txtMsg3 = new System.Windows.Forms.TextBox();
            this.txtMsg4 = new System.Windows.Forms.TextBox();
            this.gbConfRedes = new System.Windows.Forms.GroupBox();
            this.txtIdTerm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMascRede = new System.Windows.Forms.TextBox();
            this.txtIpTerminal = new System.Windows.Forms.TextBox();
            this.txtIPServidor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ntfBuscaPreco = new System.Windows.Forms.NotifyIcon(this.components);
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.conClose = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.gbListaTerminais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tbpLog.SuspendLayout();
            this.tbpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBuscaPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscaPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLocalizaArquivo)).BeginInit();
            this.pnlLocalizaArquivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlspMenu.SuspendLayout();
            this.tbpConfiguracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkModoExportImport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIniciaWindows.Properties)).BeginInit();
            this.gbMsgRap.SuspendLayout();
            this.gbConfigMsg.SuspendLayout();
            this.gbConfRedes.SuspendLayout();
            this.conMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaTerminais
            // 
            this.gbListaTerminais.Controls.Add(this.btnAtualizarLista);
            this.gbListaTerminais.Controls.Add(this.lista_terminais_conectados);
            this.gbListaTerminais.Location = new System.Drawing.Point(3, 12);
            this.gbListaTerminais.Name = "gbListaTerminais";
            this.gbListaTerminais.Size = new System.Drawing.Size(165, 419);
            this.gbListaTerminais.TabIndex = 2;
            this.gbListaTerminais.TabStop = false;
            this.gbListaTerminais.Text = "Terminais Conectados";
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Appearance.Options.UseTextOptions = true;
            this.btnAtualizarLista.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnAtualizarLista.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarLista.ImageOptions.Image")));
            this.btnAtualizarLista.Location = new System.Drawing.Point(33, 385);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(103, 23);
            this.btnAtualizarLista.TabIndex = 27;
            this.btnAtualizarLista.Text = "Atualizar Lista";
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // lista_terminais_conectados
            // 
            this.lista_terminais_conectados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista_terminais_conectados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_terminais_conectados.FormattingEnabled = true;
            this.lista_terminais_conectados.Location = new System.Drawing.Point(6, 19);
            this.lista_terminais_conectados.Name = "lista_terminais_conectados";
            this.lista_terminais_conectados.Size = new System.Drawing.Size(153, 338);
            this.lista_terminais_conectados.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Appearance.Options.UseFont = true;
            this.lblVersao.Location = new System.Drawing.Point(757, 2);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(37, 13);
            this.lblVersao.TabIndex = 25;
            this.lblVersao.Text = "Versão:";
            // 
            // lblStatusVersao
            // 
            this.lblStatusVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusVersao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusVersao.Appearance.Options.UseFont = true;
            this.lblStatusVersao.Location = new System.Drawing.Point(796, 2);
            this.lblStatusVersao.Name = "lblStatusVersao";
            this.lblStatusVersao.Size = new System.Drawing.Size(37, 13);
            this.lblStatusVersao.TabIndex = 12;
            this.lblStatusVersao.Text = "Status";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(174, 21);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tbpLog;
            this.xtraTabControl1.Size = new System.Drawing.Size(668, 415);
            this.xtraTabControl1.TabIndex = 26;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbpProdutos,
            this.tbpLog,
            this.tbpConfiguracoes});
            // 
            // tbpLog
            // 
            this.tbpLog.Controls.Add(this.lbLog);
            this.tbpLog.Image = ((System.Drawing.Image)(resources.GetObject("tbpLog.Image")));
            this.tbpLog.Name = "tbpLog";
            this.tbpLog.Size = new System.Drawing.Size(662, 384);
            this.tbpLog.Text = "Log";
            // 
            // lbLog
            // 
            this.lbLog.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(6, 9);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(651, 368);
            this.lbLog.TabIndex = 12;
            // 
            // tbpProdutos
            // 
            this.tbpProdutos.Controls.Add(this.linkLabel1);
            this.tbpProdutos.Controls.Add(this.gdcBuscaPreco);
            this.tbpProdutos.Controls.Add(this.pnlLocalizaArquivo);
            this.tbpProdutos.Controls.Add(this.panelControl1);
            this.tbpProdutos.Controls.Add(this.tlspMenu);
            this.tbpProdutos.Image = ((System.Drawing.Image)(resources.GetObject("tbpProdutos.Image")));
            this.tbpProdutos.Name = "tbpProdutos";
            this.tbpProdutos.Size = new System.Drawing.Size(662, 384);
            this.tbpProdutos.Text = "Produtos";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.Location = new System.Drawing.Point(258, 118);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 19);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.Text = "Sem registro(s).";
            this.linkLabel1.Visible = false;
            // 
            // gdcBuscaPreco
            // 
            this.gdcBuscaPreco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcBuscaPreco.Location = new System.Drawing.Point(0, 92);
            this.gdcBuscaPreco.MainView = this.gdvBuscaPreco;
            this.gdcBuscaPreco.Name = "gdcBuscaPreco";
            this.gdcBuscaPreco.Size = new System.Drawing.Size(662, 225);
            this.gdcBuscaPreco.TabIndex = 14;
            this.gdcBuscaPreco.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvBuscaPreco,
            this.gridView1});
            // 
            // gdvBuscaPreco
            // 
            this.gdvBuscaPreco.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcCodBarra,
            this.gdcDescricao,
            this.gdcVenda,
            this.gdcFoto});
            this.gdvBuscaPreco.GridControl = this.gdcBuscaPreco;
            this.gdvBuscaPreco.Name = "gdvBuscaPreco";
            this.gdvBuscaPreco.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gdvBuscaPreco.OptionsBehavior.Editable = false;
            this.gdvBuscaPreco.OptionsCustomization.AllowGroup = false;
            this.gdvBuscaPreco.OptionsView.ShowGroupPanel = false;
            this.gdvBuscaPreco.OptionsView.ShowIndicator = false;
            this.gdvBuscaPreco.RowCountChanged += new System.EventHandler(this.gdvBuscaPreco_RowCountChanged_1);
            // 
            // gdcCodBarra
            // 
            this.gdcCodBarra.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdcCodBarra.AppearanceHeader.Options.UseFont = true;
            this.gdcCodBarra.Caption = "Cód.Barra";
            this.gdcCodBarra.FieldName = "codigoDeBarra";
            this.gdcCodBarra.Name = "gdcCodBarra";
            this.gdcCodBarra.Visible = true;
            this.gdcCodBarra.VisibleIndex = 0;
            this.gdcCodBarra.Width = 134;
            // 
            // gdcDescricao
            // 
            this.gdcDescricao.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdcDescricao.AppearanceHeader.Options.UseFont = true;
            this.gdcDescricao.AppearanceHeader.Options.UseTextOptions = true;
            this.gdcDescricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gdcDescricao.Caption = "Descrição de Produto";
            this.gdcDescricao.FieldName = "descricao";
            this.gdcDescricao.Name = "gdcDescricao";
            this.gdcDescricao.Visible = true;
            this.gdcDescricao.VisibleIndex = 1;
            this.gdcDescricao.Width = 390;
            // 
            // gdcVenda
            // 
            this.gdcVenda.AppearanceCell.Options.UseTextOptions = true;
            this.gdcVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gdcVenda.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdcVenda.AppearanceHeader.Options.UseFont = true;
            this.gdcVenda.Caption = "Preço de Venda";
            this.gdcVenda.DisplayFormat.FormatString = "#0.00";
            this.gdcVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gdcVenda.FieldName = "preco";
            this.gdcVenda.Name = "gdcVenda";
            this.gdcVenda.Visible = true;
            this.gdcVenda.VisibleIndex = 2;
            this.gdcVenda.Width = 119;
            // 
            // gdcFoto
            // 
            this.gdcFoto.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdcFoto.AppearanceHeader.Options.UseFont = true;
            this.gdcFoto.Caption = "Foto";
            this.gdcFoto.Name = "gdcFoto";
            this.gdcFoto.Visible = true;
            this.gdcFoto.VisibleIndex = 3;
            this.gdcFoto.Width = 32;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gdcBuscaPreco;
            this.gridView1.Name = "gridView1";
            // 
            // pnlLocalizaArquivo
            // 
            this.pnlLocalizaArquivo.Controls.Add(this.groupControl1);
            this.pnlLocalizaArquivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLocalizaArquivo.Location = new System.Drawing.Point(0, 25);
            this.pnlLocalizaArquivo.Name = "pnlLocalizaArquivo";
            this.pnlLocalizaArquivo.Size = new System.Drawing.Size(662, 67);
            this.pnlLocalizaArquivo.TabIndex = 15;
            this.pnlLocalizaArquivo.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnLocalizar);
            this.groupControl1.Controls.Add(this.txtLocalizar);
            this.groupControl1.Controls.Add(this.lblExaminar);
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(473, 53);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Localize o local aonde será exportado o arquivo ";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.ImageOptions.Image")));
            this.btnLocalizar.Location = new System.Drawing.Point(444, 23);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(24, 23);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Enabled = false;
            this.txtLocalizar.Location = new System.Drawing.Point(71, 25);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtLocalizar.Properties.Appearance.Options.UseBackColor = true;
            this.txtLocalizar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtLocalizar.Properties.ReadOnly = true;
            this.txtLocalizar.Size = new System.Drawing.Size(369, 20);
            this.txtLocalizar.TabIndex = 1;
            // 
            // lblExaminar
            // 
            this.lblExaminar.Location = new System.Drawing.Point(17, 28);
            this.lblExaminar.Name = "lblExaminar";
            this.lblExaminar.Size = new System.Drawing.Size(48, 13);
            this.lblExaminar.TabIndex = 0;
            this.lblExaminar.Text = "Examinar:";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.lblItensExibicao);
            this.panelControl1.Controls.Add(this.lblContador);
            this.panelControl1.Controls.Add(this.lblBuscaPreco);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 317);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(662, 67);
            this.panelControl1.TabIndex = 13;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 63);
            this.pictureEdit1.TabIndex = 11;
            // 
            // lblItensExibicao
            // 
            this.lblItensExibicao.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItensExibicao.Appearance.Options.UseFont = true;
            this.lblItensExibicao.Location = new System.Drawing.Point(233, 32);
            this.lblItensExibicao.Name = "lblItensExibicao";
            this.lblItensExibicao.Size = new System.Drawing.Size(203, 23);
            this.lblItensExibicao.TabIndex = 10;
            this.lblItensExibicao.Text = "item(ns) em exibição";
            this.lblItensExibicao.Visible = false;
            // 
            // lblContador
            // 
            this.lblContador.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Appearance.Options.UseFont = true;
            this.lblContador.Location = new System.Drawing.Point(118, 32);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(108, 23);
            this.lblContador.TabIndex = 9;
            this.lblContador.Text = "000000000";
            this.lblContador.Visible = false;
            // 
            // lblBuscaPreco
            // 
            this.lblBuscaPreco.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaPreco.Appearance.Options.UseFont = true;
            this.lblBuscaPreco.Location = new System.Drawing.Point(118, 6);
            this.lblBuscaPreco.Name = "lblBuscaPreco";
            this.lblBuscaPreco.Size = new System.Drawing.Size(293, 23);
            this.lblBuscaPreco.TabIndex = 8;
            this.lblBuscaPreco.Text = "Meus Produtos do Busca Preço";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(486, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tlspMenu
            // 
            this.tlspMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tlspMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlspMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair,
            this.btnExportar,
            this.toolStripLabel1});
            this.tlspMenu.Location = new System.Drawing.Point(0, 0);
            this.tlspMenu.Name = "tlspMenu";
            this.tlspMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlspMenu.Size = new System.Drawing.Size(662, 25);
            this.tlspMenu.TabIndex = 12;
            this.tlspMenu.Text = "Menu";
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Visible = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExportar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(80, 22);
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(244, 22);
            this.toolStripLabel1.Text = "Busca Preço Gertec - Eccus Informática";
            // 
            // tbpConfiguracoes
            // 
            this.tbpConfiguracoes.Controls.Add(this.chkModoExportImport);
            this.tbpConfiguracoes.Controls.Add(this.chkIniciaWindows);
            this.tbpConfiguracoes.Controls.Add(this.gbMsgRap);
            this.tbpConfiguracoes.Controls.Add(this.gbConfigMsg);
            this.tbpConfiguracoes.Controls.Add(this.gbConfRedes);
            this.tbpConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("tbpConfiguracoes.Image")));
            this.tbpConfiguracoes.Name = "tbpConfiguracoes";
            this.tbpConfiguracoes.Size = new System.Drawing.Size(662, 384);
            this.tbpConfiguracoes.Text = "Configurações";
            // 
            // chkModoExportImport
            // 
            this.chkModoExportImport.Location = new System.Drawing.Point(7, 337);
            this.chkModoExportImport.Name = "chkModoExportImport";
            this.chkModoExportImport.Properties.Caption = "Ativar modo exportar/importar por arquivo TXT";
            this.chkModoExportImport.Size = new System.Drawing.Size(254, 19);
            this.chkModoExportImport.TabIndex = 40;
            this.chkModoExportImport.CheckedChanged += new System.EventHandler(this.chkModoExportImport_CheckedChanged);
            // 
            // chkIniciaWindows
            // 
            this.chkIniciaWindows.Location = new System.Drawing.Point(7, 319);
            this.chkIniciaWindows.Name = "chkIniciaWindows";
            this.chkIniciaWindows.Properties.Caption = "Inicia com o Windows";
            this.chkIniciaWindows.Size = new System.Drawing.Size(131, 19);
            this.chkIniciaWindows.TabIndex = 39;
            this.chkIniciaWindows.CheckedChanged += new System.EventHandler(this.chkIniciaWindows_CheckedChanged);
            // 
            // gbMsgRap
            // 
            this.gbMsgRap.Controls.Add(this.label9);
            this.gbMsgRap.Controls.Add(this.txtTimeExib);
            this.gbMsgRap.Controls.Add(this.label10);
            this.gbMsgRap.Controls.Add(this.txtEnviarMsgRap);
            this.gbMsgRap.Controls.Add(this.txtLine2);
            this.gbMsgRap.Controls.Add(this.txtLine1);
            this.gbMsgRap.Location = new System.Drawing.Point(299, 9);
            this.gbMsgRap.Name = "gbMsgRap";
            this.gbMsgRap.Size = new System.Drawing.Size(356, 142);
            this.gbMsgRap.TabIndex = 38;
            this.gbMsgRap.TabStop = false;
            this.gbMsgRap.Text = "Enviar Mensagem Rápida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(196, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Segundos";
            // 
            // txtTimeExib
            // 
            this.txtTimeExib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeExib.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeExib.Location = new System.Drawing.Point(161, 79);
            this.txtTimeExib.Name = "txtTimeExib";
            this.txtTimeExib.Size = new System.Drawing.Size(34, 22);
            this.txtTimeExib.TabIndex = 16;
            this.txtTimeExib.Text = "5";
            this.txtTimeExib.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(112, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tempo:";
            // 
            // txtEnviarMsgRap
            // 
            this.txtEnviarMsgRap.Location = new System.Drawing.Point(114, 108);
            this.txtEnviarMsgRap.Name = "txtEnviarMsgRap";
            this.txtEnviarMsgRap.Size = new System.Drawing.Size(149, 24);
            this.txtEnviarMsgRap.TabIndex = 0;
            this.txtEnviarMsgRap.Text = "Enviar Ao Terminal ";
            this.txtEnviarMsgRap.UseVisualStyleBackColor = true;
            this.txtEnviarMsgRap.Click += new System.EventHandler(this.txtEnviarMsgRap_Click);
            // 
            // txtLine2
            // 
            this.txtLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLine2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLine2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLine2.Location = new System.Drawing.Point(7, 51);
            this.txtLine2.Name = "txtLine2";
            this.txtLine2.Size = new System.Drawing.Size(343, 22);
            this.txtLine2.TabIndex = 8;
            this.txtLine2.Text = "Linha 2";
            this.txtLine2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLine1
            // 
            this.txtLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLine1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLine1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLine1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLine1.Location = new System.Drawing.Point(7, 20);
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.Size = new System.Drawing.Size(343, 22);
            this.txtLine1.TabIndex = 7;
            this.txtLine1.Text = "Linha 1";
            this.txtLine1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbConfigMsg
            // 
            this.gbConfigMsg.Controls.Add(this.btnRecebDoTerm);
            this.gbConfigMsg.Controls.Add(this.btnEnviar);
            this.gbConfigMsg.Controls.Add(this.label1);
            this.gbConfigMsg.Controls.Add(this.label2);
            this.gbConfigMsg.Controls.Add(this.label4);
            this.gbConfigMsg.Controls.Add(this.label3);
            this.gbConfigMsg.Controls.Add(this.txtMsg1);
            this.gbConfigMsg.Controls.Add(this.label6);
            this.gbConfigMsg.Controls.Add(this.txtMsg2);
            this.gbConfigMsg.Controls.Add(this.txtTexib);
            this.gbConfigMsg.Controls.Add(this.txtMsg3);
            this.gbConfigMsg.Controls.Add(this.txtMsg4);
            this.gbConfigMsg.Location = new System.Drawing.Point(7, 152);
            this.gbConfigMsg.Name = "gbConfigMsg";
            this.gbConfigMsg.Size = new System.Drawing.Size(648, 161);
            this.gbConfigMsg.TabIndex = 37;
            this.gbConfigMsg.TabStop = false;
            this.gbConfigMsg.Text = "Mensagens";
            // 
            // btnRecebDoTerm
            // 
            this.btnRecebDoTerm.Location = new System.Drawing.Point(311, 132);
            this.btnRecebDoTerm.Name = "btnRecebDoTerm";
            this.btnRecebDoTerm.Size = new System.Drawing.Size(73, 22);
            this.btnRecebDoTerm.TabIndex = 0;
            this.btnRecebDoTerm.Text = "Receber";
            this.btnRecebDoTerm.UseVisualStyleBackColor = true;
            this.btnRecebDoTerm.Click += new System.EventHandler(this.btnRecebDoTerm_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(390, 132);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(67, 22);
            this.btnEnviar.TabIndex = 41;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mensagem 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mensagem 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mensagem 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mensagem 4";
            // 
            // txtMsg1
            // 
            this.txtMsg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsg1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMsg1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMsg1.Location = new System.Drawing.Point(127, 20);
            this.txtMsg1.MaxLength = 22;
            this.txtMsg1.Name = "txtMsg1";
            this.txtMsg1.Size = new System.Drawing.Size(515, 22);
            this.txtMsg1.TabIndex = 16;
            this.txtMsg1.Text = "Mensagem 1";
            this.txtMsg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 14);
            this.label6.TabIndex = 27;
            this.label6.Text = "Segundos";
            // 
            // txtMsg2
            // 
            this.txtMsg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsg2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMsg2.Location = new System.Drawing.Point(127, 48);
            this.txtMsg2.MaxLength = 22;
            this.txtMsg2.Name = "txtMsg2";
            this.txtMsg2.Size = new System.Drawing.Size(515, 22);
            this.txtMsg2.TabIndex = 17;
            this.txtMsg2.Text = "Mensagem 2";
            this.txtMsg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTexib
            // 
            this.txtTexib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTexib.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexib.Location = new System.Drawing.Point(16, 135);
            this.txtTexib.Name = "txtTexib";
            this.txtTexib.Size = new System.Drawing.Size(26, 22);
            this.txtTexib.TabIndex = 20;
            this.txtTexib.Text = "5";
            this.txtTexib.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMsg3
            // 
            this.txtMsg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsg3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMsg3.Location = new System.Drawing.Point(127, 76);
            this.txtMsg3.MaxLength = 22;
            this.txtMsg3.Name = "txtMsg3";
            this.txtMsg3.Size = new System.Drawing.Size(515, 22);
            this.txtMsg3.TabIndex = 18;
            this.txtMsg3.Text = "Mensagem 3";
            this.txtMsg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMsg4
            // 
            this.txtMsg4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsg4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMsg4.Location = new System.Drawing.Point(127, 104);
            this.txtMsg4.MaxLength = 22;
            this.txtMsg4.Name = "txtMsg4";
            this.txtMsg4.Size = new System.Drawing.Size(515, 22);
            this.txtMsg4.TabIndex = 19;
            this.txtMsg4.Text = "Mensagem 4";
            this.txtMsg4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbConfRedes
            // 
            this.gbConfRedes.Controls.Add(this.txtIdTerm);
            this.gbConfRedes.Controls.Add(this.label7);
            this.gbConfRedes.Controls.Add(this.txtMascRede);
            this.gbConfRedes.Controls.Add(this.txtIpTerminal);
            this.gbConfRedes.Controls.Add(this.txtIPServidor);
            this.gbConfRedes.Controls.Add(this.label12);
            this.gbConfRedes.Controls.Add(this.label11);
            this.gbConfRedes.Controls.Add(this.label8);
            this.gbConfRedes.Location = new System.Drawing.Point(7, 9);
            this.gbConfRedes.Name = "gbConfRedes";
            this.gbConfRedes.Size = new System.Drawing.Size(286, 142);
            this.gbConfRedes.TabIndex = 36;
            this.gbConfRedes.TabStop = false;
            this.gbConfRedes.Text = "Configurações de Rede";
            // 
            // txtIdTerm
            // 
            this.txtIdTerm.Enabled = false;
            this.txtIdTerm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTerm.Location = new System.Drawing.Point(131, 15);
            this.txtIdTerm.Name = "txtIdTerm";
            this.txtIdTerm.Size = new System.Drawing.Size(139, 22);
            this.txtIdTerm.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 14);
            this.label7.TabIndex = 31;
            this.label7.Text = "ID: ";
            // 
            // txtMascRede
            // 
            this.txtMascRede.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMascRede.Location = new System.Drawing.Point(131, 108);
            this.txtMascRede.Name = "txtMascRede";
            this.txtMascRede.Size = new System.Drawing.Size(139, 22);
            this.txtMascRede.TabIndex = 28;
            // 
            // txtIpTerminal
            // 
            this.txtIpTerminal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIpTerminal.Location = new System.Drawing.Point(131, 76);
            this.txtIpTerminal.Name = "txtIpTerminal";
            this.txtIpTerminal.Size = new System.Drawing.Size(139, 22);
            this.txtIpTerminal.TabIndex = 27;
            // 
            // txtIPServidor
            // 
            this.txtIPServidor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPServidor.Location = new System.Drawing.Point(131, 43);
            this.txtIPServidor.Name = "txtIPServidor";
            this.txtIPServidor.Size = new System.Drawing.Size(139, 22);
            this.txtIPServidor.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "Máscara de Rede";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 14);
            this.label11.TabIndex = 24;
            this.label11.Text = "IP do Terminal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 23;
            this.label8.Text = "IP do Servidor";
            // 
            // ntfBuscaPreco
            // 
            this.ntfBuscaPreco.ContextMenuStrip = this.conMenu;
            this.ntfBuscaPreco.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfBuscaPreco.Icon")));
            this.ntfBuscaPreco.Text = "Busca Preço Gertec - Eccus Informática";
            this.ntfBuscaPreco.Visible = true;
            this.ntfBuscaPreco.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfBuscaPreco_MouseDoubleClick);
            // 
            // conMenu
            // 
            this.conMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.conMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.conMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem1,
            this.toolStripSeparator1,
            this.conClose});
            this.conMenu.Name = "ContextMenuStrip1";
            this.conMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.conMenu.Size = new System.Drawing.Size(163, 54);
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem1.Image")));
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.abrirToolStripMenuItem1.Text = "Mostrar Painel";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // conClose
            // 
            this.conClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conClose.Image = ((System.Drawing.Image)(resources.GetObject("conClose.Image")));
            this.conClose.Name = "conClose";
            this.conClose.Size = new System.Drawing.Size(162, 22);
            this.conClose.Text = "Fechar";
            this.conClose.Click += new System.EventHandler(this.conClose_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 439);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.lblStatusVersao);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.gbListaTerminais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Preço Gertec - Eccus Informática";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.SizeChanged += new System.EventHandler(this.FormPrincipal_SizeChanged);
            this.gbListaTerminais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tbpLog.ResumeLayout(false);
            this.tbpProdutos.ResumeLayout(false);
            this.tbpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBuscaPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscaPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLocalizaArquivo)).EndInit();
            this.pnlLocalizaArquivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlspMenu.ResumeLayout(false);
            this.tlspMenu.PerformLayout();
            this.tbpConfiguracoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkModoExportImport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIniciaWindows.Properties)).EndInit();
            this.gbMsgRap.ResumeLayout(false);
            this.gbMsgRap.PerformLayout();
            this.gbConfigMsg.ResumeLayout(false);
            this.gbConfigMsg.PerformLayout();
            this.gbConfRedes.ResumeLayout(false);
            this.gbConfRedes.PerformLayout();
            this.conMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaTerminais;
        private System.Windows.Forms.ListBox lista_terminais_conectados;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraEditors.LabelControl lblVersao;
        private DevExpress.XtraEditors.LabelControl lblStatusVersao;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tbpProdutos;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevExpress.XtraGrid.GridControl gdcBuscaPreco;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvBuscaPreco;
        private DevExpress.XtraGrid.Columns.GridColumn gdcCodBarra;
        private DevExpress.XtraGrid.Columns.GridColumn gdcDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn gdcVenda;
        private DevExpress.XtraGrid.Columns.GridColumn gdcFoto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pnlLocalizaArquivo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnLocalizar;
        private DevExpress.XtraEditors.TextEdit txtLocalizar;
        private DevExpress.XtraEditors.LabelControl lblExaminar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblItensExibicao;
        private DevExpress.XtraEditors.LabelControl lblContador;
        private DevExpress.XtraEditors.LabelControl lblBuscaPreco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip tlspMenu;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripButton btnExportar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraTab.XtraTabPage tbpLog;
        private System.Windows.Forms.ListBox lbLog;
        private DevExpress.XtraTab.XtraTabPage tbpConfiguracoes;
        private System.Windows.Forms.GroupBox gbMsgRap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimeExib;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button txtEnviarMsgRap;
        private System.Windows.Forms.TextBox txtLine2;
        private System.Windows.Forms.TextBox txtLine1;
        private System.Windows.Forms.GroupBox gbConfigMsg;
        private System.Windows.Forms.Button btnRecebDoTerm;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsg1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMsg2;
        private System.Windows.Forms.TextBox txtTexib;
        private System.Windows.Forms.TextBox txtMsg3;
        private System.Windows.Forms.TextBox txtMsg4;
        private System.Windows.Forms.GroupBox gbConfRedes;
        private System.Windows.Forms.TextBox txtIdTerm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMascRede;
        private System.Windows.Forms.TextBox txtIpTerminal;
        private System.Windows.Forms.TextBox txtIPServidor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnAtualizarLista;
        private DevExpress.XtraEditors.CheckEdit chkIniciaWindows;
        private System.Windows.Forms.NotifyIcon ntfBuscaPreco;
        private System.Windows.Forms.Timer timer3;
        internal System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem conClose;
        private DevExpress.XtraEditors.CheckEdit chkModoExportImport;
    }
}