using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoN1.Model
{
    class Carro
    {
        private string Placa;
        private string Marca;
        private string Modelo;
        private string Ano;
        private string NomeProprietario;
        private DateTime DataNasc;
        private string Cpf;
        private string Contato;
        private string Email;


        //GETTERS
        public string GetPlaca()
        {
            return this.Placa;
        }

        public string GetMarca()
        {
            return this.Marca;
        }

        public string GetModelo()
        {
            return this.Modelo;
        }

        public string GetAno()
        {
            return this.Ano;
        }
        
        public string GetNomeProprietario()
        {
            return this.NomeProprietario;
        }

        public DateTime GetDataNasc()
        {
            return this.DataNasc;
        }

        public string GetCpf()
        {
            return this.Cpf;
        }

        public string GetContato()
        {
            return this.Contato;
        }

        public string GetEmail()
        {
            return this.Email;
        }


        //SETTERS

        public void SetPlaca(string placa)
        {
            this.Placa = placa;
        }

        public void SetMarca(string marca)
        {
            this.Marca = marca;
        }

        public void SetModelo(string modelo)
        {
            this.Modelo = modelo;
        }
        
        public void SetAno(string ano)
        {
            this.Ano = ano;
        }

        public void SetNomeProprietario(string nome)
        {
            this.NomeProprietario = nome;
        }

        public void SetDataNasc(DateTime data)
        {
            if (data <= DateTime.Today)
            {
                this.DataNasc = data;
            }
            else
            {
                throw new Exception("DATA DE NASCIMENTO INVALIDA!");
            }
        }  //OK

        public void SetCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            String tempCpf;
            String digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (cpf.Length != 11)
                throw new Exception("CPF INVÁLIDO!");
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            if (cpf.EndsWith(digito))
                this.Cpf = cpf;
            else
                throw new Exception("CPF INVALIDO!");
        } //OK

        public void SetContato(string contato)
        {
            string modelo = "^[0-9]{2}-([0-9]{8}|[0-9]{9})";
            if (System.Text.RegularExpressions.Regex.IsMatch(contato, modelo))
            {
                this.Contato = contato;
            }
            else
            {
                throw new Exception("Contato Inválido");
            }
        } //OK

        public void SetEmail(string email)
        {
            string modelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, modelo))
            {
                this.Email = email;
            }
            else
            {
                throw new Exception("EMAIL INVÁLIDO");
            }
        }  //OK

    }
}
