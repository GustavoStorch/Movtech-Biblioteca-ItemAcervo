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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaID();
            InitializeTable();
        }

        //Botão com a funcionalidade de salvar/persistir os dados inseridos no banco de dados.
        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        //Botão que realiza o Delete de um registro no banco de dados.
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeItemAcervo.Text))
            {
                MessageBox.Show("Escolha um Item do acervo!");
                return;
            }

            DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir o item do acervo?", "Ops, tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (conf == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        ItemAcervoDAO dao = new ItemAcervoDAO(connection);
                        dao.Excluir(new ItemAcervoModel()
                        {
                            CodItem = txtCodItemAcervo.Text,
                        });
                    }
                    MessageBox.Show("Item do acervo excluído com sucesso!");
                    InitializeTable();
                    limparForm();
                    CarregaID();
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir o leitor!\n{ex.Message}");
            }
        }

        //Método que limpa o formulário toda vez que é salvo ou deletado um registro.
        public void limparForm()
        {
            txtCodItemAcervo.Text = String.Empty;
            txtNomeItemAcervo.Text = String.Empty;
            txtNomeLocalItemAcervo.Text = String.Empty;
            txtNomeAutorAcervo.Text = String.Empty;
            txtNomeEditoraAcervo.Text = String.Empty;
            txtNomeColecaoAcervo.Text = String.Empty;
            cbxTipoItemAcervo.Text = String.Empty;
            txtNumExemplarAcervo.Text = String.Empty;
            txtVolumeAcervo.Text = String.Empty;
            txtAnoEdicaoAcervo.Text = String.Empty;
            txtLocalizacaoAcervo.Text = String.Empty;
            txtSecaoAcervo.Text = String.Empty;
            cbxStatusAcervo.Text = String.Empty;
        }

        private void InitializeTable()
        {
            /*dtgDadosItemAcervo.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ItemAcervoDAO dao = new ItemAcervoDAO(connection);
                List<ItemAcervoModel> itensAcervos = dao.GetItensAcervo();
                foreach (ItemAcervoModel itemAcervo in itensAcervos)
                {
                    DataGridViewRow row = dtgDadosItemAcervo.Rows[dtgDadosItemAcervo.Rows.Add()];
                    row.Cells[colCodigoLeitor.Index].Value = leitor.CodLeitor;
                    row.Cells[colNomeLeitor.Index].Value = leitor.NomeLeitor;
                    row.Cells[colCpfLeitor.Index].Value = leitor.Cpf;
                    row.Cells[colSexoLeitor.Index].Value = leitor.Sexo;
                    row.Cells[colDtNascimentoLeitor.Index].Value = leitor.DataNascimento;
                    row.Cells[colRgLeitor.Index].Value = leitor.Rg;
                    row.Cells[colEmailLeitor.Index].Value = leitor.Email;
                    row.Cells[colTelefoneLeitor.Index].Value = leitor.Telefone;
                    row.Cells[colCelularLeitor.Index].Value = leitor.TelefoneCelular;
                    row.Cells[colEnderecoLeitor.Index].Value = leitor.Endereco;
                    row.Cells[colBairroLeitor.Index].Value = leitor.EnderecoBairro;
                    row.Cells[colCidadeLeitor.Index].Value = leitor.EnderecoCidade;
                    row.Cells[colCepLeitor.Index].Value = leitor.EnderecoCep;
                    row.Cells[colUfLeitor.Index].Value = leitor.EnderecoUf;
                    row.Cells[colNumeroLeitor.Index].Value = leitor.EnderecoNumero;
                }
            }*/
        }

        //Recupera o próximo id a ser cadastrado e joga ele para o textBox.
        private void CarregaID()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('mvtBibItemAcervo') + 1", connection);
                int nextCod = Convert.ToInt32(command.ExecuteScalar());

                txtCodItemAcervo.Text = nextCod.ToString();
            }
        }
    }
}
