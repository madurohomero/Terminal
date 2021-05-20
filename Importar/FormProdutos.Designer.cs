namespace Importar
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.tlspMenu = new System.Windows.Forms.ToolStrip();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.btnExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblItensExibicao = new DevExpress.XtraEditors.LabelControl();
            this.lblContador = new DevExpress.XtraEditors.LabelControl();
            this.lblBuscaPreco = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gdcBuscaPreco = new DevExpress.XtraGrid.GridControl();
            this.gdvBuscaPreco = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcCodBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcFoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnLocalizar = new DevExpress.XtraEditors.SimpleButton();
            this.txtLocalizar = new DevExpress.XtraEditors.TextEdit();
            this.lblExaminar = new DevExpress.XtraEditors.LabelControl();
            this.tlspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBuscaPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscaPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizar.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.tlspMenu.Size = new System.Drawing.Size(637, 25);
            this.tlspMenu.TabIndex = 0;
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
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.panelControl1.Location = new System.Drawing.Point(0, 402);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(637, 67);
            this.panelControl1.TabIndex = 1;
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
            // gdcBuscaPreco
            // 
            this.gdcBuscaPreco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcBuscaPreco.Location = new System.Drawing.Point(0, 92);
            this.gdcBuscaPreco.MainView = this.gdvBuscaPreco;
            this.gdcBuscaPreco.Name = "gdcBuscaPreco";
            this.gdcBuscaPreco.Size = new System.Drawing.Size(637, 310);
            this.gdcBuscaPreco.TabIndex = 2;
            this.gdcBuscaPreco.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvBuscaPreco});
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
            this.gdvBuscaPreco.RowCountChanged += new System.EventHandler(this.gdvBuscaPreco_RowCountChanged);
            // 
            // gdcCodBarra
            // 
            this.gdcCodBarra.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdcCodBarra.AppearanceHeader.Options.UseFont = true;
            this.gdcCodBarra.Caption = "Cód.Barra";
            this.gdcCodBarra.FieldName = "codBarra";
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
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.Location = new System.Drawing.Point(270, 116);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 19);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.Text = "Sem registro(s).";
            this.linkLabel1.Visible = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 25);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(637, 67);
            this.panelControl2.TabIndex = 6;
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
            this.txtLocalizar.TextChanged += new System.EventHandler(this.txtLocalizar_TextChanged);
            // 
            // lblExaminar
            // 
            this.lblExaminar.Location = new System.Drawing.Point(17, 28);
            this.lblExaminar.Name = "lblExaminar";
            this.lblExaminar.Size = new System.Drawing.Size(48, 13);
            this.lblExaminar.TabIndex = 0;
            this.lblExaminar.Text = "Examinar:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 469);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gdcBuscaPreco);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.tlspMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tlspMenu.ResumeLayout(false);
            this.tlspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBuscaPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscaPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlspMenu;
        private System.Windows.Forms.ToolStripButton btnExportar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gdcBuscaPreco;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvBuscaPreco;
        private DevExpress.XtraGrid.Columns.GridColumn gdcCodBarra;
        private DevExpress.XtraGrid.Columns.GridColumn gdcDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn gdcVenda;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnLocalizar;
        private DevExpress.XtraEditors.TextEdit txtLocalizar;
        private DevExpress.XtraEditors.LabelControl lblExaminar;
        private DevExpress.XtraGrid.Columns.GridColumn gdcFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblItensExibicao;
        private DevExpress.XtraEditors.LabelControl lblContador;
        private DevExpress.XtraEditors.LabelControl lblBuscaPreco;
    }
}