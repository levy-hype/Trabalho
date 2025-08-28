using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {

        private string contratoId;
        private DateTime dataInicio;
        private DateTime dataFim;
        private decimal valorHoras;
        private string statusContrato;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ID_contrato_Click(object sender, EventArgs e)
        {

        }

        private void tex_contrato_TextChanged(object sender, EventArgs e)
        {
            contratoId = tex_contrato.Text;
        }

        private void data_fim_Click(object sender, EventArgs e)
        {

        }

        private void valor_hora_Click(object sender, EventArgs e)
        {

        }

        private void status_contrato_Click(object sender, EventArgs e)
        {

        }

        private void escolher_data_inciar_ValueChanged(object sender, EventArgs e)
        {
            dataInicio = escolher_data_inciar.Value;
        }

        private void digitar_horas_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(digitar_horas.Text, out decimal valor))
            {
                valorHoras = valor;
            }
            else
            {
                valorHoras = 0; // caso digite algo inválido
            }
        }

        private void escolher_data_fim_ValueChanged(object sender, EventArgs e)
        {
            dataFim = escolher_data_fim.Value;
        }

        private void status_TextChanged(object sender, EventArgs e)
        {
            statusContrato = status.Text;
        }

        private void button_contratar_Click(object sender, EventArgs e)
        {

            Form3 tela3 = new Form3(contratoId, dataInicio, dataFim, valorHoras, statusContrato);
            tela3.Show();
            this.Hide();
        }

        private void button_projeto_form4_Click(object sender, EventArgs e)
        {
            Form4 tela4 = new Form4();
            tela4.Show();        
            this.Hide(); 
        }
    }
}
