using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItemDoAcervo
{
    public class AutorDAO
    {
        private SqlConnection Connection { get; }

        public AutorDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<AutorModel> GetAutores()
        {
            List<AutorModel> autores = new List<AutorModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codAutor, nomeAutor FROM mvtBibAutor ORDER BY codAutor");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        autores.Add(PopulateDrAutor(dr));
                    }
                }
            }
            return autores;
        }

        public AutorModel PopulateDrAutor(SqlDataReader dr)
        {
            string codAutor = "";
            string nomeAutor = "";

            if (DBNull.Value != dr["codAutor"])
            {
                codAutor = dr["codAutor"] + "";
            }
            if (DBNull.Value != dr["nomeAutor"])
            {
                nomeAutor = dr["nomeAutor"] + "";
            }

            return new AutorModel()
            {
                CodAutor = codAutor,
                NomeAutor = nomeAutor
            };
        }
    }
}
