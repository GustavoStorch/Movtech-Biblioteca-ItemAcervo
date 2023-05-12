using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItemDoAcervo
{
    public class ItemAcervoDAO
    {
        private SqlConnection Connection { get; }

        public ItemAcervoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public void Salvar(ItemAcervoModel itemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibItemAcervo(codLocal, numExemplar, nome, codAutor," +
                        $"nomeAutor, codEditora, nomeEditora, tipoItem, nomeLocal, volume, anoEdicao, localizacao," +
                        $"codSecao, secao, idioma) VALUES(@codLocal, @numExemplar, @nome, @codAutor, @nomeAutor, @codEditora," +
                        $"@nomeEditora, @tipoItem, @nomeLocal, @volume, @anoEdicao, @localizacao, @codSecao, @secao, @idioma)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codLocal", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@numExemplar", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@nome", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@codAutor", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@nomeAutor", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@codEditora", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@nomeEditora", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@tipoItem", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@nomeLocal", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@volume", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@anoEdicao", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@localizacao", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@codSecao", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@secao", itemAcervo.CodLocal));
                    command.Parameters.Add(new SqlParameter("@idioma", itemAcervo.CodLocal));
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

        public void Editar(ItemAcervoModel itemAcervo)
        {

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

        public List<ItemAcervoModel> GetItensAcervo()
        {
            return null;
        }

        public ItemAcervoModel PopulateDr(SqlDataReader dr)
        {
            return null;
        }
    }
}
