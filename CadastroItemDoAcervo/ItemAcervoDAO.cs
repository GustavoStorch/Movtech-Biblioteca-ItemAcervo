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
