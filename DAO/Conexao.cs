using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoBancoN1.DAO
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projetos\Faculdade\Banco de Dados\ProjetoBancoN1\Garagem.mdf;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch(Exception e)
                {
                    throw new Exception("Falha de Conexão" + e.Message);
                }
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {

                try
                {
                    con.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Falha ao fechar a Conexão!" + e.Message);

                }

            }
        }
    }
}
