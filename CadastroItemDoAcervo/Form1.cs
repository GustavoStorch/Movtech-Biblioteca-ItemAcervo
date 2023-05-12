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

        private SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            table_load();
            CarregaID();
        }

        //Cria a conexão com o banco de dados.
        private SqlConnection Conexao()
        {
            conn = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Treinamento;Integrated Security=True");
            return conn;
        }

        //Botão com a funcionalidade de salvar/persistir os dados inseridos no banco de dados.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

            } catch (SqlException ex)
            {

            } finally
            {
                conn.Close();
            }
        }

        //Botão que realiza o Delete de um registro no banco de dados.
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "DELETE mvtBibItemAcervo WHERE codAutor = @codItem";
                SqlCommand c = new SqlCommand(sql, conn);

                c.Parameters.AddWithValue("@codItem", txtCodItemAcervo.Text);

                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();

                limparForm();
                CarregaID();
                table_load();
            } catch(SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            } finally
            {
                conn.Close();
            }
        }

        //Carrega todos os registros contidos no banco de dados para a DataGridView.
        private void table_load()
        {
            conn = Conexao();
            String sql = "SELECT codItem AS Código, nome AS Nome, nomeLocal AS Local FROM mvtBibItemAcervo ORDER BY Nome";

            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                conn.Open();
                da.Fill(ds);
                gridInfoItemAcervo.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
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
            imgLivroAcervo.Image = null;

        }

        //Recupera o próximo id a ser cadastrado e joga ele para o textBox.
        private void CarregaID()
        {
            conn = Conexao();
            conn.Open();

            SqlCommand cm = new SqlCommand("SELECT IDENT_CURRENT('mvtBibItemAcervo') + 1", conn);
            int nextCod = Convert.ToInt32(cm.ExecuteScalar());

            txtCodItemAcervo.Text = nextCod.ToString();

            conn.Close();
        }
    }
}
