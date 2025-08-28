namespace WinFormsApp7
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label_sprint = new Label();
            nome_sprint_label = new Label();
            label3 = new Label();
            label4 = new Label();
            id_da_sprint_projeto = new TextBox();
            nome_sprint = new TextBox();
            label5 = new Label();
            status_sprint = new TextBox();
            data_iniciar_sprint = new DateTimePicker();
            data_fim_sprint = new DateTimePicker();
            button_enviar_sprint_banco_dados = new Button();
            button_pra_enviar_pro_form_6_nao_dados = new Button();
            SuspendLayout();
            // 
            // label_sprint
            // 
            label_sprint.AutoSize = true;
            label_sprint.BackColor = SystemColors.ActiveCaptionText;
            label_sprint.ForeColor = SystemColors.ButtonFace;
            label_sprint.Location = new Point(237, 77);
            label_sprint.Name = "label_sprint";
            label_sprint.Size = new Size(109, 25);
            label_sprint.TabIndex = 0;
            label_sprint.Text = "ID Da Sprint";
            // 
            // nome_sprint_label
            // 
            nome_sprint_label.AutoSize = true;
            nome_sprint_label.BackColor = SystemColors.ActiveCaptionText;
            nome_sprint_label.ForeColor = SystemColors.ButtonFace;
            nome_sprint_label.Location = new Point(280, 133);
            nome_sprint_label.Name = "nome_sprint_label";
            nome_sprint_label.Size = new Size(66, 25);
            nome_sprint_label.TabIndex = 1;
            nome_sprint_label.Text = "Nome ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(263, 234);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 3;
            label3.Text = "Data Fim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(246, 181);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 2;
            label4.Text = "Data Iniciar";
            // 
            // id_da_sprint_projeto
            // 
            id_da_sprint_projeto.Location = new Point(376, 74);
            id_da_sprint_projeto.Name = "id_da_sprint_projeto";
            id_da_sprint_projeto.Size = new Size(161, 31);
            id_da_sprint_projeto.TabIndex = 4;
            id_da_sprint_projeto.TextChanged += id_da_sprint_projeto_TextChanged;
            // 
            // nome_sprint
            // 
            nome_sprint.Location = new Point(376, 130);
            nome_sprint.Name = "nome_sprint";
            nome_sprint.Size = new Size(161, 31);
            nome_sprint.TabIndex = 5;
            nome_sprint.TextChanged += nome_sprint_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(280, 290);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 8;
            label5.Text = "Status";
            // 
            // status_sprint
            // 
            status_sprint.Location = new Point(376, 290);
            status_sprint.Name = "status_sprint";
            status_sprint.Size = new Size(161, 31);
            status_sprint.TabIndex = 9;
            status_sprint.TextChanged += status_sprint_TextChanged;
            // 
            // data_iniciar_sprint
            // 
            data_iniciar_sprint.Location = new Point(376, 181);
            data_iniciar_sprint.Name = "data_iniciar_sprint";
            data_iniciar_sprint.Size = new Size(194, 31);
            data_iniciar_sprint.TabIndex = 10;
            data_iniciar_sprint.ValueChanged += data_iniciar_sprint_ValueChanged;
            // 
            // data_fim_sprint
            // 
            data_fim_sprint.Location = new Point(376, 234);
            data_fim_sprint.Name = "data_fim_sprint";
            data_fim_sprint.Size = new Size(194, 31);
            data_fim_sprint.TabIndex = 11;
            data_fim_sprint.ValueChanged += data_fim_sprint_ValueChanged;
            // 
            // button_enviar_sprint_banco_dados
            // 
            button_enviar_sprint_banco_dados.Location = new Point(226, 374);
            button_enviar_sprint_banco_dados.Name = "button_enviar_sprint_banco_dados";
            button_enviar_sprint_banco_dados.Size = new Size(187, 34);
            button_enviar_sprint_banco_dados.TabIndex = 12;
            button_enviar_sprint_banco_dados.Text = "Enviar Sprint";
            button_enviar_sprint_banco_dados.UseVisualStyleBackColor = true;
            button_enviar_sprint_banco_dados.Click += button_enviar_sprint_banco_dados_Click;
            // 
            // button_pra_enviar_pro_form_6_nao_dados
            // 
            button_pra_enviar_pro_form_6_nao_dados.Location = new Point(419, 374);
            button_pra_enviar_pro_form_6_nao_dados.Name = "button_pra_enviar_pro_form_6_nao_dados";
            button_pra_enviar_pro_form_6_nao_dados.Size = new Size(187, 34);
            button_pra_enviar_pro_form_6_nao_dados.TabIndex = 13;
            button_pra_enviar_pro_form_6_nao_dados.Text = "Proximo";
            button_pra_enviar_pro_form_6_nao_dados.UseVisualStyleBackColor = true;
            button_pra_enviar_pro_form_6_nao_dados.Click += button_pra_enviar_pro_form_6_nao_dados_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button_pra_enviar_pro_form_6_nao_dados);
            Controls.Add(button_enviar_sprint_banco_dados);
            Controls.Add(data_fim_sprint);
            Controls.Add(data_iniciar_sprint);
            Controls.Add(status_sprint);
            Controls.Add(label5);
            Controls.Add(nome_sprint);
            Controls.Add(id_da_sprint_projeto);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(nome_sprint_label);
            Controls.Add(label_sprint);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_sprint;
        private Label nome_sprint_label;
        private Label label3;
        private Label label4;
        private TextBox id_da_sprint_projeto;
        private TextBox nome_sprint;
        private Label label5;
        private TextBox status_sprint;
        private DateTimePicker data_iniciar_sprint;
        private DateTimePicker data_fim_sprint;
        private Button button_enviar_sprint_banco_dados;
        private Button button_pra_enviar_pro_form_6_nao_dados;
    }
}