namespace WinFormsApp7
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            status = new TextBox();
            digitar_horas = new TextBox();
            tex_contrato = new TextBox();
            status_contrato = new Label();
            valor_hora = new Label();
            data_fim = new Label();
            data_iniciar = new Label();
            button_contratar = new Button();
            ID_contrato = new Label();
            escolher_data_inciar = new DateTimePicker();
            escolher_data_fim = new DateTimePicker();
            button_projeto_form4 = new Button();
            SuspendLayout();
            // 
            // status
            // 
            status.Location = new Point(333, 323);
            status.Margin = new Padding(4, 5, 4, 5);
            status.Name = "status";
            status.Size = new Size(300, 31);
            status.TabIndex = 30;
            status.TextChanged += status_TextChanged;
            // 
            // digitar_horas
            // 
            digitar_horas.Location = new Point(333, 265);
            digitar_horas.Margin = new Padding(4, 5, 4, 5);
            digitar_horas.Name = "digitar_horas";
            digitar_horas.Size = new Size(300, 31);
            digitar_horas.TabIndex = 29;
            digitar_horas.TextChanged += digitar_horas_TextChanged;
            // 
            // tex_contrato
            // 
            tex_contrato.Location = new Point(333, 106);
            tex_contrato.Margin = new Padding(4, 5, 4, 5);
            tex_contrato.Name = "tex_contrato";
            tex_contrato.Size = new Size(300, 31);
            tex_contrato.TabIndex = 26;
            tex_contrato.TextChanged += tex_contrato_TextChanged;
            // 
            // status_contrato
            // 
            status_contrato.AutoSize = true;
            status_contrato.BackColor = SystemColors.ActiveCaptionText;
            status_contrato.ForeColor = SystemColors.ButtonHighlight;
            status_contrato.Location = new Point(265, 323);
            status_contrato.Margin = new Padding(4, 0, 4, 0);
            status_contrato.Name = "status_contrato";
            status_contrato.Size = new Size(60, 25);
            status_contrato.TabIndex = 25;
            status_contrato.Text = "Status";
            status_contrato.Click += status_contrato_Click;
            // 
            // valor_hora
            // 
            valor_hora.AutoSize = true;
            valor_hora.BackColor = SystemColors.ActiveCaptionText;
            valor_hora.ForeColor = SystemColors.ButtonHighlight;
            valor_hora.Location = new Point(228, 269);
            valor_hora.Margin = new Padding(4, 0, 4, 0);
            valor_hora.Name = "valor_hora";
            valor_hora.Size = new Size(96, 25);
            valor_hora.TabIndex = 23;
            valor_hora.Text = "Valor Hora";
            valor_hora.Click += valor_hora_Click;
            // 
            // data_fim
            // 
            data_fim.AutoSize = true;
            data_fim.BackColor = SystemColors.ActiveCaptionText;
            data_fim.ForeColor = SystemColors.ButtonHighlight;
            data_fim.Location = new Point(241, 218);
            data_fim.Margin = new Padding(4, 0, 4, 0);
            data_fim.Name = "data_fim";
            data_fim.Size = new Size(83, 25);
            data_fim.TabIndex = 22;
            data_fim.Text = "Data Fim";
            data_fim.Click += data_fim_Click;
            // 
            // data_iniciar
            // 
            data_iniciar.AutoSize = true;
            data_iniciar.BackColor = SystemColors.ActiveCaptionText;
            data_iniciar.ForeColor = SystemColors.ButtonHighlight;
            data_iniciar.Location = new Point(228, 164);
            data_iniciar.Margin = new Padding(4, 0, 4, 0);
            data_iniciar.Name = "data_iniciar";
            data_iniciar.Size = new Size(96, 25);
            data_iniciar.TabIndex = 21;
            data_iniciar.Text = "Data Inicio";
            data_iniciar.Click += label3_Click;
            // 
            // button_contratar
            // 
            button_contratar.Location = new Point(119, 405);
            button_contratar.Margin = new Padding(4, 5, 4, 5);
            button_contratar.Name = "button_contratar";
            button_contratar.Size = new Size(311, 48);
            button_contratar.TabIndex = 34;
            button_contratar.Text = "Gerar Projeto";
            button_contratar.UseVisualStyleBackColor = true;
            button_contratar.Click += button_contratar_Click;
            // 
            // ID_contrato
            // 
            ID_contrato.AutoSize = true;
            ID_contrato.BackColor = SystemColors.ActiveCaptionText;
            ID_contrato.ForeColor = SystemColors.ButtonHighlight;
            ID_contrato.Location = new Point(241, 106);
            ID_contrato.Margin = new Padding(4, 0, 4, 0);
            ID_contrato.Name = "ID_contrato";
            ID_contrato.Size = new Size(82, 25);
            ID_contrato.TabIndex = 35;
            ID_contrato.Text = "Contrato";
            ID_contrato.Click += ID_contrato_Click;
            // 
            // escolher_data_inciar
            // 
            escolher_data_inciar.Location = new Point(333, 164);
            escolher_data_inciar.Name = "escolher_data_inciar";
            escolher_data_inciar.Size = new Size(300, 31);
            escolher_data_inciar.TabIndex = 36;
            escolher_data_inciar.ValueChanged += escolher_data_inciar_ValueChanged;
            // 
            // escolher_data_fim
            // 
            escolher_data_fim.Location = new Point(333, 218);
            escolher_data_fim.Name = "escolher_data_fim";
            escolher_data_fim.Size = new Size(300, 31);
            escolher_data_fim.TabIndex = 37;
            escolher_data_fim.ValueChanged += escolher_data_fim_ValueChanged;
            // 
            // button_projeto_form4
            // 
            button_projeto_form4.Location = new Point(489, 405);
            button_projeto_form4.Name = "button_projeto_form4";
            button_projeto_form4.Size = new Size(311, 48);
            button_projeto_form4.TabIndex = 38;
            button_projeto_form4.Text = "Ir Projeto";
            button_projeto_form4.UseVisualStyleBackColor = true;
            button_projeto_form4.Click += button_projeto_form4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(872, 522);
            Controls.Add(button_projeto_form4);
            Controls.Add(escolher_data_fim);
            Controls.Add(escolher_data_inciar);
            Controls.Add(ID_contrato);
            Controls.Add(button_contratar);
            Controls.Add(status);
            Controls.Add(digitar_horas);
            Controls.Add(tex_contrato);
            Controls.Add(status_contrato);
            Controls.Add(valor_hora);
            Controls.Add(data_fim);
            Controls.Add(data_iniciar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox status;
        private TextBox digitar_horas;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox tex_contrato;
        private Label status_contrato;
        private Label valor_hora;
        private Label data_fim;
        private Label data_iniciar;
        private Button button_contratar;
        private Label ID_contrato;
        private DateTimePicker escolher_data_inciar;
        private DateTimePicker escolher_data_fim;
        private Button button_projeto_form4;
    }
}