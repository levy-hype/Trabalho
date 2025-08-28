namespace WinFormsApp7
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ID_da_tarefa = new TextBox();
            Nome_tarefa = new TextBox();
            status_da_tarefa = new TextBox();
            descricao_da_tarefa = new TextBox();
            percentual_conclusao_da_tarefa = new TextBox();
            button_enviar_banco_de_dados = new Button();
            Enviar_proxima_tela_form7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(220, 80);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "ID Tarefa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(240, 125);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(213, 177);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(241, 226);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(122, 278);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 4;
            label5.Text = "Percentual Conclusão";
            // 
            // ID_da_tarefa
            // 
            ID_da_tarefa.Location = new Point(374, 77);
            ID_da_tarefa.Name = "ID_da_tarefa";
            ID_da_tarefa.Size = new Size(190, 31);
            ID_da_tarefa.TabIndex = 5;
            ID_da_tarefa.TextChanged += ID_da_tarefa_TextChanged;
            // 
            // Nome_tarefa
            // 
            Nome_tarefa.Location = new Point(374, 125);
            Nome_tarefa.Name = "Nome_tarefa";
            Nome_tarefa.Size = new Size(190, 31);
            Nome_tarefa.TabIndex = 6;
            Nome_tarefa.TextChanged += Nome_tarefa_TextChanged;
            // 
            // status_da_tarefa
            // 
            status_da_tarefa.Location = new Point(374, 226);
            status_da_tarefa.Name = "status_da_tarefa";
            status_da_tarefa.Size = new Size(190, 31);
            status_da_tarefa.TabIndex = 8;
            status_da_tarefa.TextChanged += status_da_tarefa_TextChanged;
            // 
            // descricao_da_tarefa
            // 
            descricao_da_tarefa.Location = new Point(374, 177);
            descricao_da_tarefa.Name = "descricao_da_tarefa";
            descricao_da_tarefa.Size = new Size(190, 31);
            descricao_da_tarefa.TabIndex = 7;
            descricao_da_tarefa.TextChanged += descricao_da_tarefa_TextChanged;
            // 
            // percentual_conclusao_da_tarefa
            // 
            percentual_conclusao_da_tarefa.Location = new Point(374, 272);
            percentual_conclusao_da_tarefa.Name = "percentual_conclusao_da_tarefa";
            percentual_conclusao_da_tarefa.Size = new Size(190, 31);
            percentual_conclusao_da_tarefa.TabIndex = 9;
            percentual_conclusao_da_tarefa.TextChanged += percentual_conclusao_da_tarefa_TextChanged;
            // 
            // button_enviar_banco_de_dados
            // 
            button_enviar_banco_de_dados.Location = new Point(190, 370);
            button_enviar_banco_de_dados.Name = "button_enviar_banco_de_dados";
            button_enviar_banco_de_dados.Size = new Size(195, 42);
            button_enviar_banco_de_dados.TabIndex = 10;
            button_enviar_banco_de_dados.Text = "Finalizar Tarefa";
            button_enviar_banco_de_dados.UseVisualStyleBackColor = true;
            button_enviar_banco_de_dados.Click += button_enviar_banco_de_dados_Click;
            // 
            // Enviar_proxima_tela_form7
            // 
            Enviar_proxima_tela_form7.Location = new Point(455, 370);
            Enviar_proxima_tela_form7.Name = "Enviar_proxima_tela_form7";
            Enviar_proxima_tela_form7.Size = new Size(195, 42);
            Enviar_proxima_tela_form7.TabIndex = 11;
            Enviar_proxima_tela_form7.Text = "Proxima Tela";
            Enviar_proxima_tela_form7.UseVisualStyleBackColor = true;
            Enviar_proxima_tela_form7.Click += Enviar_proxima_tela_form7_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(855, 468);
            Controls.Add(Enviar_proxima_tela_form7);
            Controls.Add(button_enviar_banco_de_dados);
            Controls.Add(percentual_conclusao_da_tarefa);
            Controls.Add(status_da_tarefa);
            Controls.Add(descricao_da_tarefa);
            Controls.Add(Nome_tarefa);
            Controls.Add(ID_da_tarefa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ID_da_tarefa;
        private TextBox Nome_tarefa;
        private TextBox status_da_tarefa;
        private TextBox descricao_da_tarefa;
        private TextBox percentual_conclusao_da_tarefa;
        private Button button_enviar_banco_de_dados;
        private Button Enviar_proxima_tela_form7;
    }
}