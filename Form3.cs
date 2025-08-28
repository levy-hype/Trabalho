using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Globalization;

namespace WinFormsApp7
{
    public partial class Form3 : Form
    {

        private string contratoId;
        private DateTime dataInicio;
        private DateTime dataFim;
        private decimal valorHoras;       // valor da HORA (R$/h)
        private string statusContrato;


        private string idFatura;
        private string periodoFatura;     // <- agora não conflita com o TextBox periodo
        private decimal valorFinalProjeto;
        private string statusFinalizado;

        public Form3(string contratoId)
        {
            InitializeComponent();
            this.contratoId = contratoId;
        }

        public Form3(string contratoId, DateTime dataInicio, DateTime dataFim, decimal valorHoras, string statusContrato) : this(contratoId)
        {
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            this.valorHoras = valorHoras;
            this.statusContrato = statusContrato;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Preenche o período automaticamente no TextBox "periodo"
            periodoFatura = $"{dataInicio:dd/MM/yyyy} - {dataFim:dd/MM/yyyy}";
            periodo.Text = periodoFatura;

            // Calcula o valor final inicial e mostra no TextBox "valor_final_projeto"
            RecalcularValorFinal();

            // Status inicial herdado do contrato
            statusFinalizado = statusContrato;
            status_finalizado.Text = statusFinalizado;
        }

        private void RecalcularValorFinal()
        {
            // Total de horas entre as datas * valor da hora
            var horas = (decimal)(dataFim - dataInicio).TotalHours;
            if (horas < 0) horas = 0;

            valorFinalProjeto = Math.Round(horas * valorHoras, 2);
            valor_final_projeto.Text = valorFinalProjeto.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void ID_fatura_TextChanged(object sender, EventArgs e)
        {
            idFatura = ID_fatura.Text;
        }

        private void periodo_TextChanged(object sender, EventArgs e)
        {
            // Lê do TextBox chamado "periodo"
            periodoFatura = periodo.Text;
        }

        private void valor_final_projeto_TextChanged(object sender, EventArgs e)
        {
            var cultura = CultureInfo.GetCultureInfo("pt-BR");
            if (decimal.TryParse(valor_final_projeto.Text, NumberStyles.Any, cultura, out var valor))
            {
                valorFinalProjeto = valor;
            }
        }

        private void status_finalizado_TextChanged(object sender, EventArgs e)
        {
            statusFinalizado = status_finalizado.Text;
        }

        private void button_de_gerar_fatura_projeto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idFatura))
            {
                MessageBox.Show("Informe o ID da fatura.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(periodoFatura))
            {
                MessageBox.Show("Informe o período.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resumo = $"Fatura Gerada!\n\n" +
                            $"Contrato: {contratoId}\n" +
                            $"ID Fatura: {idFatura}\n" +
                            $"Período: {periodoFatura}\n" +
                            $"Valor Final: {valorFinalProjeto.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}\n" +
                            $"Status: {statusFinalizado}";

            MessageBox.Show(resumo, "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button_voltar_pro_2_Click(object sender, EventArgs e)
        {
           
            Form2 tela2 = new Form2();
            tela2.Show();
            this.Close();
        }
    }
}

