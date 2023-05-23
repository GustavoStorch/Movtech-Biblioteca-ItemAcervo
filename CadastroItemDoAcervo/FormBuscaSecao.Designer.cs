namespace CadastroItemDoAcervo
{
    partial class FormBuscaSecao
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
            this.lblNomeSecao = new System.Windows.Forms.Label();
            this.txtNomeSecao = new System.Windows.Forms.TextBox();
            this.dtgDadosSecao = new System.Windows.Forms.DataGridView();
            this.colCodSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosSecao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeSecao
            // 
            this.lblNomeSecao.AutoSize = true;
            this.lblNomeSecao.Location = new System.Drawing.Point(13, 17);
            this.lblNomeSecao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeSecao.Name = "lblNomeSecao";
            this.lblNomeSecao.Size = new System.Drawing.Size(55, 20);
            this.lblNomeSecao.TabIndex = 1;
            this.lblNomeSecao.Text = "Nome:";
            // 
            // txtNomeSecao
            // 
            this.txtNomeSecao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeSecao.Location = new System.Drawing.Point(76, 14);
            this.txtNomeSecao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeSecao.MaxLength = 50;
            this.txtNomeSecao.Name = "txtNomeSecao";
            this.txtNomeSecao.Size = new System.Drawing.Size(699, 26);
            this.txtNomeSecao.TabIndex = 3;
            this.txtNomeSecao.TextChanged += new System.EventHandler(this.txtNomeSecao_TextChanged);
            // 
            // dtgDadosSecao
            // 
            this.dtgDadosSecao.AllowUserToAddRows = false;
            this.dtgDadosSecao.AllowUserToDeleteRows = false;
            this.dtgDadosSecao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosSecao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosSecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosSecao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodSecao,
            this.colNomeSecao});
            this.dtgDadosSecao.Location = new System.Drawing.Point(17, 50);
            this.dtgDadosSecao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgDadosSecao.MultiSelect = false;
            this.dtgDadosSecao.Name = "dtgDadosSecao";
            this.dtgDadosSecao.ReadOnly = true;
            this.dtgDadosSecao.RowHeadersWidth = 62;
            this.dtgDadosSecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosSecao.Size = new System.Drawing.Size(758, 310);
            this.dtgDadosSecao.TabIndex = 4;
            this.dtgDadosSecao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosSecao_CellDoubleClick);
            // 
            // colCodSecao
            // 
            this.colCodSecao.FillWeight = 30F;
            this.colCodSecao.HeaderText = "Código";
            this.colCodSecao.MinimumWidth = 8;
            this.colCodSecao.Name = "colCodSecao";
            this.colCodSecao.ReadOnly = true;
            // 
            // colNomeSecao
            // 
            this.colNomeSecao.HeaderText = "Nome Seção";
            this.colNomeSecao.MinimumWidth = 8;
            this.colNomeSecao.Name = "colNomeSecao";
            this.colNomeSecao.ReadOnly = true;
            // 
            // FormBuscaSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 371);
            this.Controls.Add(this.dtgDadosSecao);
            this.Controls.Add(this.txtNomeSecao);
            this.Controls.Add(this.lblNomeSecao);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBuscaSecao";
            this.Text = "Busca Seção";
            this.Load += new System.EventHandler(this.FormBuscaSecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosSecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeSecao;
        private System.Windows.Forms.TextBox txtNomeSecao;
        private System.Windows.Forms.DataGridView dtgDadosSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeSecao;
    }
}