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
            this.lblCodEditora = new System.Windows.Forms.Label();
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.txtCodEditora = new System.Windows.Forms.TextBox();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btnSelecionarEditora = new System.Windows.Forms.Button();
            this.dtgDadosEditoras = new System.Windows.Forms.DataGridView();
            this.colCodEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosEditoras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodEditora
            // 
            this.lblCodEditora.AutoSize = true;
            this.lblCodEditora.Location = new System.Drawing.Point(12, 15);
            this.lblCodEditora.Name = "lblCodEditora";
            this.lblCodEditora.Size = new System.Drawing.Size(63, 20);
            this.lblCodEditora.TabIndex = 0;
            this.lblCodEditora.Text = "Código:";
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.Location = new System.Drawing.Point(12, 57);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(55, 20);
            this.lblNomeEditora.TabIndex = 1;
            this.lblNomeEditora.Text = "Nome:";
            // 
            // txtCodEditora
            // 
            this.txtCodEditora.Location = new System.Drawing.Point(81, 12);
            this.txtCodEditora.Name = "txtCodEditora";
            this.txtCodEditora.Size = new System.Drawing.Size(176, 26);
            this.txtCodEditora.TabIndex = 2;
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(81, 54);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(596, 26);
            this.txtNomeEditora.TabIndex = 3;
            // 
            // btnSelecionarEditora
            // 
            this.btnSelecionarEditora.Location = new System.Drawing.Point(683, 51);
            this.btnSelecionarEditora.Name = "btnSelecionarEditora";
            this.btnSelecionarEditora.Size = new System.Drawing.Size(101, 32);
            this.btnSelecionarEditora.TabIndex = 4;
            this.btnSelecionarEditora.Text = "Selecionar";
            this.btnSelecionarEditora.UseVisualStyleBackColor = true;
            this.btnSelecionarEditora.Click += new System.EventHandler(this.btnSelecionarEditora_Click);
            // 
            // dtgDadosEditoras
            // 
            this.dtgDadosEditoras.AllowUserToAddRows = false;
            this.dtgDadosEditoras.AllowUserToDeleteRows = false;
            this.dtgDadosEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosEditoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodEditora,
            this.colNomeEditora});
            this.dtgDadosEditoras.Location = new System.Drawing.Point(12, 89);
            this.dtgDadosEditoras.MultiSelect = false;
            this.dtgDadosEditoras.Name = "dtgDadosEditoras";
            this.dtgDadosEditoras.ReadOnly = true;
            this.dtgDadosEditoras.RowHeadersWidth = 62;
            this.dtgDadosEditoras.RowTemplate.Height = 28;
            this.dtgDadosEditoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosEditoras.Size = new System.Drawing.Size(772, 300);
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
            this.ClientSize = new System.Drawing.Size(796, 401);
            this.Controls.Add(this.dtgDadosEditoras);
            this.Controls.Add(this.btnSelecionarEditora);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.txtCodEditora);
            this.Controls.Add(this.lblNomeEditora);
            this.Controls.Add(this.lblCodEditora);
            this.Name = "FormBuscaEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Editora";
            this.Load += new System.EventHandler(this.FormBuscaEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosEditoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodEditora;
        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.TextBox txtCodEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Button btnSelecionarEditora;
        private System.Windows.Forms.DataGridView dtgDadosEditoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditora;
    }
}