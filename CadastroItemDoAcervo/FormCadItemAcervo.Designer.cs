namespace CadastroItemDoAcervo
{
    partial class FormCadItemAcervo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadItemAcervo));
            this.lblCodAcervo = new System.Windows.Forms.Label();
            this.lblNomeAcervo = new System.Windows.Forms.Label();
            this.lblNomeLocalAcervo = new System.Windows.Forms.Label();
            this.lblNomeAutorAcervo = new System.Windows.Forms.Label();
            this.lblNomeEditoraAcervo = new System.Windows.Forms.Label();
            this.lblNomeColecaoAcervo = new System.Windows.Forms.Label();
            this.lblTipoItemAcervo = new System.Windows.Forms.Label();
            this.lblNumExemplarAcervo = new System.Windows.Forms.Label();
            this.lblVolumeAcervo = new System.Windows.Forms.Label();
            this.lblAnoEdicaoAcervo = new System.Windows.Forms.Label();
            this.lblLocalizacaoAcervo = new System.Windows.Forms.Label();
            this.lblSecaoAcervo = new System.Windows.Forms.Label();
            this.lblStatusAcervo = new System.Windows.Forms.Label();
            this.txtCodItemAcervo = new System.Windows.Forms.TextBox();
            this.txtNomeItemAcervo = new System.Windows.Forms.TextBox();
            this.txtNomeColecaoAcervo = new System.Windows.Forms.TextBox();
            this.cbxTipoItemAcervo = new System.Windows.Forms.ComboBox();
            this.txtNumExemplarAcervo = new System.Windows.Forms.TextBox();
            this.txtVolumeAcervo = new System.Windows.Forms.TextBox();
            this.txtAnoEdicaoAcervo = new System.Windows.Forms.TextBox();
            this.txtLocalizacaoAcervo = new System.Windows.Forms.TextBox();
            this.cbxStatusAcervo = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtgDadosItemAcervo = new System.Windows.Forms.DataGridView();
            this.colCodItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeColecaoitemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumExempItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAutorItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLocalItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolumeItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnoEdicaoItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeSecaoItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpxInsertDadosItemAcervo = new System.Windows.Forms.GroupBox();
            this.btnBuscarSecao = new System.Windows.Forms.Button();
            this.txtNomeSecao = new System.Windows.Forms.TextBox();
            this.btnBuscarLocal = new System.Windows.Forms.Button();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.btnBuscarEditora = new System.Windows.Forms.Button();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.mvtBibAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mvtBibAutorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mvtBibEditoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosItemAcervo)).BeginInit();
            this.gpxInsertDadosItemAcervo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBibAutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBibAutorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBibEditoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodAcervo
            // 
            this.lblCodAcervo.AutoSize = true;
            this.lblCodAcervo.Location = new System.Drawing.Point(4, 25);
            this.lblCodAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodAcervo.Name = "lblCodAcervo";
            this.lblCodAcervo.Size = new System.Drawing.Size(43, 13);
            this.lblCodAcervo.TabIndex = 1;
            this.lblCodAcervo.Text = "Código:";
            // 
            // lblNomeAcervo
            // 
            this.lblNomeAcervo.AutoSize = true;
            this.lblNomeAcervo.Location = new System.Drawing.Point(203, 23);
            this.lblNomeAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeAcervo.Name = "lblNomeAcervo";
            this.lblNomeAcervo.Size = new System.Drawing.Size(38, 13);
            this.lblNomeAcervo.TabIndex = 2;
            this.lblNomeAcervo.Text = "Nome:";
            // 
            // lblNomeLocalAcervo
            // 
            this.lblNomeLocalAcervo.AutoSize = true;
            this.lblNomeLocalAcervo.Location = new System.Drawing.Point(203, 88);
            this.lblNomeLocalAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeLocalAcervo.Name = "lblNomeLocalAcervo";
            this.lblNomeLocalAcervo.Size = new System.Drawing.Size(67, 13);
            this.lblNomeLocalAcervo.TabIndex = 3;
            this.lblNomeLocalAcervo.Text = "Nome Local:";
            // 
            // lblNomeAutorAcervo
            // 
            this.lblNomeAutorAcervo.AutoSize = true;
            this.lblNomeAutorAcervo.Location = new System.Drawing.Point(203, 44);
            this.lblNomeAutorAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeAutorAcervo.Name = "lblNomeAutorAcervo";
            this.lblNomeAutorAcervo.Size = new System.Drawing.Size(66, 13);
            this.lblNomeAutorAcervo.TabIndex = 4;
            this.lblNomeAutorAcervo.Text = "Nome Autor:";
            // 
            // lblNomeEditoraAcervo
            // 
            this.lblNomeEditoraAcervo.AutoSize = true;
            this.lblNomeEditoraAcervo.Location = new System.Drawing.Point(203, 66);
            this.lblNomeEditoraAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeEditoraAcervo.Name = "lblNomeEditoraAcervo";
            this.lblNomeEditoraAcervo.Size = new System.Drawing.Size(74, 13);
            this.lblNomeEditoraAcervo.TabIndex = 5;
            this.lblNomeEditoraAcervo.Text = "Nome Editora:";
            // 
            // lblNomeColecaoAcervo
            // 
            this.lblNomeColecaoAcervo.AutoSize = true;
            this.lblNomeColecaoAcervo.Location = new System.Drawing.Point(203, 110);
            this.lblNomeColecaoAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeColecaoAcervo.Name = "lblNomeColecaoAcervo";
            this.lblNomeColecaoAcervo.Size = new System.Drawing.Size(80, 13);
            this.lblNomeColecaoAcervo.TabIndex = 6;
            this.lblNomeColecaoAcervo.Text = "Nome Coleção:";
            // 
            // lblTipoItemAcervo
            // 
            this.lblTipoItemAcervo.AutoSize = true;
            this.lblTipoItemAcervo.Location = new System.Drawing.Point(4, 107);
            this.lblTipoItemAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoItemAcervo.Name = "lblTipoItemAcervo";
            this.lblTipoItemAcervo.Size = new System.Drawing.Size(54, 13);
            this.lblTipoItemAcervo.TabIndex = 7;
            this.lblTipoItemAcervo.Text = "Tipo Item:";
            // 
            // lblNumExemplarAcervo
            // 
            this.lblNumExemplarAcervo.AutoSize = true;
            this.lblNumExemplarAcervo.Location = new System.Drawing.Point(4, 44);
            this.lblNumExemplarAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumExemplarAcervo.Name = "lblNumExemplarAcervo";
            this.lblNumExemplarAcervo.Size = new System.Drawing.Size(78, 13);
            this.lblNumExemplarAcervo.TabIndex = 8;
            this.lblNumExemplarAcervo.Text = "Num Exemplar:";
            // 
            // lblVolumeAcervo
            // 
            this.lblVolumeAcervo.AutoSize = true;
            this.lblVolumeAcervo.Location = new System.Drawing.Point(4, 64);
            this.lblVolumeAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeAcervo.Name = "lblVolumeAcervo";
            this.lblVolumeAcervo.Size = new System.Drawing.Size(45, 13);
            this.lblVolumeAcervo.TabIndex = 9;
            this.lblVolumeAcervo.Text = "Volume:";
            // 
            // lblAnoEdicaoAcervo
            // 
            this.lblAnoEdicaoAcervo.AutoSize = true;
            this.lblAnoEdicaoAcervo.Location = new System.Drawing.Point(4, 85);
            this.lblAnoEdicaoAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnoEdicaoAcervo.Name = "lblAnoEdicaoAcervo";
            this.lblAnoEdicaoAcervo.Size = new System.Drawing.Size(65, 13);
            this.lblAnoEdicaoAcervo.TabIndex = 10;
            this.lblAnoEdicaoAcervo.Text = "Ano Edição:";
            // 
            // lblLocalizacaoAcervo
            // 
            this.lblLocalizacaoAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocalizacaoAcervo.AutoSize = true;
            this.lblLocalizacaoAcervo.Location = new System.Drawing.Point(435, 132);
            this.lblLocalizacaoAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalizacaoAcervo.Name = "lblLocalizacaoAcervo";
            this.lblLocalizacaoAcervo.Size = new System.Drawing.Size(67, 13);
            this.lblLocalizacaoAcervo.TabIndex = 11;
            this.lblLocalizacaoAcervo.Text = "Localização:";
            // 
            // lblSecaoAcervo
            // 
            this.lblSecaoAcervo.AutoSize = true;
            this.lblSecaoAcervo.Location = new System.Drawing.Point(203, 131);
            this.lblSecaoAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecaoAcervo.Name = "lblSecaoAcervo";
            this.lblSecaoAcervo.Size = new System.Drawing.Size(41, 13);
            this.lblSecaoAcervo.TabIndex = 12;
            this.lblSecaoAcervo.Text = "Seção:";
            // 
            // lblStatusAcervo
            // 
            this.lblStatusAcervo.AutoSize = true;
            this.lblStatusAcervo.Location = new System.Drawing.Point(4, 129);
            this.lblStatusAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusAcervo.Name = "lblStatusAcervo";
            this.lblStatusAcervo.Size = new System.Drawing.Size(40, 13);
            this.lblStatusAcervo.TabIndex = 13;
            this.lblStatusAcervo.Text = "Status:";
            // 
            // txtCodItemAcervo
            // 
            this.txtCodItemAcervo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodItemAcervo.Enabled = false;
            this.txtCodItemAcervo.Location = new System.Drawing.Point(85, 21);
            this.txtCodItemAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodItemAcervo.MaxLength = 3;
            this.txtCodItemAcervo.Name = "txtCodItemAcervo";
            this.txtCodItemAcervo.Size = new System.Drawing.Size(115, 20);
            this.txtCodItemAcervo.TabIndex = 1;
            // 
            // txtNomeItemAcervo
            // 
            this.txtNomeItemAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeItemAcervo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeItemAcervo.Location = new System.Drawing.Point(287, 21);
            this.txtNomeItemAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeItemAcervo.MaxLength = 200;
            this.txtNomeItemAcervo.Name = "txtNomeItemAcervo";
            this.txtNomeItemAcervo.Size = new System.Drawing.Size(516, 20);
            this.txtNomeItemAcervo.TabIndex = 2;
            // 
            // txtNomeColecaoAcervo
            // 
            this.txtNomeColecaoAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeColecaoAcervo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeColecaoAcervo.Location = new System.Drawing.Point(287, 109);
            this.txtNomeColecaoAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeColecaoAcervo.Name = "txtNomeColecaoAcervo";
            this.txtNomeColecaoAcervo.Size = new System.Drawing.Size(516, 20);
            this.txtNomeColecaoAcervo.TabIndex = 10;
            // 
            // cbxTipoItemAcervo
            // 
            this.cbxTipoItemAcervo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoItemAcervo.FormattingEnabled = true;
            this.cbxTipoItemAcervo.Items.AddRange(new object[] {
            "Artigo",
            "Folheto",
            "DVD/CD",
            "Jornal",
            "Revista",
            "Livro"});
            this.cbxTipoItemAcervo.Location = new System.Drawing.Point(85, 105);
            this.cbxTipoItemAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipoItemAcervo.Name = "cbxTipoItemAcervo";
            this.cbxTipoItemAcervo.Size = new System.Drawing.Size(116, 21);
            this.cbxTipoItemAcervo.TabIndex = 9;
            this.cbxTipoItemAcervo.Tag = "";
            // 
            // txtNumExemplarAcervo
            // 
            this.txtNumExemplarAcervo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumExemplarAcervo.Location = new System.Drawing.Point(85, 42);
            this.txtNumExemplarAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumExemplarAcervo.MaxLength = 3;
            this.txtNumExemplarAcervo.Name = "txtNumExemplarAcervo";
            this.txtNumExemplarAcervo.Size = new System.Drawing.Size(115, 20);
            this.txtNumExemplarAcervo.TabIndex = 3;
            // 
            // txtVolumeAcervo
            // 
            this.txtVolumeAcervo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVolumeAcervo.Location = new System.Drawing.Point(85, 63);
            this.txtVolumeAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVolumeAcervo.MaxLength = 3;
            this.txtVolumeAcervo.Name = "txtVolumeAcervo";
            this.txtVolumeAcervo.Size = new System.Drawing.Size(115, 20);
            this.txtVolumeAcervo.TabIndex = 5;
            // 
            // txtAnoEdicaoAcervo
            // 
            this.txtAnoEdicaoAcervo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnoEdicaoAcervo.Location = new System.Drawing.Point(85, 84);
            this.txtAnoEdicaoAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnoEdicaoAcervo.MaxLength = 4;
            this.txtAnoEdicaoAcervo.Name = "txtAnoEdicaoAcervo";
            this.txtAnoEdicaoAcervo.Size = new System.Drawing.Size(115, 20);
            this.txtAnoEdicaoAcervo.TabIndex = 7;
            // 
            // txtLocalizacaoAcervo
            // 
            this.txtLocalizacaoAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalizacaoAcervo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalizacaoAcervo.Location = new System.Drawing.Point(503, 131);
            this.txtLocalizacaoAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalizacaoAcervo.MaxLength = 50;
            this.txtLocalizacaoAcervo.Name = "txtLocalizacaoAcervo";
            this.txtLocalizacaoAcervo.Size = new System.Drawing.Size(300, 20);
            this.txtLocalizacaoAcervo.TabIndex = 13;
            // 
            // cbxStatusAcervo
            // 
            this.cbxStatusAcervo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatusAcervo.FormattingEnabled = true;
            this.cbxStatusAcervo.Items.AddRange(new object[] {
            "Disponível",
            "Emprestado",
            "Reservado"});
            this.cbxStatusAcervo.Location = new System.Drawing.Point(85, 127);
            this.cbxStatusAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStatusAcervo.Name = "cbxStatusAcervo";
            this.cbxStatusAcervo.Size = new System.Drawing.Size(116, 21);
            this.cbxStatusAcervo.TabIndex = 11;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(742, 166);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 22);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(659, 166);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 22);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtgDadosItemAcervo
            // 
            this.dtgDadosItemAcervo.AllowUserToAddRows = false;
            this.dtgDadosItemAcervo.AllowUserToDeleteRows = false;
            this.dtgDadosItemAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosItemAcervo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosItemAcervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosItemAcervo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItemAcervo,
            this.colNomeItemAcervo,
            this.colNomeColecaoitemAcervo,
            this.colNumExempItemAcervo,
            this.colTipoItemAcervo,
            this.colStatusItemAcervo,
            this.colNomeAutorItemAcervo,
            this.colNomeEditItemAcervo,
            this.colNomeLocalItemAcervo,
            this.colVolumeItemAcervo,
            this.colAnoEdicaoItemAcervo,
            this.colLocItemAcervo,
            this.colNomeSecaoItemAcervo});
            this.dtgDadosItemAcervo.Location = new System.Drawing.Point(8, 194);
            this.dtgDadosItemAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.dtgDadosItemAcervo.MultiSelect = false;
            this.dtgDadosItemAcervo.Name = "dtgDadosItemAcervo";
            this.dtgDadosItemAcervo.ReadOnly = true;
            this.dtgDadosItemAcervo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgDadosItemAcervo.RowHeadersWidth = 62;
            this.dtgDadosItemAcervo.RowTemplate.Height = 28;
            this.dtgDadosItemAcervo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosItemAcervo.Size = new System.Drawing.Size(811, 244);
            this.dtgDadosItemAcervo.TabIndex = 16;
            this.dtgDadosItemAcervo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosItemAcervo_CellDoubleClick);
            // 
            // colCodItemAcervo
            // 
            this.colCodItemAcervo.FillWeight = 40F;
            this.colCodItemAcervo.HeaderText = "Código";
            this.colCodItemAcervo.MinimumWidth = 8;
            this.colCodItemAcervo.Name = "colCodItemAcervo";
            this.colCodItemAcervo.ReadOnly = true;
            // 
            // colNomeItemAcervo
            // 
            this.colNomeItemAcervo.HeaderText = "Livro";
            this.colNomeItemAcervo.MinimumWidth = 8;
            this.colNomeItemAcervo.Name = "colNomeItemAcervo";
            this.colNomeItemAcervo.ReadOnly = true;
            // 
            // colNomeColecaoitemAcervo
            // 
            this.colNomeColecaoitemAcervo.HeaderText = "Coleção";
            this.colNomeColecaoitemAcervo.MinimumWidth = 8;
            this.colNomeColecaoitemAcervo.Name = "colNomeColecaoitemAcervo";
            this.colNomeColecaoitemAcervo.ReadOnly = true;
            // 
            // colNumExempItemAcervo
            // 
            this.colNumExempItemAcervo.FillWeight = 45F;
            this.colNumExempItemAcervo.HeaderText = "Exemplar";
            this.colNumExempItemAcervo.MinimumWidth = 8;
            this.colNumExempItemAcervo.Name = "colNumExempItemAcervo";
            this.colNumExempItemAcervo.ReadOnly = true;
            // 
            // colTipoItemAcervo
            // 
            this.colTipoItemAcervo.FillWeight = 80F;
            this.colTipoItemAcervo.HeaderText = "Tipo do Item";
            this.colTipoItemAcervo.MinimumWidth = 8;
            this.colTipoItemAcervo.Name = "colTipoItemAcervo";
            this.colTipoItemAcervo.ReadOnly = true;
            // 
            // colStatusItemAcervo
            // 
            this.colStatusItemAcervo.FillWeight = 80F;
            this.colStatusItemAcervo.HeaderText = "Status";
            this.colStatusItemAcervo.MinimumWidth = 8;
            this.colStatusItemAcervo.Name = "colStatusItemAcervo";
            this.colStatusItemAcervo.ReadOnly = true;
            // 
            // colNomeAutorItemAcervo
            // 
            this.colNomeAutorItemAcervo.HeaderText = "Nome do Autor";
            this.colNomeAutorItemAcervo.MinimumWidth = 8;
            this.colNomeAutorItemAcervo.Name = "colNomeAutorItemAcervo";
            this.colNomeAutorItemAcervo.ReadOnly = true;
            this.colNomeAutorItemAcervo.Visible = false;
            // 
            // colNomeEditItemAcervo
            // 
            this.colNomeEditItemAcervo.HeaderText = "Nome da Editora";
            this.colNomeEditItemAcervo.MinimumWidth = 8;
            this.colNomeEditItemAcervo.Name = "colNomeEditItemAcervo";
            this.colNomeEditItemAcervo.ReadOnly = true;
            this.colNomeEditItemAcervo.Visible = false;
            // 
            // colNomeLocalItemAcervo
            // 
            this.colNomeLocalItemAcervo.HeaderText = "Nome do Local";
            this.colNomeLocalItemAcervo.MinimumWidth = 8;
            this.colNomeLocalItemAcervo.Name = "colNomeLocalItemAcervo";
            this.colNomeLocalItemAcervo.ReadOnly = true;
            this.colNomeLocalItemAcervo.Visible = false;
            // 
            // colVolumeItemAcervo
            // 
            this.colVolumeItemAcervo.HeaderText = "Volume";
            this.colVolumeItemAcervo.MinimumWidth = 8;
            this.colVolumeItemAcervo.Name = "colVolumeItemAcervo";
            this.colVolumeItemAcervo.ReadOnly = true;
            this.colVolumeItemAcervo.Visible = false;
            // 
            // colAnoEdicaoItemAcervo
            // 
            this.colAnoEdicaoItemAcervo.HeaderText = "Ano de Edição";
            this.colAnoEdicaoItemAcervo.MinimumWidth = 8;
            this.colAnoEdicaoItemAcervo.Name = "colAnoEdicaoItemAcervo";
            this.colAnoEdicaoItemAcervo.ReadOnly = true;
            this.colAnoEdicaoItemAcervo.Visible = false;
            // 
            // colLocItemAcervo
            // 
            this.colLocItemAcervo.HeaderText = "Localização";
            this.colLocItemAcervo.MinimumWidth = 8;
            this.colLocItemAcervo.Name = "colLocItemAcervo";
            this.colLocItemAcervo.ReadOnly = true;
            this.colLocItemAcervo.Visible = false;
            // 
            // colNomeSecaoItemAcervo
            // 
            this.colNomeSecaoItemAcervo.HeaderText = "Seção";
            this.colNomeSecaoItemAcervo.MinimumWidth = 8;
            this.colNomeSecaoItemAcervo.Name = "colNomeSecaoItemAcervo";
            this.colNomeSecaoItemAcervo.ReadOnly = true;
            this.colNomeSecaoItemAcervo.Visible = false;
            // 
            // gpxInsertDadosItemAcervo
            // 
            this.gpxInsertDadosItemAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxInsertDadosItemAcervo.Controls.Add(this.btnBuscarSecao);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtNomeSecao);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.btnBuscarLocal);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtNomeLocal);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.btnBuscarEditora);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtNomeEditora);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.btnBuscarAutor);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtNomeAutor);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblCodAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtCodItemAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtLocalizacaoAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.cbxStatusAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblLocalizacaoAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblNomeAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblStatusAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtNomeItemAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.cbxTipoItemAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblSecaoAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtAnoEdicaoAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblNomeLocalAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtVolumeAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblNomeAutorAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblTipoItemAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtNumExemplarAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblNomeEditoraAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblAnoEdicaoAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblNomeColecaoAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblVolumeAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.txtNomeColecaoAcervo);
            this.gpxInsertDadosItemAcervo.Controls.Add(this.lblNumExemplarAcervo);
            this.gpxInsertDadosItemAcervo.Location = new System.Drawing.Point(8, 8);
            this.gpxInsertDadosItemAcervo.Margin = new System.Windows.Forms.Padding(2);
            this.gpxInsertDadosItemAcervo.Name = "gpxInsertDadosItemAcervo";
            this.gpxInsertDadosItemAcervo.Padding = new System.Windows.Forms.Padding(2);
            this.gpxInsertDadosItemAcervo.Size = new System.Drawing.Size(811, 153);
            this.gpxInsertDadosItemAcervo.TabIndex = 36;
            this.gpxInsertDadosItemAcervo.TabStop = false;
            this.gpxInsertDadosItemAcervo.Text = "Dados do Item";
            // 
            // btnBuscarSecao
            // 
            this.btnBuscarSecao.FlatAppearance.BorderSize = 0;
            this.btnBuscarSecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSecao.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscarSecao.Image = global::CadastroItemDoAcervo.Properties.Resources.lupa__1_;
            this.btnBuscarSecao.Location = new System.Drawing.Point(392, 132);
            this.btnBuscarSecao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarSecao.Name = "btnBuscarSecao";
            this.btnBuscarSecao.Size = new System.Drawing.Size(39, 18);
            this.btnBuscarSecao.TabIndex = 37;
            this.btnBuscarSecao.UseVisualStyleBackColor = true;
            this.btnBuscarSecao.Click += new System.EventHandler(this.btnBuscarSecao_Click);
            // 
            // txtNomeSecao
            // 
            this.txtNomeSecao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeSecao.Location = new System.Drawing.Point(287, 131);
            this.txtNomeSecao.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeSecao.Name = "txtNomeSecao";
            this.txtNomeSecao.ReadOnly = true;
            this.txtNomeSecao.Size = new System.Drawing.Size(102, 20);
            this.txtNomeSecao.TabIndex = 37;
            // 
            // btnBuscarLocal
            // 
            this.btnBuscarLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarLocal.FlatAppearance.BorderSize = 0;
            this.btnBuscarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLocal.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscarLocal.Image = global::CadastroItemDoAcervo.Properties.Resources.lupa__1_;
            this.btnBuscarLocal.Location = new System.Drawing.Point(764, 88);
            this.btnBuscarLocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarLocal.Name = "btnBuscarLocal";
            this.btnBuscarLocal.Size = new System.Drawing.Size(39, 18);
            this.btnBuscarLocal.TabIndex = 18;
            this.btnBuscarLocal.UseVisualStyleBackColor = true;
            this.btnBuscarLocal.Click += new System.EventHandler(this.btnBuscarLocal_Click);
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLocal.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.txtNomeLocal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeLocal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeLocal.Location = new System.Drawing.Point(287, 88);
            this.txtNomeLocal.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.ReadOnly = true;
            this.txtNomeLocal.Size = new System.Drawing.Size(473, 20);
            this.txtNomeLocal.TabIndex = 17;
            // 
            // btnBuscarEditora
            // 
            this.btnBuscarEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEditora.FlatAppearance.BorderSize = 0;
            this.btnBuscarEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEditora.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscarEditora.Image = global::CadastroItemDoAcervo.Properties.Resources.lupa__1_;
            this.btnBuscarEditora.Location = new System.Drawing.Point(763, 64);
            this.btnBuscarEditora.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEditora.Name = "btnBuscarEditora";
            this.btnBuscarEditora.Size = new System.Drawing.Size(39, 18);
            this.btnBuscarEditora.TabIndex = 16;
            this.btnBuscarEditora.UseVisualStyleBackColor = true;
            this.btnBuscarEditora.Click += new System.EventHandler(this.btnBuscarEditora_Click);
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeEditora.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.txtNomeEditora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeEditora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeEditora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeEditora.Location = new System.Drawing.Point(287, 65);
            this.txtNomeEditora.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.ReadOnly = true;
            this.txtNomeEditora.Size = new System.Drawing.Size(473, 20);
            this.txtNomeEditora.TabIndex = 15;
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarAutor.FlatAppearance.BorderSize = 0;
            this.btnBuscarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAutor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscarAutor.Image = global::CadastroItemDoAcervo.Properties.Resources.lupa__1_;
            this.btnBuscarAutor.Location = new System.Drawing.Point(763, 42);
            this.btnBuscarAutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(39, 18);
            this.btnBuscarAutor.TabIndex = 14;
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAutor.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.txtNomeAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeAutor.Location = new System.Drawing.Point(287, 43);
            this.txtNomeAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.ReadOnly = true;
            this.txtNomeAutor.Size = new System.Drawing.Size(473, 20);
            this.txtNomeAutor.TabIndex = 4;
            // 
            // mvtBibAutorBindingSource
            // 
            this.mvtBibAutorBindingSource.DataMember = "mvtBibAutor";
            // 
            // mvtBibAutorBindingSource1
            // 
            this.mvtBibAutorBindingSource1.DataMember = "mvtBibAutor";
            // 
            // mvtBibEditoraBindingSource
            // 
            this.mvtBibEditoraBindingSource.DataMember = "mvtBibEditora";
            // 
            // FormCadItemAcervo
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 445);
            this.Controls.Add(this.gpxInsertDadosItemAcervo);
            this.Controls.Add(this.dtgDadosItemAcervo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadItemAcervo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Item do Acervo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosItemAcervo)).EndInit();
            this.gpxInsertDadosItemAcervo.ResumeLayout(false);
            this.gpxInsertDadosItemAcervo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBibAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBibAutorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBibEditoraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCodAcervo;
        private System.Windows.Forms.Label lblNomeAcervo;
        private System.Windows.Forms.Label lblNomeLocalAcervo;
        private System.Windows.Forms.Label lblNomeAutorAcervo;
        private System.Windows.Forms.Label lblNomeEditoraAcervo;
        private System.Windows.Forms.Label lblNomeColecaoAcervo;
        private System.Windows.Forms.Label lblTipoItemAcervo;
        private System.Windows.Forms.Label lblNumExemplarAcervo;
        private System.Windows.Forms.Label lblVolumeAcervo;
        private System.Windows.Forms.Label lblAnoEdicaoAcervo;
        private System.Windows.Forms.Label lblLocalizacaoAcervo;
        private System.Windows.Forms.Label lblSecaoAcervo;
        private System.Windows.Forms.Label lblStatusAcervo;
        private System.Windows.Forms.TextBox txtCodItemAcervo;
        private System.Windows.Forms.TextBox txtNomeColecaoAcervo;
        private System.Windows.Forms.TextBox txtNumExemplarAcervo;
        private System.Windows.Forms.TextBox txtVolumeAcervo;
        private System.Windows.Forms.TextBox txtAnoEdicaoAcervo;
        private System.Windows.Forms.TextBox txtLocalizacaoAcervo;
        private System.Windows.Forms.ComboBox cbxStatusAcervo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtgDadosItemAcervo;
        private System.Windows.Forms.BindingSource treinamentoDataSetBindingSource;
        private System.Windows.Forms.BindingSource mvtBibAutorBindingSource;
        private System.Windows.Forms.BindingSource mvtBibAutorBindingSource1;
        private System.Windows.Forms.BindingSource treinamentoDataSetBindingSource1;
        private System.Windows.Forms.BindingSource mvtBibEditoraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeColecaoitemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumExempItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutorItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocalItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolumeItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnoEdicaoItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeSecaoItemAcervo;
        private System.Windows.Forms.GroupBox gpxInsertDadosItemAcervo;
        private System.Windows.Forms.TextBox txtNomeItemAcervo;
        private System.Windows.Forms.ComboBox cbxTipoItemAcervo;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnBuscarSecao;
        private System.Windows.Forms.TextBox txtNomeSecao;
        private System.Windows.Forms.Button btnBuscarLocal;
        private System.Windows.Forms.TextBox txtNomeLocal;
        private System.Windows.Forms.Button btnBuscarEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
    }
}

