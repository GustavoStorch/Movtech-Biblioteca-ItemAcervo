using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItemDoAcervo
{
    public class SecaoDAO
    {
        private SqlConnection Connection { get; }

        public SecaoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<SecaoModel> GetSecoes()
        {
            List<SecaoModel> secoes = new List<SecaoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codSecao, descricaoSecao FROM mvtBibSecao ORDER BY codSecao");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        secoes.Add(PopulateDrSecao(dr));
                    }
                }
            }
            return secoes;
        }

        public SecaoModel PopulateDrSecao(SqlDataReader dr)
        {
            string codSecao = "";
            string descricaoSecao = "";

            if (DBNull.Value != dr["codSecao"])
            {
                codSecao = dr["codSecao"] + "";
            }
            if (DBNull.Value != dr["descricaoSecao"])
            {
                descricaoSecao = dr["descricaoSecao"] + "";
            }

            return new SecaoModel()
            {
                CodSecao = codSecao,
                DescricaoSecao = descricaoSecao
            };
        }
    }
}
