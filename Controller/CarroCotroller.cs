using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBancoN1.Model;
using ProjetoBancoN1.DAO;

namespace ProjetoBancoN1.Controller
{
    class CarroCotroller
    {
        CarroDAO carroDao = new CarroDAO();

        public void Gravar(string Placa, string Marca, string Modelo, string Ano, string Nome, DateTime Data_nasc, string Cpf, string Contato, string Email)
        {
            Carro carro = new Carro();

            try
            {
                carro.SetPlaca(Placa);
                carro.SetMarca(Marca);
                carro.SetModelo(Modelo);
                carro.SetAno(Ano);
                carro.SetNomeProprietario(Nome);
                carro.SetDataNasc(Data_nasc);
                carro.SetCpf(Cpf);
                carro.SetContato(Contato);
                carro.SetEmail(Email);
                carroDao.Gravar(carro);
            }
            catch(Exception e)
            {
                throw new Exception("CarroController aqui " + e.Message + " ");
            }
        }

        public Carro PesquisarCarroPlaca(string placa)
        {
            Carro carro = new Carro();
            try
            {
                carro.SetPlaca(placa);
                carro = carroDao.PesquisarCarroPlaca(carro.GetPlaca());
                return carro;
            } 
            catch(Exception e)
            {
                throw new Exception("Carro Controller Pesquisar " + e.Message);
            }

        }
    }
}
