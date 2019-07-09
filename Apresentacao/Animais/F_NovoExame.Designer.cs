namespace Apresentacao.Animais
{
    partial class F_NovoExame
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
            this.cmb_Exame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Laudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DataColeta = new System.Windows.Forms.MaskedTextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_DataResultado = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Laboratorio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Proprietario = new System.Windows.Forms.TextBox();
            this.txt_Animal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_Exame
            // 
            this.cmb_Exame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Exame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Exame.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Exame.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmb_Exame.FormattingEnabled = true;
            this.cmb_Exame.Location = new System.Drawing.Point(260, 125);
            this.cmb_Exame.Name = "cmb_Exame";
            this.cmb_Exame.Size = new System.Drawing.Size(260, 40);
            this.cmb_Exame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exame: ";
            // 
            // txt_Laudo
            // 
            this.txt_Laudo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Laudo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Laudo.Location = new System.Drawing.Point(12, 338);
            this.txt_Laudo.Multiline = true;
            this.txt_Laudo.Name = "txt_Laudo";
            this.txt_Laudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Laudo.Size = new System.Drawing.Size(776, 61);
            this.txt_Laudo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Láudo Médico: ";
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Resultado.Location = new System.Drawing.Point(12, 427);
            this.txt_Resultado.Multiline = true;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Resultado.Size = new System.Drawing.Size(776, 65);
            this.txt_Resultado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data do Resultado: ";
            // 
            // txt_DataColeta
            // 
            this.txt_DataColeta.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataColeta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_DataColeta.Location = new System.Drawing.Point(260, 171);
            this.txt_DataColeta.Mask = "00/00/0000";
            this.txt_DataColeta.Name = "txt_DataColeta";
            this.txt_DataColeta.Size = new System.Drawing.Size(159, 39);
            this.txt_DataColeta.TabIndex = 7;
            this.txt_DataColeta.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Registrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Registrar.FlatAppearance.BorderSize = 2;
            this.btn_Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Registrar.Location = new System.Drawing.Point(638, 548);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(150, 40);
            this.btn_Registrar.TabIndex = 8;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(800, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Registrar Exame";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data da Coleta do Material: ";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancelar.FlatAppearance.BorderSize = 2;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 548);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(150, 40);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_DataResultado
            // 
            this.txt_DataResultado.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataResultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_DataResultado.Location = new System.Drawing.Point(260, 216);
            this.txt_DataResultado.Mask = "00/00/0000";
            this.txt_DataResultado.Name = "txt_DataResultado";
            this.txt_DataResultado.Size = new System.Drawing.Size(159, 39);
            this.txt_DataResultado.TabIndex = 12;
            this.txt_DataResultado.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Laboratório: ";
            // 
            // txt_Laboratorio
            // 
            this.txt_Laboratorio.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Laboratorio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Laboratorio.Location = new System.Drawing.Point(260, 261);
            this.txt_Laboratorio.Name = "txt_Laboratorio";
            this.txt_Laboratorio.Size = new System.Drawing.Size(260, 39);
            this.txt_Laboratorio.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Animal: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Proprietário: ";
            // 
            // txt_Proprietario
            // 
            this.txt_Proprietario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Proprietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Proprietario.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Proprietario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Proprietario.Location = new System.Drawing.Point(260, 87);
            this.txt_Proprietario.Name = "txt_Proprietario";
            this.txt_Proprietario.ReadOnly = true;
            this.txt_Proprietario.Size = new System.Drawing.Size(260, 32);
            this.txt_Proprietario.TabIndex = 17;
            // 
            // txt_Animal
            // 
            this.txt_Animal.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Animal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Animal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Animal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Animal.Location = new System.Drawing.Point(260, 49);
            this.txt_Animal.Name = "txt_Animal";
            this.txt_Animal.ReadOnly = true;
            this.txt_Animal.Size = new System.Drawing.Size(260, 32);
            this.txt_Animal.TabIndex = 18;
            // 
            // F_NovoExame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txt_Animal);
            this.Controls.Add(this.txt_Proprietario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Laboratorio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_DataResultado);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txt_DataColeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Laudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Exame);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "F_NovoExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_NovoExame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Exame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Laudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_DataColeta;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox txt_DataResultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Laboratorio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Proprietario;
        private System.Windows.Forms.TextBox txt_Animal;
    }
}