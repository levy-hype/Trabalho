using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        string Nome;
        string CNPJ;
        string End;
        string Tel;
        string Email;
        string Senha;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

            Nome = txtNome.Text;
        }

        private void maskCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            CNPJ = maskCNPJ.Text;
        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {

            End = txtEnd.Text;
        }
        private void maskTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Tel = maskTel.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

            Email = txtEmail.Text;
        }
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            Senha = txtSenha.Text;
        }

        private void btnCadastrese_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Nome) && (!string.IsNullOrEmpty(CNPJ)) && (!string.IsNullOrEmpty(End))
                && (!string.IsNullOrEmpty(Tel)) && (!string.IsNullOrEmpty(Email)) && (!string.IsNullOrEmpty(Senha)))
            {
                MessageBox.Show("Cadastro bem sucedido!");
            }
            else
            {
                MessageBox.Show("falha ao se cadastrar! Tente novamente");
            }

            if (Email.Contains("@gmail.com"))
            {
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show("Coloque algum E-mail válido!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_tela_form2_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2();
            tela2.Show();
            this.Hide();
        }
    }
}
