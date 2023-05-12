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
        }

        //Botão com a funcionalidade de salvar/persistir os dados inseridos no banco de dados.
        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        //Botão que realiza o Delete de um registro no banco de dados.
        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
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

        //Recupera o próximo id a ser cadastrado e joga ele para o textBox.
        private void CarregaID()
        {
            //SqlCommand cm = new SqlCommand("SELECT IDENT_CURRENT('mvtBibItemAcervo') + 1", conn);
            //int nextCod = Convert.ToInt32(cm.ExecuteScalar());

            //txtCodItemAcervo.Text = nextCod.ToString();
        }
    }
}
