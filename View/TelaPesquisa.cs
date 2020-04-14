using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoBancoN1.Model;
using ProjetoBancoN1.Controller;

namespace ProjetoBancoN1.View
{
    public partial class TelaPesquisa : Form
    {
        public TelaPesquisa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_Placa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string placa = maskedTextBox_Placa.Text;
            CarroCotroller carroController = new CarroCotroller();
            Carro carro = new Carro();

            try
            {
                carro = carroController.PesquisarCarroPlaca(placa);
                if(carro == null)
                {
                    MessageBox.Show("Veículo não foi encontrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    textBox1.Text = carro.GetMarca();
                    textBox2.Text = carro.GetModelo();
                    textBox3.Text = carro.GetAno();
                    textBox4.Text = carro.GetNomeProprietario();
                    textBox5.Text = carro.GetEmail();
                    textBox6.Text = carro.GetCpf();
                    textBox7.Text = carro.GetDataNasc().ToShortDateString(); //Convert.ToString(carro.GetDataNasc());
                    textBox8.Text = carro.GetContato();
                    button1.Enabled = false;
                    maskedTextBox_Placa.Enabled = false;

                }

            }catch(Exception m)
            {
                MessageBox.Show("Botao Pesquisar Tela pesquisa " + m.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            maskedTextBox_Placa.Clear();
            button1.Enabled = true;
            maskedTextBox_Placa.Enabled = true;
        }
    }
}
