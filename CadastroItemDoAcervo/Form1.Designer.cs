namespace CadastroItemDoAcervo
{
    partial class Form1
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
            this.mvtBibAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mvtBibAutorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.treinamentoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mvtBibEditoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNomeAutor = new System.Windows.Forms.ComboBox();
            this.cbxNomeLocal = new System.Windows.Forms.ComboBox();
            this.cbxNomeEditora = new System.Windows.Forms.ComboBox();
            this.cbxNomeSecao = new System.Windows.Forms.ComboBox();
            this.colCodItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAutorItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLocalItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolumeItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnoEdicaoItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeSecaoItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeColecaoitemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumExempItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusItemAcervo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosItemAcervo)).BeginInit();
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
            this.lblCodAcervo.Location = new System.Drawing.Point(12, 18);
            this.lblCodAcervo.Name = "lblCodAcervo";
            this.lblCodAcervo.Size = new System.Drawing.Size(63, 20);
            this.lblCodAcervo.TabIndex = 1;
            this.lblCodAcervo.Text = "Código:";
            // 
            // lblNomeAcervo
            // 
            this.lblNomeAcervo.AutoSize = true;
            this.lblNomeAcervo.Location = new System.Drawing.Point(12, 50);
            this.lblNomeAcervo.Name = "lblNomeAcervo";
            this.lblNomeAcervo.Size = new System.Drawing.Size(55, 20);
            this.lblNomeAcervo.TabIndex = 2;
            this.lblNomeAcervo.Text = "Nome:";
            // 
            // lblNomeLocalAcervo
            // 
            this.lblNomeLocalAcervo.AutoSize = true;
            this.lblNomeLocalAcervo.Location = new System.Drawing.Point(12, 82);
            this.lblNomeLocalAcervo.Name = "lblNomeLocalAcervo";
            this.lblNomeLocalAcervo.Size = new System.Drawing.Size(97, 20);
            this.lblNomeLocalAcervo.TabIndex = 3;
            this.lblNomeLocalAcervo.Text = "Nome Local:";
            // 
            // lblNomeAutorAcervo
            // 
            this.lblNomeAutorAcervo.AutoSize = true;
            this.lblNomeAutorAcervo.Location = new System.Drawing.Point(12, 114);
            this.lblNomeAutorAcervo.Name = "lblNomeAutorAcervo";
            this.lblNomeAutorAcervo.Size = new System.Drawing.Size(98, 20);
            this.lblNomeAutorAcervo.TabIndex = 4;
            this.lblNomeAutorAcervo.Text = "Nome Autor:";
            // 
            // lblNomeEditoraAcervo
            // 
            this.lblNomeEditoraAcervo.AutoSize = true;
            this.lblNomeEditoraAcervo.Location = new System.Drawing.Point(12, 146);
            this.lblNomeEditoraAcervo.Name = "lblNomeEditoraAcervo";
            this.lblNomeEditoraAcervo.Size = new System.Drawing.Size(110, 20);
            this.lblNomeEditoraAcervo.TabIndex = 5;
            this.lblNomeEditoraAcervo.Text = "Nome Editora:";
            // 
            // lblNomeColecaoAcervo
            // 
            this.lblNomeColecaoAcervo.AutoSize = true;
            this.lblNomeColecaoAcervo.Location = new System.Drawing.Point(12, 178);
            this.lblNomeColecaoAcervo.Name = "lblNomeColecaoAcervo";
            this.lblNomeColecaoAcervo.Size = new System.Drawing.Size(117, 20);
            this.lblNomeColecaoAcervo.TabIndex = 6;
            this.lblNomeColecaoAcervo.Text = "Nome Coleção:";
            // 
            // lblTipoItemAcervo
            // 
            this.lblTipoItemAcervo.AutoSize = true;
            this.lblTipoItemAcervo.Location = new System.Drawing.Point(12, 210);
            this.lblTipoItemAcervo.Name = "lblTipoItemAcervo";
            this.lblTipoItemAcervo.Size = new System.Drawing.Size(79, 20);
            this.lblTipoItemAcervo.TabIndex = 7;
            this.lblTipoItemAcervo.Text = "Tipo Item:";
            // 
            // lblNumExemplarAcervo
            // 
            this.lblNumExemplarAcervo.AutoSize = true;
            this.lblNumExemplarAcervo.Location = new System.Drawing.Point(12, 244);
            this.lblNumExemplarAcervo.Name = "lblNumExemplarAcervo";
            this.lblNumExemplarAcervo.Size = new System.Drawing.Size(116, 20);
            this.lblNumExemplarAcervo.TabIndex = 8;
            this.lblNumExemplarAcervo.Text = "Num Exemplar:";
            // 
            // lblVolumeAcervo
            // 
            this.lblVolumeAcervo.AutoSize = true;
            this.lblVolumeAcervo.Location = new System.Drawing.Point(12, 276);
            this.lblVolumeAcervo.Name = "lblVolumeAcervo";
            this.lblVolumeAcervo.Size = new System.Drawing.Size(67, 20);
            this.lblVolumeAcervo.TabIndex = 9;
            this.lblVolumeAcervo.Text = "Volume:";
            // 
            // lblAnoEdicaoAcervo
            // 
            this.lblAnoEdicaoAcervo.AutoSize = true;
            this.lblAnoEdicaoAcervo.Location = new System.Drawing.Point(12, 308);
            this.lblAnoEdicaoAcervo.Name = "lblAnoEdicaoAcervo";
            this.lblAnoEdicaoAcervo.Size = new System.Drawing.Size(95, 20);
            this.lblAnoEdicaoAcervo.TabIndex = 10;
            this.lblAnoEdicaoAcervo.Text = "Ano Edição:";
            // 
            // lblLocalizacaoAcervo
            // 
            this.lblLocalizacaoAcervo.AutoSize = true;
            this.lblLocalizacaoAcervo.Location = new System.Drawing.Point(12, 340);
            this.lblLocalizacaoAcervo.Name = "lblLocalizacaoAcervo";
            this.lblLocalizacaoAcervo.Size = new System.Drawing.Size(97, 20);
            this.lblLocalizacaoAcervo.TabIndex = 11;
            this.lblLocalizacaoAcervo.Text = "Localização:";
            // 
            // lblSecaoAcervo
            // 
            this.lblSecaoAcervo.AutoSize = true;
            this.lblSecaoAcervo.Location = new System.Drawing.Point(12, 372);
            this.lblSecaoAcervo.Name = "lblSecaoAcervo";
            this.lblSecaoAcervo.Size = new System.Drawing.Size(59, 20);
            this.lblSecaoAcervo.TabIndex = 12;
            this.lblSecaoAcervo.Text = "Seção:";
            // 
            // lblStatusAcervo
            // 
            this.lblStatusAcervo.AutoSize = true;
            this.lblStatusAcervo.Location = new System.Drawing.Point(12, 404);
            this.lblStatusAcervo.Name = "lblStatusAcervo";
            this.lblStatusAcervo.Size = new System.Drawing.Size(60, 20);
            this.lblStatusAcervo.TabIndex = 13;
            this.lblStatusAcervo.Text = "Status:";
            // 
            // txtCodItemAcervo
            // 
            this.txtCodItemAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodItemAcervo.Enabled = false;
            this.txtCodItemAcervo.Location = new System.Drawing.Point(150, 15);
            this.txtCodItemAcervo.MaxLength = 3;
            this.txtCodItemAcervo.Name = "txtCodItemAcervo";
            this.txtCodItemAcervo.Size = new System.Drawing.Size(296, 26);
            this.txtCodItemAcervo.TabIndex = 14;
            // 
            // txtNomeItemAcervo
            // 
            this.txtNomeItemAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeItemAcervo.Location = new System.Drawing.Point(150, 47);
            this.txtNomeItemAcervo.MaxLength = 200;
            this.txtNomeItemAcervo.Name = "txtNomeItemAcervo";
            this.txtNomeItemAcervo.Size = new System.Drawing.Size(789, 26);
            this.txtNomeItemAcervo.TabIndex = 15;
            // 
            // txtNomeColecaoAcervo
            // 
            this.txtNomeColecaoAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeColecaoAcervo.Location = new System.Drawing.Point(150, 175);
            this.txtNomeColecaoAcervo.Name = "txtNomeColecaoAcervo";
            this.txtNomeColecaoAcervo.Size = new System.Drawing.Size(296, 26);
            this.txtNomeColecaoAcervo.TabIndex = 19;
            // 
            // cbxTipoItemAcervo
            // 
            this.cbxTipoItemAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoItemAcervo.DisplayMember = "adaad";
            this.cbxTipoItemAcervo.FormattingEnabled = true;
            this.cbxTipoItemAcervo.Items.AddRange(new object[] {
            "Artigo",
            "Folheto",
            "DVD/CD",
            "Jornal",
            "Revista",
            "Livro"});
            this.cbxTipoItemAcervo.Location = new System.Drawing.Point(150, 207);
            this.cbxTipoItemAcervo.Name = "cbxTipoItemAcervo";
            this.cbxTipoItemAcervo.Size = new System.Drawing.Size(533, 28);
            this.cbxTipoItemAcervo.TabIndex = 20;
            this.cbxTipoItemAcervo.Tag = "";
            // 
            // txtNumExemplarAcervo
            // 
            this.txtNumExemplarAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumExemplarAcervo.Location = new System.Drawing.Point(150, 241);
            this.txtNumExemplarAcervo.MaxLength = 3;
            this.txtNumExemplarAcervo.Name = "txtNumExemplarAcervo";
            this.txtNumExemplarAcervo.Size = new System.Drawing.Size(296, 26);
            this.txtNumExemplarAcervo.TabIndex = 21;
            // 
            // txtVolumeAcervo
            // 
            this.txtVolumeAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVolumeAcervo.Location = new System.Drawing.Point(150, 273);
            this.txtVolumeAcervo.MaxLength = 3;
            this.txtVolumeAcervo.Name = "txtVolumeAcervo";
            this.txtVolumeAcervo.Size = new System.Drawing.Size(296, 26);
            this.txtVolumeAcervo.TabIndex = 22;
            // 
            // txtAnoEdicaoAcervo
            // 
            this.txtAnoEdicaoAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnoEdicaoAcervo.Location = new System.Drawing.Point(150, 305);
            this.txtAnoEdicaoAcervo.MaxLength = 4;
            this.txtAnoEdicaoAcervo.Name = "txtAnoEdicaoAcervo";
            this.txtAnoEdicaoAcervo.Size = new System.Drawing.Size(296, 26);
            this.txtAnoEdicaoAcervo.TabIndex = 23;
            // 
            // txtLocalizacaoAcervo
            // 
            this.txtLocalizacaoAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalizacaoAcervo.Location = new System.Drawing.Point(150, 337);
            this.txtLocalizacaoAcervo.MaxLength = 50;
            this.txtLocalizacaoAcervo.Name = "txtLocalizacaoAcervo";
            this.txtLocalizacaoAcervo.Size = new System.Drawing.Size(533, 26);
            this.txtLocalizacaoAcervo.TabIndex = 24;
            // 
            // cbxStatusAcervo
            // 
            this.cbxStatusAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxStatusAcervo.FormattingEnabled = true;
            this.cbxStatusAcervo.Items.AddRange(new object[] {
            "Disponível",
            "Emprestado",
            "Reservado"});
            this.cbxStatusAcervo.Location = new System.Drawing.Point(150, 401);
            this.cbxStatusAcervo.Name = "cbxStatusAcervo";
            this.cbxStatusAcervo.Size = new System.Drawing.Size(296, 28);
            this.cbxStatusAcervo.TabIndex = 26;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(823, 437);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 34);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(699, 437);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 34);
            this.btnSalvar.TabIndex = 29;
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
            this.colNomeAutorItemAcervo,
            this.colNomeEditItemAcervo,
            this.colTipoItemAcervo,
            this.colNomeLocalItemAcervo,
            this.colVolumeItemAcervo,
            this.colAnoEdicaoItemAcervo,
            this.colLocItemAcervo,
            this.colNomeSecaoItemAcervo,
            this.colNomeColecaoitemAcervo,
            this.colNomeItemAcervo,
            this.colNumExempItemAcervo,
            this.colStatusItemAcervo});
            this.dtgDadosItemAcervo.Location = new System.Drawing.Point(16, 479);
            this.dtgDadosItemAcervo.Name = "dtgDadosItemAcervo";
            this.dtgDadosItemAcervo.ReadOnly = true;
            this.dtgDadosItemAcervo.RowHeadersWidth = 62;
            this.dtgDadosItemAcervo.RowTemplate.Height = 28;
            this.dtgDadosItemAcervo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosItemAcervo.Size = new System.Drawing.Size(923, 344);
            this.dtgDadosItemAcervo.TabIndex = 31;
            this.dtgDadosItemAcervo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosItemAcervo_CellDoubleClick);
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
            // cbxNomeAutor
            // 
            this.cbxNomeAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomeAutor.FormattingEnabled = true;
            this.cbxNomeAutor.Location = new System.Drawing.Point(150, 111);
            this.cbxNomeAutor.Name = "cbxNomeAutor";
            this.cbxNomeAutor.Size = new System.Drawing.Size(296, 28);
            this.cbxNomeAutor.TabIndex = 32;
            // 
            // cbxNomeLocal
            // 
            this.cbxNomeLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomeLocal.FormattingEnabled = true;
            this.cbxNomeLocal.Location = new System.Drawing.Point(150, 79);
            this.cbxNomeLocal.Name = "cbxNomeLocal";
            this.cbxNomeLocal.Size = new System.Drawing.Size(296, 28);
            this.cbxNomeLocal.TabIndex = 33;
            // 
            // cbxNomeEditora
            // 
            this.cbxNomeEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomeEditora.FormattingEnabled = true;
            this.cbxNomeEditora.Location = new System.Drawing.Point(150, 143);
            this.cbxNomeEditora.Name = "cbxNomeEditora";
            this.cbxNomeEditora.Size = new System.Drawing.Size(296, 28);
            this.cbxNomeEditora.TabIndex = 34;
            // 
            // cbxNomeSecao
            // 
            this.cbxNomeSecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomeSecao.FormattingEnabled = true;
            this.cbxNomeSecao.Location = new System.Drawing.Point(150, 369);
            this.cbxNomeSecao.Name = "cbxNomeSecao";
            this.cbxNomeSecao.Size = new System.Drawing.Size(296, 28);
            this.cbxNomeSecao.TabIndex = 35;
            // 
            // colCodItemAcervo
            // 
            this.colCodItemAcervo.HeaderText = "Código";
            this.colCodItemAcervo.MinimumWidth = 8;
            this.colCodItemAcervo.Name = "colCodItemAcervo";
            this.colCodItemAcervo.ReadOnly = true;
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
            // colTipoItemAcervo
            // 
            this.colTipoItemAcervo.HeaderText = "Tipo do Item";
            this.colTipoItemAcervo.MinimumWidth = 8;
            this.colTipoItemAcervo.Name = "colTipoItemAcervo";
            this.colTipoItemAcervo.ReadOnly = true;
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
            // 
            // colAnoEdicaoItemAcervo
            // 
            this.colAnoEdicaoItemAcervo.HeaderText = "Ano de Edição";
            this.colAnoEdicaoItemAcervo.MinimumWidth = 8;
            this.colAnoEdicaoItemAcervo.Name = "colAnoEdicaoItemAcervo";
            this.colAnoEdicaoItemAcervo.ReadOnly = true;
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
            // colNomeColecaoitemAcervo
            // 
            this.colNomeColecaoitemAcervo.HeaderText = "Nome da Coleção";
            this.colNomeColecaoitemAcervo.MinimumWidth = 8;
            this.colNomeColecaoitemAcervo.Name = "colNomeColecaoitemAcervo";
            this.colNomeColecaoitemAcervo.ReadOnly = true;
            // 
            // colNomeItemAcervo
            // 
            this.colNomeItemAcervo.HeaderText = "Nome";
            this.colNomeItemAcervo.MinimumWidth = 8;
            this.colNomeItemAcervo.Name = "colNomeItemAcervo";
            this.colNomeItemAcervo.ReadOnly = true;
            // 
            // colNumExempItemAcervo
            // 
            this.colNumExempItemAcervo.HeaderText = "Número Exemplar";
            this.colNumExempItemAcervo.MinimumWidth = 8;
            this.colNumExempItemAcervo.Name = "colNumExempItemAcervo";
            this.colNumExempItemAcervo.ReadOnly = true;
            // 
            // colStatusItemAcervo
            // 
            this.colStatusItemAcervo.HeaderText = "Status";
            this.colStatusItemAcervo.MinimumWidth = 8;
            this.colStatusItemAcervo.Name = "colStatusItemAcervo";
            this.colStatusItemAcervo.ReadOnly = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 830);
            this.Controls.Add(this.cbxNomeSecao);
            this.Controls.Add(this.cbxNomeEditora);
            this.Controls.Add(this.cbxNomeLocal);
            this.Controls.Add(this.cbxNomeAutor);
            this.Controls.Add(this.dtgDadosItemAcervo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbxStatusAcervo);
            this.Controls.Add(this.txtLocalizacaoAcervo);
            this.Controls.Add(this.txtAnoEdicaoAcervo);
            this.Controls.Add(this.txtVolumeAcervo);
            this.Controls.Add(this.txtNumExemplarAcervo);
            this.Controls.Add(this.cbxTipoItemAcervo);
            this.Controls.Add(this.txtNomeColecaoAcervo);
            this.Controls.Add(this.txtNomeItemAcervo);
            this.Controls.Add(this.txtCodItemAcervo);
            this.Controls.Add(this.lblStatusAcervo);
            this.Controls.Add(this.lblSecaoAcervo);
            this.Controls.Add(this.lblLocalizacaoAcervo);
            this.Controls.Add(this.lblAnoEdicaoAcervo);
            this.Controls.Add(this.lblVolumeAcervo);
            this.Controls.Add(this.lblNumExemplarAcervo);
            this.Controls.Add(this.lblTipoItemAcervo);
            this.Controls.Add(this.lblNomeColecaoAcervo);
            this.Controls.Add(this.lblNomeEditoraAcervo);
            this.Controls.Add(this.lblNomeAutorAcervo);
            this.Controls.Add(this.lblNomeLocalAcervo);
            this.Controls.Add(this.lblNomeAcervo);
            this.Controls.Add(this.lblCodAcervo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Item do Acervo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosItemAcervo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBibAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBibAutorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinamentoDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvtBibEditoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtNomeItemAcervo;
        private System.Windows.Forms.TextBox txtNomeColecaoAcervo;
        private System.Windows.Forms.ComboBox cbxTipoItemAcervo;
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
        private System.Windows.Forms.ComboBox cbxNomeAutor;
        private System.Windows.Forms.ComboBox cbxNomeLocal;
        private System.Windows.Forms.ComboBox cbxNomeEditora;
        private System.Windows.Forms.ComboBox cbxNomeSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutorItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocalItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolumeItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnoEdicaoItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeSecaoItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeColecaoitemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumExempItemAcervo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusItemAcervo;
    }
}

