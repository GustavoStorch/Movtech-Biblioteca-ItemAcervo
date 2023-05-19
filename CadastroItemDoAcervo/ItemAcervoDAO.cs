using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroItemDoAcervo
{
    public class ItemAcervoDAO
    {
        private SqlConnection Connection { get; }

        public ItemAcervoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public void Salvar(ItemAcervoModel itemAcervo, AutorModel autor, EditoraModel editora, LocalModel local, SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibItemAcervo(codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, tipoItem, ");
                    sql.AppendLine($"nomeLocal, volume, anoEdicao, localizacao, codSecao, secao, nomeColecao, statusItem) ");
                    sql.AppendLine($"VALUES (@codLocal, @numExemplar, @nome, @codAutor, @nomeAutor, @codEditora, @nomeEditora, @tipoItem, ");
                    sql.AppendLine($"@nomeLocal, @volume, @anoEdicao, @localizacao, @codSecao, @secao, @nomeColecao, @statusItem) ");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codLocal", local.CodLocal));
                    command.Parameters.Add(new SqlParameter("@numExemplar", itemAcervo.NumExemplar));
                    command.Parameters.Add(new SqlParameter("@nome", itemAcervo.Nome));
                    command.Parameters.Add(new SqlParameter("@codAutor", autor.CodAutor));
                    command.Parameters.Add(new SqlParameter("@nomeAutor", autor.NomeAutor));
                    command.Parameters.Add(new SqlParameter("@codEditora", editora.CodEditora));
                    command.Parameters.Add(new SqlParameter("@nomeEditora", editora.NomeEditora));
                    command.Parameters.Add(new SqlParameter("@tipoItem", itemAcervo.TipoItem));
                    command.Parameters.Add(new SqlParameter("@nomeLocal", local.DescricaoLocal));
                    command.Parameters.Add(new SqlParameter("@volume", itemAcervo.Volume));
                    command.Parameters.Add(new SqlParameter("@anoEdicao", itemAcervo.AnoEdicao));
                    command.Parameters.Add(new SqlParameter("@localizacao", itemAcervo.Localizacao));
                    command.Parameters.Add(new SqlParameter("@codSecao", secao.CodSecao));
                    command.Parameters.Add(new SqlParameter("@secao", secao.DescricaoSecao));
                    command.Parameters.Add(new SqlParameter("@nomeColecao", itemAcervo.NomeColecao));
                    command.Parameters.Add(new SqlParameter("@statusItem", itemAcervo.StatusItem));

                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Editar(ItemAcervoModel itemAcervo, AutorModel autor, EditoraModel editora, LocalModel local, SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibItemAcervo SET codLocal = @codLocal, numExemplar = @numExemplar, nome = @nome, " +
                        $"codAutor = @codAutor, nomeAutor = @nomeAutor, codEditora = @codEditora, nomeEditora = @nomeEditora, tipoItem = @tipoItem," +
                        $"nomeLocal = @nomeLocal, volume = @volume, anoEdicao = @anoEdicao, localizacao = @localizacao," +
                        $"codSecao = @codSecao, secao = @secao, nomeColecao = @nomeColecao, statusItem = @statusItem WHERE codItem = @codItem");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codItem", itemAcervo.CodItem);
                    command.Parameters.Add(new SqlParameter("@codLocal", local.CodLocal));
                    command.Parameters.Add(new SqlParameter("@numExemplar", itemAcervo.NumExemplar));
                    command.Parameters.Add(new SqlParameter("@nome", itemAcervo.Nome));
                    command.Parameters.Add(new SqlParameter("@codAutor", autor.CodAutor));
                    command.Parameters.Add(new SqlParameter("@nomeAutor", autor.NomeAutor));
                    command.Parameters.Add(new SqlParameter("@codEditora", editora.CodEditora));
                    command.Parameters.Add(new SqlParameter("@nomeEditora", editora.NomeEditora));
                    command.Parameters.Add(new SqlParameter("@tipoItem", itemAcervo.TipoItem));
                    command.Parameters.Add(new SqlParameter("@nomeLocal", local.DescricaoLocal));
                    command.Parameters.Add(new SqlParameter("@volume", itemAcervo.Volume));
                    command.Parameters.Add(new SqlParameter("@anoEdicao", itemAcervo.AnoEdicao));
                    command.Parameters.Add(new SqlParameter("@localizacao", itemAcervo.Localizacao));
                    command.Parameters.Add(new SqlParameter("@codSecao", secao.CodSecao));
                    command.Parameters.Add(new SqlParameter("@secao", secao.DescricaoSecao));
                    command.Parameters.Add(new SqlParameter("@nomeColecao", itemAcervo.NomeColecao));
                    command.Parameters.Add(new SqlParameter("@statusItem", itemAcervo.StatusItem));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Excluir(ItemAcervoModel itemAcervo, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codItem", itemAcervo.CodItem));
                command.ExecuteNonQuery();
            }
        }

        public int VerificaRegistros(ItemAcervoModel itemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codItem) FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", itemAcervo.CodItem);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }

        public bool VerificaCampos(ItemAcervoModel itemAcervo, AutorModel autor, EditoraModel editora, LocalModel local)
        {
            if (string.IsNullOrEmpty(itemAcervo.NumExemplar) || string.IsNullOrWhiteSpace(itemAcervo.NumExemplar))
            {
                MessageBox.Show("Informe o campo do Número exemplar do item");
                return false;
            }
            else if (string.IsNullOrEmpty(itemAcervo.Nome) || string.IsNullOrWhiteSpace(itemAcervo.Nome))
            {
                MessageBox.Show("Informe o campo do Nome do item");
                return false;
            }
            else if (string.IsNullOrEmpty(autor.NomeAutor) || string.IsNullOrWhiteSpace(autor.NomeAutor))
            {
                MessageBox.Show("Informe o campo do Nome do Autor");
                return false;
            }
            else if (string.IsNullOrEmpty(editora.NomeEditora) || string.IsNullOrWhiteSpace(editora.NomeEditora))
            {
                MessageBox.Show("Informe o campo do Nome da Editora");
                return false;
            }
            else if (string.IsNullOrEmpty(itemAcervo.TipoItem) || string.IsNullOrWhiteSpace(itemAcervo.TipoItem))
            {
                MessageBox.Show("Informe o campo do Tipo do item");
                return false;
            }
            else if (string.IsNullOrEmpty(local.DescricaoLocal) || string.IsNullOrWhiteSpace(local.DescricaoLocal))
            {
                MessageBox.Show("Informe o campo do Nome do local");
                return false;
            }

            return true;
        }

        public int GetCodAutor(AutorModel autor)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codAutor FROM mvtBibAutor WHERE nomeAutor = @nomeAutor");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@nomeAutor", autor.NomeAutor);
                    int codAutor = Convert.ToInt32(command.ExecuteScalar());
                    return codAutor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCodEditora(EditoraModel editora)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codEditora FROM mvtBibEditora WHERE nomeEditora = @nomeEditora");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@nomeEditora", editora.NomeEditora);
                    int codEditora = Convert.ToInt32(command.ExecuteScalar());
                    return codEditora;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCodSecao(SecaoModel secao)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codSecao FROM mvtBibSecao WHERE descricaoSecao = @descricaoSecao");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@descricaoSecao", secao.DescricaoSecao);
                    int codSecao = Convert.ToInt32(command.ExecuteScalar());
                    return codSecao;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCodLocal(LocalModel local)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codLocal FROM mvtBibLocal WHERE descricaoLocal = @descricaoLocal");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@descricaoLocal", local.DescricaoLocal);
                    int codLocal = Convert.ToInt32(command.ExecuteScalar());
                    return codLocal;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ItemAcervoModel> GetItensAcervo()
        {
            List<ItemAcervoModel> itensAcervos = new List<ItemAcervoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, numExemplar, nome, nomeAutor, nomeEditora, tipoItem, nomeLocal, ");
                sql.AppendLine("volume, anoEdicao, localizacao, secao, nomeColecao, statusItem FROM mvtBibItemAcervo ORDER BY codItem");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        itensAcervos.Add(PopulateDr(dr));
                    }
                }
            }
            return itensAcervos;
        }

        public ItemAcervoModel PopulateDr(SqlDataReader dr)
        {
            string codItem = "";
            string numExemplar = "";
            string nome = "";
            string tipoItem = "";
            string volume = "";
            string anoEdicao = "";
            string localizacao = "";
            string nomeColecao = "";
            string statusItem = "";
            AutorModel nomeAutor = null;
            EditoraModel nomeEditora = null;
            SecaoModel nomeSecao = null;
            LocalModel nomeLocal = null;

            if (DBNull.Value != dr["codItem"])
            {
                codItem = dr["codItem"] + "";
            }
            if (DBNull.Value != dr["numExemplar"])
            {
                numExemplar = dr["numExemplar"] + "";
            }
            if (DBNull.Value != dr["nome"])
            {
                nome = dr["nome"] + "";
            }
            if (DBNull.Value != dr["tipoItem"])
            {
                tipoItem = dr["tipoItem"] + "";
            }
            if (DBNull.Value != dr["volume"])
            {
                volume = dr["volume"] + "";
            }
            if (DBNull.Value != dr["anoEdicao"])
            {
                anoEdicao = dr["anoEdicao"] + "";
            }
            if (DBNull.Value != dr["localizacao"])
            {
                localizacao = dr["localizacao"] + "";
            }
            if (DBNull.Value != dr["nomeColecao"])
            {
                nomeColecao = dr["nomeColecao"] + "";
            }
            if (DBNull.Value != dr["statusItem"])
            {
                statusItem = dr["statusItem"] + "";
            }
            if (DBNull.Value != dr["nomeAutor"])
            {
                string autor = dr["nomeAutor"] + "";
                nomeAutor = new AutorModel()
                {
                    NomeAutor = autor
                };
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                string editora = dr["nomeEditora"] + "";
                nomeEditora = new EditoraModel()
                {
                    NomeEditora = editora
                };
            }
            if (DBNull.Value != dr["nomeLocal"])
            {
                string local = dr["nomeLocal"] + "";
                nomeLocal = new LocalModel()
                {
                    DescricaoLocal = local
                };
            }
            if (DBNull.Value != dr["secao"])
            {
                string secao = dr["secao"] + "";
                nomeSecao = new SecaoModel()
                {
                    DescricaoSecao = secao
                };
            }
            return new ItemAcervoModel()
            {
                CodItem = codItem,
                NumExemplar = numExemplar,
                Nome = nome,
                TipoItem = tipoItem,
                Volume = volume,
                AnoEdicao = anoEdicao,
                Localizacao = localizacao,
                NomeColecao = nomeColecao,
                StatusItem = statusItem,
                AutorModel = nomeAutor,
                EditoraModel = nomeEditora,
                SecaoModel = nomeSecao,
                LocalModel = nomeLocal
            };
        }
        public List<string> GetAutores(AutorModel autor)
        {
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT nomeAutor FROM mvtBibAutor WHERE nomeAutor LIKE @nomeAutor";
                        command.Parameters.AddWithValue("@nomeAutor", "%" + autor.NomeAutor + "%");

                        List<string> autores = new List<string>();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nomeAutor = reader["nomeAutor"].ToString();
                                autores.Add(nomeAutor);
                            }
                        }

                        return autores;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
