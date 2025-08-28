namespace WinFormsApp7
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label_fatura = new Label();
            label_Periodo = new Label();
            label_Valor_Totalizado = new Label();
            label_Status = new Label();
            ID_fatura = new TextBox();
            valor_final_projeto = new TextBox();
            periodo = new TextBox();
            status_finalizado = new TextBox();
            button_de_gerar_fatura_projeto = new Button();
            button_voltar_pro_2 = new Button();
            SuspendLayout();
            // 
            // label_fatura
            // 
            label_fatura.AutoSize = true;
            label_fatura.BackColor = SystemColors.ActiveCaptionText;
            label_fatura.ForeColor = SystemColors.ButtonFace;
            label_fatura.Location = new Point(271, 131);
            label_fatura.Name = "label_fatura";
            label_fatura.Size = new Size(60, 25);
            label_fatura.TabIndex = 0;
            label_fatura.Text = "Fatura";
            // 
            // label_Periodo
            // 
            label_Periodo.AutoSize = true;
            label_Periodo.BackColor = SystemColors.ActiveCaptionText;
            label_Periodo.ForeColor = SystemColors.ButtonFace;
            label_Periodo.Location = new Point(271, 188);
            label_Periodo.Name = "label_Periodo";
            label_Periodo.Size = new Size(73, 25);
            label_Periodo.TabIndex = 1;
            label_Periodo.Text = "Periodo";
            // 
            // label_Valor_Totalizado
            // 
            label_Valor_Totalizado.AutoSize = true;
            label_Valor_Totalizado.BackColor = SystemColors.ActiveCaptionText;
            label_Valor_Totalizado.ForeColor = SystemColors.ButtonFace;
            label_Valor_Totalizado.Location = new Point(271, 249);
            label_Valor_Totalizado.Name = "label_Valor_Totalizado";
            label_Valor_Totalizado.Size = new Size(94, 25);
            label_Valor_Totalizado.TabIndex = 2;
            label_Valor_Totalizado.Text = "Valor Total";
            // 
            // label_Status
            // 
            label_Status.AutoSize = true;
            label_Status.BackColor = SystemColors.ActiveCaptionText;
            label_Status.ForeColor = SystemColors.ButtonFace;
            label_Status.Location = new Point(271, 304);
            label_Status.Name = "label_Status";
            label_Status.Size = new Size(60, 25);
            label_Status.TabIndex = 3;
            label_Status.Text = "Status";
            // 
            // ID_fatura
            // 
            ID_fatura.Location = new Point(400, 131);
            ID_fatura.Name = "ID_fatura";
            ID_fatura.Size = new Size(163, 31);
            ID_fatura.TabIndex = 4;
            ID_fatura.TextChanged += ID_fatura_TextChanged;
            // 
            // valor_final_projeto
            // 
            valor_final_projeto.Location = new Point(400, 249);
            valor_final_projeto.Name = "valor_final_projeto";
            valor_final_projeto.Size = new Size(163, 31);
            valor_final_projeto.TabIndex = 5;
            valor_final_projeto.TextChanged += valor_final_projeto_TextChanged;
            // 
            // periodo
            // 
            periodo.Location = new Point(400, 188);
            periodo.Name = "periodo";
            periodo.Size = new Size(163, 31);
            periodo.TabIndex = 6;
            periodo.TextChanged += periodo_TextChanged;
            // 
            // status_finalizado
            // 
            status_finalizado.Location = new Point(400, 304);
            status_finalizado.Name = "status_finalizado";
            status_finalizado.Size = new Size(163, 31);
            status_finalizado.TabIndex = 7;
            status_finalizado.TextChanged += status_finalizado_TextChanged;
            // 
            // button_de_gerar_fatura_projeto
            // 
            button_de_gerar_fatura_projeto.Location = new Point(155, 405);
            button_de_gerar_fatura_projeto.Name = "button_de_gerar_fatura_projeto";
            button_de_gerar_fatura_projeto.Size = new Size(292, 34);
            button_de_gerar_fatura_projeto.TabIndex = 8;
            button_de_gerar_fatura_projeto.Text = "Gerar Fatura";
            button_de_gerar_fatura_projeto.UseVisualStyleBackColor = true;
            button_de_gerar_fatura_projeto.Click += button_de_gerar_fatura_projeto_Click;
            // 
            // button_voltar_pro_2
            // 
            button_voltar_pro_2.Location = new Point(462, 405);
            button_voltar_pro_2.Name = "button_voltar_pro_2";
            button_voltar_pro_2.Size = new Size(292, 34);
            button_voltar_pro_2.TabIndex = 9;
            button_voltar_pro_2.Text = "Voltar";
            button_voltar_pro_2.UseVisualStyleBackColor = true;
            button_voltar_pro_2.Click += button_voltar_pro_2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(841, 495);
            Controls.Add(button_voltar_pro_2);
            Controls.Add(button_de_gerar_fatura_projeto);
            Controls.Add(status_finalizado);
            Controls.Add(periodo);
            Controls.Add(valor_final_projeto);
            Controls.Add(ID_fatura);
            Controls.Add(label_Status);
            Controls.Add(label_Valor_Totalizado);
            Controls.Add(label_Periodo);
            Controls.Add(label_fatura);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_fatura;
        private Label label_Periodo;
        private Label label_Valor_Totalizado;
        private Label label_Status;
        private TextBox ID_fatura;
        private TextBox valor_final_projeto;
        private TextBox periodo;
        private TextBox status_finalizado;
        private Button button_de_gerar_fatura_projeto;
        private Button button_voltar_pro_2;
    }
}