using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItemDoAcervo
{
    public class EditoraDAO
    {
        private SqlConnection Connection { get; }

        public EditoraDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<EditoraModel> GetEditoras()
        {
            List<EditoraModel> autores = new List<EditoraModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codEditora, nomeEditora FROM mvtBibEditora ORDER BY codEditora");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        autores.Add(PopulateDrEditora(dr));
                    }
                }
            }
            return autores;
        }

        public EditoraModel PopulateDrEditora(SqlDataReader dr)
        {
            string codEditora = "";
            string nomeEditora = "";

            if (DBNull.Value != dr["codEditora"])
            {
                codEditora = dr["codEditora"] + "";
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                nomeEditora = dr["nomeEditora"] + "";
            }

            return new EditoraModel()
            {
                CodEditora = codEditora,
                NomeEditora = nomeEditora
            };
        }
    }
}
