using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp7
{
    public partial class Form5 : Form
    {
        // 🔹 Variáveis para armazenar os dados da sprint
        private string idSprint;
        private string nomeSprint;
        private DateTime dataInicioSprint;
        private DateTime dataFimSprint;
        private string statusSprint;

        public Form5()
        {
            InitializeComponent();
        }

        // 🔹 Eventos de TextBox e DateTimePicker
        private void id_da_sprint_projeto_TextChanged(object sender, EventArgs e)
        {
            idSprint = id_da_sprint_projeto.Text;
        }

        private void nome_sprint_TextChanged(object sender, EventArgs e)
        {
            nomeSprint = nome_sprint.Text;
        }

        private void data_iniciar_sprint_ValueChanged(object sender, EventArgs e)
        {
            dataInicioSprint = data_iniciar_sprint.Value;
        }

        private void data_fim_sprint_ValueChanged(object sender, EventArgs e)
        {
            dataFimSprint = data_fim_sprint.Value;
        }

        private void status_sprint_TextChanged(object sender, EventArgs e)
        {
            statusSprint = status_sprint.Text;
        }

        // 🔹 Botão para enviar os dados para o banco
        private void button_enviar_sprint_banco_dados_Click(object sender, EventArgs e)
        {
            // Validações básicas
            if (string.IsNullOrWhiteSpace(idSprint) || string.IsNullOrWhiteSpace(nomeSprint))
            {
                MessageBox.Show("Informe o ID e o nome da sprint.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Exemplo de mensagem (substituir por INSERT no banco)
            string mensagem = $"Sprint enviada ao banco!\n\n" +
                              $"ID: {idSprint}\n" +
                              $"Nome: {nomeSprint}\n" +
                              $"Data Início: {dataInicioSprint:dd/MM/yyyy}\n" +
                              $"Data Fim: {dataFimSprint:dd/MM/yyyy}\n" +
                              $"Status: {statusSprint}";

            MessageBox.Show(mensagem, "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: INSERT INTO Sprint (IdSprint, Nome, DataInicio, DataFim, Status) VALUES (...)
        }

        // 🔹 Botão para ir para o Form6
        private void button_pra_enviar_pro_form_6_nao_dados_Click(object sender, EventArgs e)
        {
            
            Form6 tela6 = new Form6();
            tela6.Show();

          
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
