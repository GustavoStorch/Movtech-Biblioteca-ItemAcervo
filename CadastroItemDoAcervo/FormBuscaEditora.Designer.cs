namespace CadastroItemDoAcervo
{
    partial class FormBuscaEditora
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
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.dtgDadosEditoras = new System.Windows.Forms.DataGridView();
            this.colCodEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosEditoras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.Location = new System.Drawing.Point(12, 15);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(55, 20);
            this.lblNomeEditora.TabIndex = 1;
            this.lblNomeEditora.Text = "Nome:";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeEditora.Location = new System.Drawing.Point(73, 12);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(711, 26);
            this.txtNomeEditora.TabIndex = 3;
            this.txtNomeEditora.TextChanged += new System.EventHandler(this.txtNomeEditora_TextChanged);
            // 
            // dtgDadosEditoras
            // 
            this.dtgDadosEditoras.AllowUserToAddRows = false;
            this.dtgDadosEditoras.AllowUserToDeleteRows = false;
            this.dtgDadosEditoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosEditoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodEditora,
            this.colNomeEditora});
            this.dtgDadosEditoras.Location = new System.Drawing.Point(16, 44);
            this.dtgDadosEditoras.MultiSelect = false;
            this.dtgDadosEditoras.Name = "dtgDadosEditoras";
            this.dtgDadosEditoras.ReadOnly = true;
            this.dtgDadosEditoras.RowHeadersWidth = 62;
            this.dtgDadosEditoras.RowTemplate.Height = 28;
            this.dtgDadosEditoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosEditoras.Size = new System.Drawing.Size(772, 308);
            this.dtgDadosEditoras.TabIndex = 5;
            this.dtgDadosEditoras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosEditoras_CellDoubleClick);
            // 
            // colCodEditora
            // 
            this.colCodEditora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCodEditora.FillWeight = 30F;
            this.colCodEditora.HeaderText = "Código";
            this.colCodEditora.MinimumWidth = 8;
            this.colCodEditora.Name = "colCodEditora";
            this.colCodEditora.ReadOnly = true;
            // 
            // colNomeEditora
            // 
            this.colNomeEditora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeEditora.HeaderText = "Nome Editora";
            this.colNomeEditora.MinimumWidth = 8;
            this.colNomeEditora.Name = "colNomeEditora";
            this.colNomeEditora.ReadOnly = true;
            // 
            // FormBuscaEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.dtgDadosEditoras);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.lblNomeEditora);
            this.Name = "FormBuscaEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Editora";
            this.Load += new System.EventHandler(this.FormBuscaEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosEditoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.DataGridView dtgDadosEditoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditora;
    }
}