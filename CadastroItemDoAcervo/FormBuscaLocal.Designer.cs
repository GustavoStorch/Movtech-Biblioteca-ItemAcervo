namespace CadastroItemDoAcervo
{
    partial class FormBuscaLocal
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
            this.lblCodLocal = new System.Windows.Forms.Label();
            this.lblNomeLocal = new System.Windows.Forms.Label();
            this.txtCodLocal = new System.Windows.Forms.TextBox();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.btnSelecionarLocal = new System.Windows.Forms.Button();
            this.dtgDadosLocal = new System.Windows.Forms.DataGridView();
            this.colCodLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodLocal
            // 
            this.lblCodLocal.AutoSize = true;
            this.lblCodLocal.Location = new System.Drawing.Point(12, 15);
            this.lblCodLocal.Name = "lblCodLocal";
            this.lblCodLocal.Size = new System.Drawing.Size(43, 13);
            this.lblCodLocal.TabIndex = 0;
            this.lblCodLocal.Text = "Código:";
            // 
            // lblNomeLocal
            // 
            this.lblNomeLocal.AutoSize = true;
            this.lblNomeLocal.Location = new System.Drawing.Point(12, 41);
            this.lblNomeLocal.Name = "lblNomeLocal";
            this.lblNomeLocal.Size = new System.Drawing.Size(36, 13);
            this.lblNomeLocal.TabIndex = 1;
            this.lblNomeLocal.Text = "Local:";
            // 
            // txtCodLocal
            // 
            this.txtCodLocal.Enabled = false;
            this.txtCodLocal.Location = new System.Drawing.Point(61, 12);
            this.txtCodLocal.MaxLength = 3;
            this.txtCodLocal.Name = "txtCodLocal";
            this.txtCodLocal.Size = new System.Drawing.Size(119, 20);
            this.txtCodLocal.TabIndex = 2;
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Location = new System.Drawing.Point(61, 38);
            this.txtNomeLocal.MaxLength = 50;
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(387, 20);
            this.txtNomeLocal.TabIndex = 3;
            this.txtNomeLocal.TextChanged += new System.EventHandler(this.txtNomeLocal_TextChanged);
            // 
            // btnSelecionarLocal
            // 
            this.btnSelecionarLocal.Location = new System.Drawing.Point(453, 37);
            this.btnSelecionarLocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionarLocal.Name = "btnSelecionarLocal";
            this.btnSelecionarLocal.Size = new System.Drawing.Size(67, 21);
            this.btnSelecionarLocal.TabIndex = 5;
            this.btnSelecionarLocal.Text = "Selecionar";
            this.btnSelecionarLocal.UseVisualStyleBackColor = true;
            this.btnSelecionarLocal.Click += new System.EventHandler(this.btnSelecionarLocal_Click);
            // 
            // dtgDadosLocal
            // 
            this.dtgDadosLocal.AllowUserToAddRows = false;
            this.dtgDadosLocal.AllowUserToDeleteRows = false;
            this.dtgDadosLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodLocal,
            this.colNomeLocal});
            this.dtgDadosLocal.Location = new System.Drawing.Point(15, 64);
            this.dtgDadosLocal.MultiSelect = false;
            this.dtgDadosLocal.Name = "dtgDadosLocal";
            this.dtgDadosLocal.ReadOnly = true;
            this.dtgDadosLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosLocal.Size = new System.Drawing.Size(505, 185);
            this.dtgDadosLocal.TabIndex = 6;
            this.dtgDadosLocal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosLocal_CellDoubleClick);
            // 
            // colCodLocal
            // 
            this.colCodLocal.FillWeight = 30F;
            this.colCodLocal.HeaderText = "Código";
            this.colCodLocal.Name = "colCodLocal";
            this.colCodLocal.ReadOnly = true;
            // 
            // colNomeLocal
            // 
            this.colNomeLocal.HeaderText = "Nome Local";
            this.colNomeLocal.Name = "colNomeLocal";
            this.colNomeLocal.ReadOnly = true;
            // 
            // FormBuscaLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 256);
            this.Controls.Add(this.dtgDadosLocal);
            this.Controls.Add(this.btnSelecionarLocal);
            this.Controls.Add(this.txtNomeLocal);
            this.Controls.Add(this.txtCodLocal);
            this.Controls.Add(this.lblNomeLocal);
            this.Controls.Add(this.lblCodLocal);
            this.Name = "FormBuscaLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscaLocal";
            this.Load += new System.EventHandler(this.FormBuscaLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodLocal;
        private System.Windows.Forms.Label lblNomeLocal;
        private System.Windows.Forms.TextBox txtCodLocal;
        private System.Windows.Forms.TextBox txtNomeLocal;
        private System.Windows.Forms.Button btnSelecionarLocal;
        private System.Windows.Forms.DataGridView dtgDadosLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocal;
    }
}