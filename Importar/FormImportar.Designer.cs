namespace Importar
{
    partial class FormImportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesqProdutos = new System.Windows.Forms.ToolStripTextBox();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlInferior = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mmImportar = new DevExpress.XtraEditors.MemoEdit();
            this.pgsbImport = new System.Windows.Forms.ProgressBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkZerarProdutos = new DevExpress.XtraEditors.CheckEdit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInferior)).BeginInit();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmImportar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkZerarProdutos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPesqProdutos,
            this.btnAbrir,
            this.btnCancelar,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(229, 22);
            this.toolStripLabel1.Text = "Importar Lista de Produtos";
            // 
            // txtPesqProdutos
            // 
            this.txtPesqProdutos.BackColor = System.Drawing.Color.White;
            this.txtPesqProdutos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqProdutos.Name = "txtPesqProdutos";
            this.txtPesqProdutos.ReadOnly = true;
            this.txtPesqProdutos.Size = new System.Drawing.Size(260, 25);
            // 
            // btnAbrir
            // 
            this.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbrir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(23, 22);
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 22);
            this.btnCancelar.Text = "Cancelar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pnlInferior
            // 
            this.pnlInferior.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlInferior.Appearance.Options.UseBackColor = true;
            this.pnlInferior.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlInferior.Controls.Add(this.labelControl1);
            this.pnlInferior.Controls.Add(this.pictureEdit1);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 366);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(672, 76);
            this.pnlInferior.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(99, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(324, 29);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Importar Lista de Produtos";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(76, 70);
            this.pictureEdit1.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // mmImportar
            // 
            this.mmImportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmImportar.Enabled = false;
            this.mmImportar.Location = new System.Drawing.Point(0, 25);
            this.mmImportar.Name = "mmImportar";
            this.mmImportar.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.mmImportar.Properties.Appearance.Options.UseBackColor = true;
            this.mmImportar.Properties.ReadOnly = true;
            this.mmImportar.Size = new System.Drawing.Size(672, 291);
            this.mmImportar.TabIndex = 5;
            // 
            // pgsbImport
            // 
            this.pgsbImport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgsbImport.Location = new System.Drawing.Point(0, 347);
            this.pgsbImport.Name = "pgsbImport";
            this.pgsbImport.Size = new System.Drawing.Size(672, 19);
            this.pgsbImport.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkZerarProdutos);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 316);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(672, 31);
            this.panelControl1.TabIndex = 7;
            // 
            // chkZerarProdutos
            // 
            this.chkZerarProdutos.Location = new System.Drawing.Point(5, 6);
            this.chkZerarProdutos.Name = "chkZerarProdutos";
            this.chkZerarProdutos.Properties.Caption = "Zerar arquivo de produtos anteriores ?";
            this.chkZerarProdutos.Size = new System.Drawing.Size(215, 19);
            this.chkZerarProdutos.TabIndex = 0;
            // 
            // FormImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 442);
            this.ControlBox = false;
            this.Controls.Add(this.mmImportar);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pgsbImport);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Importar Arquivo de Produtos]";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInferior)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmImportar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkZerarProdutos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraEditors.PanelControl pnlInferior;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.MemoEdit mmImportar;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStripTextBox txtPesqProdutos;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ProgressBar pgsbImport;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit chkZerarProdutos;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}