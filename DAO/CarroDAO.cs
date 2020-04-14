using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjetoBancoN1.Model;

namespace ProjetoBancoN1.DAO
{
    class CarroDAO
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public void Gravar(Carro carro)
        {
            cmd.CommandText = "insert into Carro(placa, marca, modelo, ano, nome, data_nasc, cpf, contato, email) values (@placa, @marca, @modelo, @ano, @nome, @data_nasc, @cpf, @contato, @email)";
            cmd.Parameters.AddWithValue("@placa", carro.GetPlaca());
            cmd.Parameters.AddWithValue("@marca", carro.GetMarca());
            cmd.Parameters.AddWithValue("@modelo", carro.GetModelo());
            cmd.Parameters.AddWithValue("@ano", carro.GetAno());
            cmd.Parameters.AddWithValue("@nome", carro.GetNomeProprietario());
            cmd.Parameters.AddWithValue("@data_nasc", carro.GetDataNasc());
            cmd.Parameters.AddWithValue("@cpf", carro.GetCpf());
            cmd.Parameters.AddWithValue("@contato", carro.GetContato());
            cmd.Parameters.AddWithValue("@email", carro.GetEmail());

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
            }
            catch (Exception e)
            {
                throw new Exception("CarroDAO" + e.Message);
            }
        }

        public Carro PesquisarCarroPlaca(string placa)
        {
            SqlCommand cmd = new SqlCommand();
            Carro carro = new Carro();
            cmd.CommandText = " select * from Carro where placa = @placa";
            cmd.Parameters.AddWithValue("@placa", placa);

            SqlDataReader dr;

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    carro.SetPlaca(dr.GetString(1));
                    carro.SetMarca(dr.GetString(2));
                    carro.SetModelo(dr.GetString(3));
                    carro.SetAno(dr.GetString(4));
                    carro.SetNomeProprietario(dr.GetString(5));
                    carro.SetDataNasc(dr.GetDateTime(6));
                    carro.SetCpf(dr.GetString(7));
                    carro.SetContato(dr.GetString(8));
                    carro.SetEmail(dr.GetString(9));
                    return carro;
                }
                else
                {
                    return null;
                }
            }catch(Exception e)
            {
                throw new Exception("Carro DAO Pesquisa ***Erro*** " + e.Message);
            }
        }



    }
}
