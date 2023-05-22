using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItemDoAcervo
{
    public class LocalDAO
    {
        private SqlConnection Connection { get; }

        public LocalDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<LocalModel> GetLocais()
        {
            List<LocalModel> locais = new List<LocalModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codLocal, descricaoLocal FROM mvtBibLocal ORDER BY codLocal");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        locais.Add(PopulateDrLocal(dr));
                    }
                }
            }
            return locais;
        }

        public LocalModel PopulateDrLocal(SqlDataReader dr)
        {
            string codLocal = "";
            string descricaoLocal = "";

            if (DBNull.Value != dr["codLocal"])
            {
                codLocal = dr["codLocal"] + "";
            }
            if (DBNull.Value != dr["descricaoLocal"])
            {
                descricaoLocal = dr["descricaoLocal"] + "";
            }

            return new LocalModel()
            {
                CodLocal = codLocal,
                DescricaoLocal = descricaoLocal
            };
        }


    }
}
