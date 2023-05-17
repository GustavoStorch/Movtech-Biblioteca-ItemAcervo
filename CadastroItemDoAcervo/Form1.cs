using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            InitializeTable();
            carregaCombobox();
            limparForm();
            CarregaID();
        }

        public void carregaCombobox()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand cmd1 = new SqlCommand("SELECT codAutor, nomeAutor FROM mvtBibAutor", connection);
                SqlCommand cmd2 = new SqlCommand("SELECT codEditora, nomeEditora FROM mvtBibEditora", connection);
                SqlCommand cmd3 = new SqlCommand("SELECT codLocal, descricaoLocal FROM mvtBibLocal", connection);
                SqlCommand cmd4 = new SqlCommand("SELECT codSecao, descricaoSecao FROM mvtBibSecao", connection);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                SqlDataReader reader2 = cmd2.ExecuteReader();
                SqlDataReader reader3 = cmd3.ExecuteReader();
                SqlDataReader reader4 = cmd4.ExecuteReader();
                List<AutorModel> autores = new List<AutorModel>();
                List<EditoraModel> editoras = new List<EditoraModel>();
                List<LocalModel> locais = new List<LocalModel>();
                List<SecaoModel> secoes = new List<SecaoModel>();

                while (reader1.Read())
                {
                    AutorModel autor = new AutorModel()
                    {
                        CodAutor = reader1.GetInt32(0),
                        NomeAutor = reader1.GetString(1)
                    };
                    autores.Add(autor);

                }
                while (reader2.Read())
                {
                    EditoraModel editora = new EditoraModel()
                    {
                        CodEditora = reader2.GetInt32(0),
                        NomeEditora = reader2.GetString(1)
                    };
                    editoras.Add(editora);
                }
                while (reader3.Read())
                {
                    LocalModel local = new LocalModel()
                    {
                        CodLocal = reader3.GetInt32(0),
                        DescricaoLocal = reader3.GetString(1)
                    };
                    locais.Add(local);
                }
                while (reader4.Read())
                {
                    SecaoModel secao = new SecaoModel()
                    {
                        CodSecao = reader4.GetInt32(0),
                        DescricaoSecao = reader4.GetString(1)
                    };
                    secoes.Add(secao);
                }

                cbxNomeAutor.DataSource = autores;
                cbxNomeAutor.DisplayMember = "nomeAutor";
                cbxNomeAutor.ValueMember = "codAutor";

                cbxNomeEditora.DataSource = editoras;
                cbxNomeEditora.DisplayMember = "nomeEditora";
                cbxNomeEditora.ValueMember = "codEditora";

                cbxNomeLocal.DataSource = locais;
                cbxNomeLocal.DisplayMember = "descricaoLocal";
                cbxNomeLocal.ValueMember = "codLocal";

                cbxNomeSecao.DataSource = secoes;
                cbxNomeSecao.DisplayMember = "descricaoSecao";
                cbxNomeSecao.ValueMember = "codSecao";
            }

        }

        //Botão com a funcionalidade de salvar/persistir os dados inseridos no banco de dados.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    ItemAcervoDAO dao = new ItemAcervoDAO(connection);

                    //Verifica se os campos estão preenchidos corretamente
                    bool verificaCampos = dao.VerificaCampos(new ItemAcervoModel()
                    {
                        NumExemplar = txtNumExemplarAcervo.Text,
                        Nome = txtNomeItemAcervo.Text,
                        TipoItem = cbxTipoItemAcervo.Text
                    }, new AutorModel()
                    {
                        NomeAutor = cbxNomeAutor.Text
                    }, new EditoraModel()
                    {
                        NomeEditora = cbxNomeEditora.Text
                    }, new LocalModel()
                    {
                        DescricaoLocal = cbxNomeLocal.Text
                    });

                    //busca o id do autor, editora, local e secao selecionados para salvar no banco de dados.
                    int codAutor = dao.GetCodAutor(new AutorModel()
                    {
                        NomeAutor = cbxNomeAutor.Text
                    });

                    int codEditora = dao.GetCodEditora(new EditoraModel()
                    {
                        NomeEditora = cbxNomeEditora.Text
                    });

                    int codLocal = dao.GetCodLocal(new LocalModel()
                    {
                        DescricaoLocal = cbxNomeLocal.Text
                    });

                    int codSecao = dao.GetCodSecao(new SecaoModel()
                    {
                        DescricaoSecao = cbxNomeSecao.Text
                    });

                    if(verificaCampos)
                    {
                        int count = dao.VerificaRegistros(new ItemAcervoModel()
                        {
                            CodItem = txtCodItemAcervo.Text
                        });

                        if(count > 0)
                        {
                            dao.Editar(new ItemAcervoModel()
                            {
                                CodItem = txtCodItemAcervo.Text,
                                NumExemplar = txtNumExemplarAcervo.Text,
                                Nome = txtNomeItemAcervo.Text,
                                TipoItem = cbxTipoItemAcervo.Text,
                                Volume = txtVolumeAcervo.Text,
                                AnoEdicao = txtAnoEdicaoAcervo.Text,
                                Localizacao = txtLocalizacaoAcervo.Text,
                                NomeColecao = txtNomeColecaoAcervo.Text,
                                StatusItem = cbxStatusAcervo.Text
                            }, new AutorModel()
                            {
                                CodAutor = codAutor,
                                NomeAutor = cbxNomeAutor.Text
                            }, new EditoraModel()
                            {
                                CodEditora = codEditora,
                                NomeEditora = cbxNomeEditora.Text
                            }, new LocalModel()
                            {
                                CodLocal = codLocal,
                                DescricaoLocal = cbxNomeLocal.Text
                            }, new SecaoModel()
                            {
                                CodSecao = codSecao,
                                DescricaoSecao = cbxNomeSecao.Text
                            });
                            MessageBox.Show("Item do acervo atualizado com sucesso!");
                            limparForm();
                        } 
                        else
                        {
                            dao.Salvar(new ItemAcervoModel()
                            {
                                NumExemplar = txtNumExemplarAcervo.Text,
                                Nome = txtNomeItemAcervo.Text,
                                TipoItem = cbxTipoItemAcervo.Text,
                                Volume = txtVolumeAcervo.Text,
                                AnoEdicao = txtAnoEdicaoAcervo.Text,
                                Localizacao = txtLocalizacaoAcervo.Text,
                                NomeColecao = txtNomeColecaoAcervo.Text,
                                StatusItem = cbxStatusAcervo.Text

                            }, new AutorModel()
                            {
                                CodAutor = codAutor,
                                NomeAutor = cbxNomeAutor.Text
                            }, new EditoraModel()
                            {
                                CodEditora = codEditora,
                                NomeEditora = cbxNomeEditora.Text
                            }, new LocalModel()
                            {
                                CodLocal = codLocal,
                                DescricaoLocal = cbxNomeLocal.Text
                            }, new SecaoModel()
                            {
                                CodSecao = codSecao,
                                DescricaoSecao = cbxNomeSecao.Text
                            });
                            MessageBox.Show("Item do acervo salvo com sucesso!");
                            limparForm();
                        }
                    }
                    InitializeTable();
                    CarregaID();
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar o leitor!\n{ex.Message}");
            }
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
                            CodItem = txtCodItemAcervo.Text
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
            cbxNomeLocal.SelectedIndex = -1;
            cbxNomeAutor.SelectedIndex = -1;
            cbxNomeEditora.SelectedIndex = -1;
            txtNomeColecaoAcervo.Text = String.Empty;
            cbxTipoItemAcervo.Text = String.Empty;
            txtNumExemplarAcervo.Text = String.Empty;
            txtVolumeAcervo.Text = String.Empty;
            txtAnoEdicaoAcervo.Text = String.Empty;
            txtLocalizacaoAcervo.Text = String.Empty;
            cbxNomeSecao.SelectedIndex = -1;
            cbxStatusAcervo.Text = String.Empty;
        }

        private void InitializeTable()
        {
            dtgDadosItemAcervo.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ItemAcervoDAO dao = new ItemAcervoDAO(connection);
                List<ItemAcervoModel> itensAcervos = dao.GetItensAcervo();
                foreach (ItemAcervoModel itemAcervo in itensAcervos)
                {
                    DataGridViewRow row = dtgDadosItemAcervo.Rows[dtgDadosItemAcervo.Rows.Add()];
                    row.Cells[colCodItemAcervo.Index].Value = itemAcervo.CodItem;
                    row.Cells[colNomeItemAcervo.Index].Value = itemAcervo.Nome;
                    row.Cells[colNumExempItemAcervo.Index].Value = itemAcervo.NumExemplar;
                    row.Cells[colStatusItemAcervo.Index].Value = itemAcervo.StatusItem;
                    row.Cells[colNomeColecaoitemAcervo.Index].Value = itemAcervo.NomeColecao;
                    row.Cells[colTipoItemAcervo.Index].Value = itemAcervo.TipoItem;
                    row.Cells[colVolumeItemAcervo.Index].Value = itemAcervo.Volume;
                    row.Cells[colAnoEdicaoItemAcervo.Index].Value = itemAcervo.AnoEdicao;
                    row.Cells[colLocItemAcervo.Index].Value = itemAcervo.Localizacao;
                    row.Cells[colNomeAutorItemAcervo.Index].Value = itemAcervo.AutorModel.NomeAutor;
                    row.Cells[colNomeLocalItemAcervo.Index].Value = itemAcervo.LocalModel.DescricaoLocal;
                    row.Cells[colNomeEditItemAcervo.Index].Value = itemAcervo.EditoraModel.NomeEditora;
                    row.Cells[colNomeSecaoItemAcervo.Index].Value = itemAcervo.SecaoModel.DescricaoSecao;
                }
            }
        }

        private void dtgDadosItemAcervo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodItemAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colCodItemAcervo.Index].Value + "";
                txtNomeItemAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colNomeItemAcervo.Index].Value + "";
                txtNumExemplarAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colNumExempItemAcervo.Index].Value + "";
                cbxStatusAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colStatusItemAcervo.Index].Value + "";
                txtNomeColecaoAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colNomeColecaoitemAcervo.Index].Value + "";
                cbxTipoItemAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colTipoItemAcervo.Index].Value + "";
                txtVolumeAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colVolumeItemAcervo.Index].Value + "";
                txtAnoEdicaoAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colAnoEdicaoItemAcervo.Index].Value + "";
                txtLocalizacaoAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colLocItemAcervo.Index].Value + "";
                cbxNomeAutor.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colNomeAutorItemAcervo.Index].Value + "";
                cbxNomeLocal.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colNomeLocalItemAcervo.Index].Value + "";
                cbxNomeEditora.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colNomeEditItemAcervo.Index].Value + "";
                cbxNomeSecao.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colNomeSecaoItemAcervo.Index].Value + "";

                if (string.IsNullOrEmpty(this.txtNomeItemAcervo.Text))
                {
                    btnExcluir.Enabled = false;
                    CarregaID();
                }
                else
                {
                    btnExcluir.Enabled = true;
                }
            }
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
