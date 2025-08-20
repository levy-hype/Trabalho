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
            txtCNPJ = new TextBox();
            txtEmail = new TextBox();
            txtTel = new TextBox();
            lblEmail = new Label();
            btnCadastrese = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = SystemColors.ButtonHighlight;
            lblNome.Location = new Point(10, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.ForeColor = SystemColors.ButtonHighlight;
            lblCNPJ.Location = new Point(10, 89);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(34, 15);
            lblCNPJ.TabIndex = 2;
            lblCNPJ.Text = "CNPJ";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.ForeColor = SystemColors.ButtonHighlight;
            lblEnd.Location = new Point(10, 138);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(56, 15);
            lblEnd.TabIndex = 3;
            lblEnd.Text = "Endereço";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.ForeColor = SystemColors.ButtonHighlight;
            lblTel.Location = new Point(10, 185);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(51, 15);
            lblTel.TabIndex = 4;
            lblTel.Text = "Telefone";
            lblTel.Click += lblTel_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(275, 23);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(12, 152);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(275, 23);
            txtEnd.TabIndex = 6;
            txtEnd.TextChanged += txtEnd_TextChanged;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(12, 103);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(275, 23);
            txtCNPJ.TabIndex = 7;
            txtCNPJ.TextChanged += txtCNPJ_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 248);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 23);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(12, 199);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(275, 23);
            txtTel.TabIndex = 9;
            txtTel.TextChanged += txtTel_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = SystemColors.ButtonHighlight;
            lblEmail.Location = new Point(10, 233);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "E-mail";
            // 
            // btnCadastrese
            // 
            btnCadastrese.Location = new Point(241, 315);
            btnCadastrese.Name = "btnCadastrese";
            btnCadastrese.Size = new Size(81, 32);
            btnCadastrese.TabIndex = 11;
            btnCadastrese.Text = "Cadastre-se ";
            btnCadastrese.UseVisualStyleBackColor = true;
            btnCadastrese.Click += btnCadastrese_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(209, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 12;
            label1.Text = "TELA DE LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.will;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(569, 359);
            Controls.Add(label1);
            Controls.Add(btnCadastrese);
            Controls.Add(lblEmail);
            Controls.Add(txtTel);
            Controls.Add(txtEmail);
            Controls.Add(txtCNPJ);
            Controls.Add(txtEnd);
            Controls.Add(txtNome);
            Controls.Add(lblTel);
            Controls.Add(lblEnd);
            Controls.Add(lblCNPJ);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox txtCNPJ;
        private TextBox txtEmail;
        private TextBox txtTel;
        private Label lblEmail;
        private Button btnCadastrese;
        private Label label1;
    }
}
