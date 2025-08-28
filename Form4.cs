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
    public partial class Form4 : Form
    {
        // 🔹 Variáveis para armazenar os dados do projeto
        private string numeroProjeto;
        private string nomeProjeto;
        private string descricaoProjeto;
        private string statusProjeto;

        public Form4()
        {
            InitializeComponent();
        }

        // 🔹 Eventos de TextBox
        private void numero_projeto_TextChanged(object sender, EventArgs e)
        {
            numeroProjeto = numero_projeto.Text;
        }

        private void nome_projeto_TextChanged(object sender, EventArgs e)
        {
            nomeProjeto = nome_projeto.Text;
        }

        private void descricao_projeto_TextChanged(object sender, EventArgs e)
        {
            descricaoProjeto = descricao_projeto.Text;
        }

        private void status_como_vai_projeto_TextChanged(object sender, EventArgs e)
        {
            statusProjeto = status_como_vai_projeto.Text;
        }

        // 🔹 Botão para salvar no banco de dados
        private void button_pra_ir_pro_banco_de_dados_Click(object sender, EventArgs e)
        {
            // Validação simples
            if (string.IsNullOrWhiteSpace(numeroProjeto) || string.IsNullOrWhiteSpace(nomeProjeto))
            {
                MessageBox.Show("Número e nome do projeto são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Exemplo de mensagem (substituir por INSERT no banco depois)
            string mensagem = $"Projeto salvo no banco!\n\n" +
                              $"Número: {numeroProjeto}\n" +
                              $"Nome: {nomeProjeto}\n" +
                              $"Descrição: {descricaoProjeto}\n" +
                              $"Status: {statusProjeto}";

            MessageBox.Show(mensagem, "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
        }

        private void button_pra_enviar_form5_Click(object sender, EventArgs e)
        {
            Form5 tela5 = new Form5();
            tela5.Show();
            this.Hide(); 
        }
    }
}
