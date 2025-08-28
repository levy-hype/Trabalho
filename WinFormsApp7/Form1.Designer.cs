namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblCNPJ = new Label();
            lblEnd = new Label();
            lblTel = new Label();
            txtNome = new TextBox();
            txtEnd = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnCadastrese = new Button();
            maskCNPJ = new MaskedTextBox();
            maskTel = new MaskedTextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            button_tela_form2 = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = SystemColors.ButtonHighlight;
            lblNome.Location = new Point(274, 31);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.ForeColor = SystemColors.ButtonHighlight;
            lblCNPJ.Location = new Point(274, 112);
            lblCNPJ.Margin = new Padding(4, 0, 4, 0);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(51, 25);
            lblCNPJ.TabIndex = 2;
            lblCNPJ.Text = "CNPJ";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.ForeColor = SystemColors.ButtonHighlight;
            lblEnd.Location = new Point(274, 194);
            lblEnd.Margin = new Padding(4, 0, 4, 0);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(85, 25);
            lblEnd.TabIndex = 3;
            lblEnd.Text = "Endereço";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.ForeColor = SystemColors.ButtonHighlight;
            lblTel.Location = new Point(274, 272);
            lblTel.Margin = new Padding(4, 0, 4, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(77, 25);
            lblTel.TabIndex = 4;
            lblTel.Text = "Telefone";
            lblTel.Click += lblTel_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(277, 54);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(391, 31);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(277, 217);
            txtEnd.Margin = new Padding(4, 5, 4, 5);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(391, 31);
            txtEnd.TabIndex = 6;
            txtEnd.TextChanged += txtEnd_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(277, 377);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(391, 31);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = SystemColors.ButtonHighlight;
            lblEmail.Location = new Point(274, 352);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 25);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "E-mail";
            // 
            // btnCadastrese
            // 
            btnCadastrese.Location = new Point(704, 445);
            btnCadastrese.Margin = new Padding(4, 5, 4, 5);
            btnCadastrese.Name = "btnCadastrese";
            btnCadastrese.Size = new Size(116, 53);
            btnCadastrese.TabIndex = 11;
            btnCadastrese.Text = "Cadastre-se ";
            btnCadastrese.UseVisualStyleBackColor = true;
            btnCadastrese.Click += btnCadastrese_Click;
            // 
            // maskCNPJ
            // 
            maskCNPJ.Location = new Point(274, 137);
            maskCNPJ.Mask = "000-000-000";
            maskCNPJ.Name = "maskCNPJ";
            maskCNPJ.Size = new Size(394, 31);
            maskCNPJ.TabIndex = 13;
            maskCNPJ.MaskInputRejected += maskCNPJ_MaskInputRejected;
            // 
            // maskTel
            // 
            maskTel.Location = new Point(277, 295);
            maskTel.Mask = "(99) 00000-0000";
            maskTel.Name = "maskTel";
            maskTel.Size = new Size(391, 31);
            maskTel.TabIndex = 14;
            maskTel.MaskInputRejected += maskTel_MaskInputRejected;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.ForeColor = SystemColors.ButtonHighlight;
            lblSenha.Location = new Point(274, 420);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 25);
            lblSenha.TabIndex = 16;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(277, 445);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(391, 31);
            txtSenha.TabIndex = 15;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // button_tela_form2
            // 
            button_tela_form2.Location = new Point(704, 377);
            button_tela_form2.Name = "button_tela_form2";
            button_tela_form2.Size = new Size(112, 48);
            button_tela_form2.TabIndex = 17;
            button_tela_form2.Text = "Proximo";
            button_tela_form2.UseVisualStyleBackColor = true;
            button_tela_form2.Click += button_tela_form2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.will;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1027, 548);
            Controls.Add(button_tela_form2);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(maskTel);
            Controls.Add(maskCNPJ);
            Controls.Add(btnCadastrese);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtEnd);
            Controls.Add(txtNome);
            Controls.Add(lblTel);
            Controls.Add(lblEnd);
            Controls.Add(lblCNPJ);
            Controls.Add(lblNome);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNome;
        private Label lblCNPJ;
        private Label lblEnd;
        private Label lblTel;
        private TextBox txtNome;
        private TextBox txtEnd;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnCadastrese;
        private MaskedTextBox maskCNPJ;
        private MaskedTextBox maskTel;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button button_tela_form2;
    }
}
