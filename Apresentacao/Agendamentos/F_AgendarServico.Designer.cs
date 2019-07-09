namespace Apresentacao.Agendamentos
{
    partial class F_AgendarServico
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
            this.lbl_Observacoes = new System.Windows.Forms.Label();
            this.txt_Observacoes = new System.Windows.Forms.TextBox();
            this.txt_NomeVeterinario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar_Consultas = new System.Windows.Forms.MonthCalendar();
            this.lbl_Proprietario = new System.Windows.Forms.Label();
            this.txt_Proprietario = new System.Windows.Forms.TextBox();
            this.btn_BuscarVeterinario = new System.Windows.Forms.Button();
            this.txt_NomeAnimal = new System.Windows.Forms.TextBox();
            this.btn_AgendarConsulta = new System.Windows.Forms.Button();
            this.lbl_Veterinario = new System.Windows.Forms.Label();
            this.txt_HoraConsulta = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_DataAgendamento = new System.Windows.Forms.Label();
            this.txt_DataConsulta = new System.Windows.Forms.MaskedTextBox();
            this.btn_BuscarAnimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Servico = new System.Windows.Forms.Label();
            this.txt_DescricaoAgendamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Observacoes
            // 
            this.lbl_Observacoes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Observacoes.Location = new System.Drawing.Point(736, 229);
            this.lbl_Observacoes.Name = "lbl_Observacoes";
            this.lbl_Observacoes.Size = new System.Drawing.Size(144, 37);
            this.lbl_Observacoes.TabIndex = 25;
            this.lbl_Observacoes.Text = "Observações";
            // 
            // txt_Observacoes
            // 
            this.txt_Observacoes.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Observacoes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Observacoes.Location = new System.Drawing.Point(484, 270);
            this.txt_Observacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Observacoes.MaxLength = 1000;
            this.txt_Observacoes.Multiline = true;
            this.txt_Observacoes.Name = "txt_Observacoes";
            this.txt_Observacoes.Size = new System.Drawing.Size(396, 157);
            this.txt_Observacoes.TabIndex = 24;
            // 
            // txt_NomeVeterinario
            // 
            this.txt_NomeVeterinario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NomeVeterinario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_NomeVeterinario.Location = new System.Drawing.Point(23, 392);
            this.txt_NomeVeterinario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NomeVeterinario.Name = "txt_NomeVeterinario";
            this.txt_NomeVeterinario.ReadOnly = true;
            this.txt_NomeVeterinario.Size = new System.Drawing.Size(322, 29);
            this.txt_NomeVeterinario.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(563, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "(dia/mês/ano)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(584, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "(Hrs:Min.)";
            // 
            // monthCalendar_Consultas
            // 
            this.monthCalendar_Consultas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar_Consultas.Location = new System.Drawing.Point(653, 55);
            this.monthCalendar_Consultas.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.monthCalendar_Consultas.MaxSelectionCount = 1;
            this.monthCalendar_Consultas.Name = "monthCalendar_Consultas";
            this.monthCalendar_Consultas.TabIndex = 19;
            this.monthCalendar_Consultas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_Consultas_DateChanged);
            // 
            // lbl_Proprietario
            // 
            this.lbl_Proprietario.AutoSize = true;
            this.lbl_Proprietario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Proprietario.Location = new System.Drawing.Point(18, 292);
            this.lbl_Proprietario.Name = "lbl_Proprietario";
            this.lbl_Proprietario.Size = new System.Drawing.Size(113, 22);
            this.lbl_Proprietario.TabIndex = 17;
            this.lbl_Proprietario.Text = "Proprietário:";
            // 
            // txt_Proprietario
            // 
            this.txt_Proprietario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Proprietario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Proprietario.Location = new System.Drawing.Point(23, 323);
            this.txt_Proprietario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Proprietario.Name = "txt_Proprietario";
            this.txt_Proprietario.ReadOnly = true;
            this.txt_Proprietario.Size = new System.Drawing.Size(321, 29);
            this.txt_Proprietario.TabIndex = 16;
            // 
            // btn_BuscarVeterinario
            // 
            this.btn_BuscarVeterinario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BuscarVeterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarVeterinario.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarVeterinario.FlatAppearance.BorderSize = 2;
            this.btn_BuscarVeterinario.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarVeterinario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarVeterinario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarVeterinario.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarVeterinario.Location = new System.Drawing.Point(351, 388);
            this.btn_BuscarVeterinario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BuscarVeterinario.Name = "btn_BuscarVeterinario";
            this.btn_BuscarVeterinario.Size = new System.Drawing.Size(100, 34);
            this.btn_BuscarVeterinario.TabIndex = 14;
            this.btn_BuscarVeterinario.Text = "Buscar";
            this.btn_BuscarVeterinario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_BuscarVeterinario.UseVisualStyleBackColor = false;
            this.btn_BuscarVeterinario.Click += new System.EventHandler(this.btn_BuscarVeterinario_Click);
            // 
            // txt_NomeAnimal
            // 
            this.txt_NomeAnimal.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NomeAnimal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_NomeAnimal.Location = new System.Drawing.Point(23, 254);
            this.txt_NomeAnimal.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txt_NomeAnimal.Name = "txt_NomeAnimal";
            this.txt_NomeAnimal.ReadOnly = true;
            this.txt_NomeAnimal.Size = new System.Drawing.Size(321, 29);
            this.txt_NomeAnimal.TabIndex = 0;
            // 
            // btn_AgendarConsulta
            // 
            this.btn_AgendarConsulta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AgendarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgendarConsulta.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_AgendarConsulta.FlatAppearance.BorderSize = 2;
            this.btn_AgendarConsulta.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_AgendarConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_AgendarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_AgendarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgendarConsulta.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_AgendarConsulta.Location = new System.Drawing.Point(730, 448);
            this.btn_AgendarConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AgendarConsulta.Name = "btn_AgendarConsulta";
            this.btn_AgendarConsulta.Size = new System.Drawing.Size(150, 39);
            this.btn_AgendarConsulta.TabIndex = 9;
            this.btn_AgendarConsulta.Text = "Confirmar";
            this.btn_AgendarConsulta.UseVisualStyleBackColor = false;
            this.btn_AgendarConsulta.Click += new System.EventHandler(this.Btn_AgendarConsulta_Click);
            // 
            // lbl_Veterinario
            // 
            this.lbl_Veterinario.AutoSize = true;
            this.lbl_Veterinario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Veterinario.Location = new System.Drawing.Point(18, 361);
            this.lbl_Veterinario.Name = "lbl_Veterinario";
            this.lbl_Veterinario.Size = new System.Drawing.Size(100, 22);
            this.lbl_Veterinario.TabIndex = 7;
            this.lbl_Veterinario.Text = "Veterinário";
            // 
            // txt_HoraConsulta
            // 
            this.txt_HoraConsulta.BackColor = System.Drawing.SystemColors.Window;
            this.txt_HoraConsulta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_HoraConsulta.Location = new System.Drawing.Point(566, 165);
            this.txt_HoraConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoraConsulta.Mask = "00:00";
            this.txt_HoraConsulta.Name = "txt_HoraConsulta";
            this.txt_HoraConsulta.Size = new System.Drawing.Size(73, 29);
            this.txt_HoraConsulta.TabIndex = 6;
            this.txt_HoraConsulta.ValidatingType = typeof(System.DateTime);
            this.txt_HoraConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HoraConsulta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(558, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horário:";
            // 
            // lbl_DataAgendamento
            // 
            this.lbl_DataAgendamento.AutoSize = true;
            this.lbl_DataAgendamento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_DataAgendamento.Location = new System.Drawing.Point(582, 55);
            this.lbl_DataAgendamento.Name = "lbl_DataAgendamento";
            this.lbl_DataAgendamento.Size = new System.Drawing.Size(54, 22);
            this.lbl_DataAgendamento.TabIndex = 4;
            this.lbl_DataAgendamento.Text = "Data:";
            // 
            // txt_DataConsulta
            // 
            this.txt_DataConsulta.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DataConsulta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_DataConsulta.Location = new System.Drawing.Point(484, 87);
            this.txt_DataConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DataConsulta.Mask = "00/00/0000";
            this.txt_DataConsulta.Name = "txt_DataConsulta";
            this.txt_DataConsulta.Size = new System.Drawing.Size(155, 29);
            this.txt_DataConsulta.TabIndex = 3;
            this.txt_DataConsulta.ValidatingType = typeof(System.DateTime);
            this.txt_DataConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DataConsulta_KeyPress);
            // 
            // btn_BuscarAnimal
            // 
            this.btn_BuscarAnimal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BuscarAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarAnimal.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarAnimal.FlatAppearance.BorderSize = 2;
            this.btn_BuscarAnimal.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarAnimal.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarAnimal.Location = new System.Drawing.Point(351, 251);
            this.btn_BuscarAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BuscarAnimal.Name = "btn_BuscarAnimal";
            this.btn_BuscarAnimal.Size = new System.Drawing.Size(100, 34);
            this.btn_BuscarAnimal.TabIndex = 2;
            this.btn_BuscarAnimal.Text = "Buscar";
            this.btn_BuscarAnimal.UseVisualStyleBackColor = false;
            this.btn_BuscarAnimal.Click += new System.EventHandler(this.Btn_BuscarAnimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(18, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animal: ";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancelar.FlatAppearance.BorderSize = 2;
            this.btn_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Cancelar.Location = new System.Drawing.Point(23, 448);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(150, 40);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Servico
            // 
            this.lbl_Servico.AutoSize = true;
            this.lbl_Servico.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Servico.Location = new System.Drawing.Point(19, 55);
            this.lbl_Servico.Name = "lbl_Servico";
            this.lbl_Servico.Size = new System.Drawing.Size(246, 22);
            this.lbl_Servico.TabIndex = 28;
            this.lbl_Servico.Text = "Descrição do Agendamento";
            // 
            // txt_DescricaoAgendamento
            // 
            this.txt_DescricaoAgendamento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_DescricaoAgendamento.Location = new System.Drawing.Point(23, 85);
            this.txt_DescricaoAgendamento.Multiline = true;
            this.txt_DescricaoAgendamento.Name = "txt_DescricaoAgendamento";
            this.txt_DescricaoAgendamento.Size = new System.Drawing.Size(455, 131);
            this.txt_DescricaoAgendamento.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(900, 40);
            this.label4.TabIndex = 30;
            this.label4.Text = "Agendar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_AgendarServico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DescricaoAgendamento);
            this.Controls.Add(this.lbl_Servico);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Observacoes);
            this.Controls.Add(this.txt_Observacoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NomeVeterinario);
            this.Controls.Add(this.btn_BuscarAnimal);
            this.Controls.Add(this.txt_DataConsulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_DataAgendamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar_Consultas);
            this.Controls.Add(this.txt_HoraConsulta);
            this.Controls.Add(this.lbl_Veterinario);
            this.Controls.Add(this.lbl_Proprietario);
            this.Controls.Add(this.btn_AgendarConsulta);
            this.Controls.Add(this.txt_Proprietario);
            this.Controls.Add(this.txt_NomeAnimal);
            this.Controls.Add(this.btn_BuscarVeterinario);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "F_AgendarServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar_Consultas;
        private System.Windows.Forms.Label lbl_Proprietario;
        private System.Windows.Forms.TextBox txt_Proprietario;
        private System.Windows.Forms.Button btn_BuscarVeterinario;
        private System.Windows.Forms.TextBox txt_NomeAnimal;
        private System.Windows.Forms.Button btn_AgendarConsulta;
        private System.Windows.Forms.Label lbl_Veterinario;
        private System.Windows.Forms.MaskedTextBox txt_HoraConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_DataAgendamento;
        private System.Windows.Forms.MaskedTextBox txt_DataConsulta;
        private System.Windows.Forms.Button btn_BuscarAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeVeterinario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Observacoes;
        private System.Windows.Forms.TextBox txt_Observacoes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Servico;
        private System.Windows.Forms.TextBox txt_DescricaoAgendamento;
        private System.Windows.Forms.Label label4;
    }
}