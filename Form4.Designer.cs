namespace WinFormsApp7
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label_Projeto = new Label();
            nome_labebel = new Label();
            Labbel_descritiva = new Label();
            como_vai_serviço = new Label();
            numero_projeto = new TextBox();
            nome_projeto = new TextBox();
            status_como_vai_projeto = new TextBox();
            descricao_projeto = new TextBox();
            button_pra_ir_pro_banco_de_dados = new Button();
            button_pra_enviar_form5 = new Button();
            SuspendLayout();
            // 
            // label_Projeto
            // 
            label_Projeto.AutoSize = true;
            label_Projeto.BackColor = SystemColors.ActiveCaptionText;
            label_Projeto.ForeColor = SystemColors.ButtonFace;
            label_Projeto.Location = new Point(237, 111);
            label_Projeto.Name = "label_Projeto";
            label_Projeto.Size = new Size(119, 25);
            label_Projeto.TabIndex = 0;
            label_Projeto.Text = "ID do Projeto";
            // 
            // nome_labebel
            // 
            nome_labebel.AutoSize = true;
            nome_labebel.BackColor = SystemColors.ActiveCaptionText;
            nome_labebel.ForeColor = SystemColors.ButtonFace;
            nome_labebel.Location = new Point(237, 167);
            nome_labebel.Name = "nome_labebel";
            nome_labebel.Size = new Size(61, 25);
            nome_labebel.TabIndex = 1;
            nome_labebel.Text = "Nome";
            // 
            // Labbel_descritiva
            // 
            Labbel_descritiva.AutoSize = true;
            Labbel_descritiva.BackColor = SystemColors.ActiveCaptionText;
            Labbel_descritiva.ForeColor = SystemColors.ButtonFace;
            Labbel_descritiva.Location = new Point(237, 232);
            Labbel_descritiva.Name = "Labbel_descritiva";
            Labbel_descritiva.Size = new Size(88, 25);
            Labbel_descritiva.TabIndex = 2;
            Labbel_descritiva.Text = "Descrição";
            // 
            // como_vai_serviço
            // 
            como_vai_serviço.AutoSize = true;
            como_vai_serviço.BackColor = SystemColors.ActiveCaptionText;
            como_vai_serviço.ForeColor = SystemColors.ButtonFace;
            como_vai_serviço.Location = new Point(237, 289);
            como_vai_serviço.Name = "como_vai_serviço";
            como_vai_serviço.Size = new Size(60, 25);
            como_vai_serviço.TabIndex = 3;
            como_vai_serviço.Text = "Status";
            // 
            // numero_projeto
            // 
            numero_projeto.Location = new Point(373, 111);
            numero_projeto.Name = "numero_projeto";
            numero_projeto.Size = new Size(179, 31);
            numero_projeto.TabIndex = 4;
            numero_projeto.TextChanged += numero_projeto_TextChanged;
            // 
            // nome_projeto
            // 
            nome_projeto.Location = new Point(373, 167);
            nome_projeto.Name = "nome_projeto";
            nome_projeto.Size = new Size(179, 31);
            nome_projeto.TabIndex = 5;
            nome_projeto.TextChanged += nome_projeto_TextChanged;
            // 
            // status_como_vai_projeto
            // 
            status_como_vai_projeto.Location = new Point(373, 283);
            status_como_vai_projeto.Name = "status_como_vai_projeto";
            status_como_vai_projeto.Size = new Size(179, 31);
            status_como_vai_projeto.TabIndex = 7;
            status_como_vai_projeto.TextChanged += status_como_vai_projeto_TextChanged;
            // 
            // descricao_projeto
            // 
            descricao_projeto.Location = new Point(373, 227);
            descricao_projeto.Name = "descricao_projeto";
            descricao_projeto.Size = new Size(179, 31);
            descricao_projeto.TabIndex = 6;
            descricao_projeto.TextChanged += descricao_projeto_TextChanged;
            // 
            // button_pra_ir_pro_banco_de_dados
            // 
            button_pra_ir_pro_banco_de_dados.Location = new Point(134, 378);
            button_pra_ir_pro_banco_de_dados.Name = "button_pra_ir_pro_banco_de_dados";
            button_pra_ir_pro_banco_de_dados.Size = new Size(315, 34);
            button_pra_ir_pro_banco_de_dados.TabIndex = 8;
            button_pra_ir_pro_banco_de_dados.Text = "Enviar Projeto";
            button_pra_ir_pro_banco_de_dados.UseVisualStyleBackColor = true;
            button_pra_ir_pro_banco_de_dados.Click += button_pra_ir_pro_banco_de_dados_Click;
            // 
            // button_pra_enviar_form5
            // 
            button_pra_enviar_form5.Location = new Point(455, 378);
            button_pra_enviar_form5.Name = "button_pra_enviar_form5";
            button_pra_enviar_form5.Size = new Size(315, 34);
            button_pra_enviar_form5.TabIndex = 9;
            button_pra_enviar_form5.Text = "Continuar";
            button_pra_enviar_form5.UseVisualStyleBackColor = true;
            button_pra_enviar_form5.Click += button_pra_enviar_form5_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(816, 468);
            Controls.Add(button_pra_enviar_form5);
            Controls.Add(button_pra_ir_pro_banco_de_dados);
            Controls.Add(status_como_vai_projeto);
            Controls.Add(descricao_projeto);
            Controls.Add(nome_projeto);
            Controls.Add(numero_projeto);
            Controls.Add(como_vai_serviço);
            Controls.Add(Labbel_descritiva);
            Controls.Add(nome_labebel);
            Controls.Add(label_Projeto);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Projeto;
        private Label nome_labebel;
        private Label Labbel_descritiva;
        private Label como_vai_serviço;
        private TextBox numero_projeto;
        private TextBox nome_projeto;
        private TextBox status_como_vai_projeto;
        private TextBox descricao_projeto;
        private Button button_pra_ir_pro_banco_de_dados;
        private Button button_pra_enviar_form5;
    }
}