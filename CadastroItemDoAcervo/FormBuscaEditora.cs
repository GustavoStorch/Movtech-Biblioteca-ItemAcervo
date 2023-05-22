using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroItemDoAcervo
{
    public partial class FormBuscaEditora : Form
    {

        public string nomeEditora { get; private set; }

        public FormBuscaEditora()
        {
            InitializeComponent();
        }

        private void FormBuscaEditora_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        public void carregaTextBox()
        {
            nomeEditora = txtNomeEditora.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosEditoras.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                EditoraDAO dao = new EditoraDAO(connection);
                List<EditoraModel> editoras = dao.GetEditoras();
                foreach (EditoraModel editora in editoras)
                {
                    DataGridViewRow row = dtgDadosEditoras.Rows[dtgDadosEditoras.Rows.Add()];
                    row.Cells[colCodEditora.Index].Value = editora.CodEditora;
                    row.Cells[colNomeEditora.Index].Value = editora.NomeEditora;
                }
            }
        }

        private void dtgDadosEditoras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodEditora.Text = dtgDadosEditoras.Rows[e.RowIndex].Cells[colCodEditora.Index].Value + "";
                txtNomeEditora.Text = dtgDadosEditoras.Rows[e.RowIndex].Cells[colNomeEditora.Index].Value + "";
            }
            carregaTextBox();
        }

        private void btnSelecionarEditora_Click(object sender, EventArgs e)
        {
            carregaTextBox();
        }
    }
}