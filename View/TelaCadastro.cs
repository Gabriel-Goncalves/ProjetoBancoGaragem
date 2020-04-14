using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoBancoN1.Controller;
using ProjetoBancoN1.View;

namespace ProjetoBancoN1.View
{
    public partial class TelaCadastro : Form
    {

        CarroCotroller carroControler = new CarroCotroller();

        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data;
            string placa, marca, modelo, ano, nome, cpf, contato, email;

            data = dateTimePicker_DataNasc.Value;
            placa = maskedTextBox_Placa.Text;
            marca = textBox_Marca.Text;
            modelo = textBox_Modelo.Text;
            ano = textBox_Ano.Text;
            nome = textBox_Nome.Text;
            cpf = maskedTextBox_Cpf.Text;
            contato = maskedTextBox_Contato.Text;
            email = textBox_Email.Text;

            try
            {
                if(MessageBox.Show("Deseja cadastrar o veículo?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    carroControler.Gravar(placa, marca, modelo, ano, nome, data, cpf, contato, email);
                    dateTimePicker_DataNasc.Value = DateTime.Today;
                    maskedTextBox_Placa.Text = "";
                    textBox_Marca.Text = "";
                    textBox_Modelo.Text = "";
                    textBox_Ano.Text = "";
                    textBox_Nome.Text = "";
                    maskedTextBox_Cpf.Text = "";
                    maskedTextBox_Contato.Text = "";
                    textBox_Email.Text = "";

                    MessageBox.Show("Veículo Cadastrado com Sucesso!");

                }
            }catch(Exception m)
            {
                MessageBox.Show(m.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_DataNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_Placa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox_Marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Modelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Ano_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_Cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox_Contato_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisa t = new TelaPesquisa();
            t.Show();
        }
    }
}
