namespace Apresentacao.Buscas
{
    partial class F_BuscarCliente
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
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.btn_BuscarCPF = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_CPF
            // 
            this.txt_CPF.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CPF.Culture = new System.Globalization.CultureInfo("");
            this.txt_CPF.Font = new System.Drawing.Font("Source Sans Pro Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_CPF.Location = new System.Drawing.Point(92, 44);
            this.txt_CPF.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_CPF.Mask = "000.000.000-00";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(154, 27);
            this.txt_CPF.TabIndex = 0;
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CPF.Font = new System.Drawing.Font("Source Sans Pro Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_CPF.Location = new System.Drawing.Point(27, 46);
            this.lbl_CPF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(53, 24);
            this.lbl_CPF.TabIndex = 1;
            this.lbl_CPF.Text = "CPF: ";
            // 
            // btn_BuscarCPF
            // 
            this.btn_BuscarCPF.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BuscarCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarCPF.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_BuscarCPF.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarCPF.FlatAppearance.BorderSize = 2;
            this.btn_BuscarCPF.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarCPF.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarCPF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarCPF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarCPF.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarCPF.Location = new System.Drawing.Point(215, 102);
            this.btn_BuscarCPF.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_BuscarCPF.Name = "btn_BuscarCPF";
            this.btn_BuscarCPF.Size = new System.Drawing.Size(70, 40);
            this.btn_BuscarCPF.TabIndex = 2;
            this.btn_BuscarCPF.Text = "Buscar";
            this.btn_BuscarCPF.UseVisualStyleBackColor = false;
            this.btn_BuscarCPF.Click += new System.EventHandler(this.btn_BuscarCPF_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Fechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Fechar.FlatAppearance.BorderSize = 2;
            this.btn_Fechar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.Location = new System.Drawing.Point(12, 103);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(70, 40);
            this.btn_Fechar.TabIndex = 3;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_BuscarCliente
            // 
            this.AcceptButton = this.btn_BuscarCPF;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BuscarCPF);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.txt_CPF);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "F_BuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Button btn_BuscarCPF;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label label1;
    }
}