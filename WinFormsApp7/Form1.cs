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

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {
            
            CNPJ = txtCNPJ.Text;
        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {
            
            End = txtEnd.Text;
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            
            Tel = txtTel.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
            Email = txtEmail.Text;
        }

        private void btnCadastrese_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Nome)&&(!string.IsNullOrEmpty(CNPJ))&&(!string.IsNullOrEmpty(End))
                &&(!string.IsNullOrEmpty(Tel))&&(!string.IsNullOrEmpty(Email)))
            {
                MessageBox.Show("Cadastro bem sucedido!");
            }
            else 
            {
                MessageBox.Show("falha ao se cadastrar! Tente novamente");
            }

            Form2 form = new Form2();
            form.Show();
        }
    }
}
