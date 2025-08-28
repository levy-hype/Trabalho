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
    public partial class Form6 : Form
    {
    
        private string idTarefa;
        private string nomeTarefa;
        private string descricaoTarefa;
        private string statusTarefa;
        private decimal percentualConclusao;

        public Form6()
        {
            InitializeComponent();
        }

   
        private void ID_da_tarefa_TextChanged(object sender, EventArgs e)
        {
            idTarefa = ID_da_tarefa.Text;
        }

        private void Nome_tarefa_TextChanged(object sender, EventArgs e)
        {
            nomeTarefa = Nome_tarefa.Text;
        }

        private void descricao_da_tarefa_TextChanged(object sender, EventArgs e)
        {
            descricaoTarefa = descricao_da_tarefa.Text;
        }

        private void status_da_tarefa_TextChanged(object sender, EventArgs e)
        {
            statusTarefa = status_da_tarefa.Text;
        }

        private void percentual_conclusao_da_tarefa_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(percentual_conclusao_da_tarefa.Text, out decimal valor))
            {
                percentualConclusao = valor;
            }
            else
            {
                percentualConclusao = 0;
            }
        }


        private void button_enviar_banco_de_dados_Click(object sender, EventArgs e)
        {
            // Validações básicas
            if (string.IsNullOrWhiteSpace(idTarefa) || string.IsNullOrWhiteSpace(nomeTarefa))
            {
                MessageBox.Show("Informe o ID e o nome da tarefa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Exemplo de mensagem simulando envio ao banco
            string mensagem = $"Tarefa enviada ao banco!\n\n" +
                              $"ID: {idTarefa}\n" +
                              $"Nome: {nomeTarefa}\n" +
                              $"Descrição: {descricaoTarefa}\n" +
                              $"Status: {statusTarefa}\n" +
                              $"Percentual Conclusão: {percentualConclusao}%";

            MessageBox.Show(mensagem, "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
        }

        private void Enviar_proxima_tela_form7_Click(object sender, EventArgs e)
        {

        }
    }
}
