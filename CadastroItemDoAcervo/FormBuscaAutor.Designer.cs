namespace CadastroItemDoAcervo
{
    partial class FormBuscaAutor
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
            this.lblCodAutor = new System.Windows.Forms.Label();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.txtCodAutor = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.dtgDadosAutor = new System.Windows.Forms.DataGridView();
            this.colCodAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodAutor
            // 
            this.lblCodAutor.AutoSize = true;
            this.lblCodAutor.Location = new System.Drawing.Point(12, 15);
            this.lblCodAutor.Name = "lblCodAutor";
            this.lblCodAutor.Size = new System.Drawing.Size(63, 20);
            this.lblCodAutor.TabIndex = 0;
            this.lblCodAutor.Text = "Código:";
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(12, 54);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(55, 20);
            this.lblNomeAutor.TabIndex = 1;
            this.lblNomeAutor.Text = "Nome:";
            // 
            // txtCodAutor
            // 
            this.txtCodAutor.Enabled = false;
            this.txtCodAutor.Location = new System.Drawing.Point(81, 12);
            this.txtCodAutor.MaxLength = 3;
            this.txtCodAutor.Name = "txtCodAutor";
            this.txtCodAutor.Size = new System.Drawing.Size(176, 26);
            this.txtCodAutor.TabIndex = 1;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAutor.Location = new System.Drawing.Point(81, 51);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(596, 26);
            this.txtNomeAutor.TabIndex = 3;
            // 
            // dtgDadosAutor
            // 
            this.dtgDadosAutor.AllowUserToAddRows = false;
            this.dtgDadosAutor.AllowUserToDeleteRows = false;
            this.dtgDadosAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodAutor,
            this.colNomeAutor});
            this.dtgDadosAutor.Location = new System.Drawing.Point(16, 87);
            this.dtgDadosAutor.MultiSelect = false;
            this.dtgDadosAutor.Name = "dtgDadosAutor";
            this.dtgDadosAutor.ReadOnly = true;
            this.dtgDadosAutor.RowHeadersWidth = 62;
            this.dtgDadosAutor.RowTemplate.Height = 28;
            this.dtgDadosAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosAutor.Size = new System.Drawing.Size(768, 306);
            this.dtgDadosAutor.TabIndex = 4;
            this.dtgDadosAutor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosAutor_CellDoubleClick);
            // 
            // colCodAutor
            // 
            this.colCodAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCodAutor.FillWeight = 30F;
            this.colCodAutor.HeaderText = "Código";
            this.colCodAutor.MinimumWidth = 8;
            this.colCodAutor.Name = "colCodAutor";
            this.colCodAutor.ReadOnly = true;
            // 
            // colNomeAutor
            // 
            this.colNomeAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeAutor.HeaderText = "Nome do Autor";
            this.colNomeAutor.MinimumWidth = 8;
            this.colNomeAutor.Name = "colNomeAutor";
            this.colNomeAutor.ReadOnly = true;
            // 
            // btnSelectionar
            // 
            this.btnSelectionar.Location = new System.Drawing.Point(683, 48);
            this.btnSelectionar.Name = "btnSelectionar";
            this.btnSelectionar.Size = new System.Drawing.Size(101, 32);
            this.btnSelectionar.TabIndex = 5;
            this.btnSelectionar.Text = "Selecionar";
            this.btnSelectionar.UseVisualStyleBackColor = true;
            this.btnSelectionar.Click += new System.EventHandler(this.btnSelectionar_Click);
            // 
            // FormBuscaAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 402);
            this.Controls.Add(this.btnSelectionar);
            this.Controls.Add(this.dtgDadosAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtCodAutor);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.lblCodAutor);
            this.Name = "FormBuscaAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Autor";
            this.Load += new System.EventHandler(this.FormBuscaAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodAutor;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.TextBox txtCodAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.DataGridView dtgDadosAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutor;
        private System.Windows.Forms.Button btnSelectionar;
    }
}