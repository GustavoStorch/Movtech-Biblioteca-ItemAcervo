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
            this.lblCodSecao = new System.Windows.Forms.Label();
            this.lblNomeSecao = new System.Windows.Forms.Label();
            this.txtCodSecao = new System.Windows.Forms.TextBox();
            this.txtNomeSecao = new System.Windows.Forms.TextBox();
            this.dtgDadosSecao = new System.Windows.Forms.DataGridView();
            this.btnSelecionarLocal = new System.Windows.Forms.Button();
            this.colCodSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosSecao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodSecao
            // 
            this.lblCodSecao.AutoSize = true;
            this.lblCodSecao.Location = new System.Drawing.Point(12, 15);
            this.lblCodSecao.Name = "lblCodSecao";
            this.lblCodSecao.Size = new System.Drawing.Size(43, 13);
            this.lblCodSecao.TabIndex = 0;
            this.lblCodSecao.Text = "Código:";
            // 
            // lblNomeSecao
            // 
            this.lblNomeSecao.AutoSize = true;
            this.lblNomeSecao.Location = new System.Drawing.Point(12, 41);
            this.lblNomeSecao.Name = "lblNomeSecao";
            this.lblNomeSecao.Size = new System.Drawing.Size(38, 13);
            this.lblNomeSecao.TabIndex = 1;
            this.lblNomeSecao.Text = "Nome:";
            // 
            // txtCodSecao
            // 
            this.txtCodSecao.Enabled = false;
            this.txtCodSecao.Location = new System.Drawing.Point(61, 12);
            this.txtCodSecao.MaxLength = 3;
            this.txtCodSecao.Name = "txtCodSecao";
            this.txtCodSecao.Size = new System.Drawing.Size(119, 20);
            this.txtCodSecao.TabIndex = 2;
            // 
            // txtNomeSecao
            // 
            this.txtNomeSecao.Location = new System.Drawing.Point(61, 38);
            this.txtNomeSecao.MaxLength = 50;
            this.txtNomeSecao.Name = "txtNomeSecao";
            this.txtNomeSecao.Size = new System.Drawing.Size(387, 20);
            this.txtNomeSecao.TabIndex = 3;
            // 
            // dtgDadosSecao
            // 
            this.dtgDadosSecao.AllowUserToAddRows = false;
            this.dtgDadosSecao.AllowUserToDeleteRows = false;
            this.dtgDadosSecao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosSecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosSecao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodSecao,
            this.colNomeSecao});
            this.dtgDadosSecao.Location = new System.Drawing.Point(15, 64);
            this.dtgDadosSecao.MultiSelect = false;
            this.dtgDadosSecao.Name = "dtgDadosSecao";
            this.dtgDadosSecao.ReadOnly = true;
            this.dtgDadosSecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosSecao.Size = new System.Drawing.Size(505, 189);
            this.dtgDadosSecao.TabIndex = 4;
            this.dtgDadosSecao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosSecao_CellDoubleClick);
            // 
            // btnSelecionarLocal
            // 
            this.btnSelecionarLocal.Location = new System.Drawing.Point(453, 37);
            this.btnSelecionarLocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionarLocal.Name = "btnSelecionarLocal";
            this.btnSelecionarLocal.Size = new System.Drawing.Size(67, 21);
            this.btnSelecionarLocal.TabIndex = 6;
            this.btnSelecionarLocal.Text = "Selecionar";
            this.btnSelecionarLocal.UseVisualStyleBackColor = true;
            this.btnSelecionarLocal.Click += new System.EventHandler(this.btnSelecionarLocal_Click);
            // 
            // colCodSecao
            // 
            this.colCodSecao.FillWeight = 30F;
            this.colCodSecao.HeaderText = "Código";
            this.colCodSecao.Name = "colCodSecao";
            this.colCodSecao.ReadOnly = true;
            // 
            // colNomeSecao
            // 
            this.colNomeSecao.HeaderText = "Nome Seção";
            this.colNomeSecao.Name = "colNomeSecao";
            this.colNomeSecao.ReadOnly = true;
            // 
            // FormBuscaSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 256);
            this.Controls.Add(this.btnSelecionarLocal);
            this.Controls.Add(this.dtgDadosSecao);
            this.Controls.Add(this.txtNomeSecao);
            this.Controls.Add(this.txtCodSecao);
            this.Controls.Add(this.lblNomeSecao);
            this.Controls.Add(this.lblCodSecao);
            this.Name = "FormBuscaSecao";
            this.Text = "Busca Seção";
            this.Load += new System.EventHandler(this.FormBuscaSecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosSecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodSecao;
        private System.Windows.Forms.Label lblNomeSecao;
        private System.Windows.Forms.TextBox txtCodSecao;
        private System.Windows.Forms.TextBox txtNomeSecao;
        private System.Windows.Forms.DataGridView dtgDadosSecao;
        private System.Windows.Forms.Button btnSelecionarLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeSecao;
    }
}