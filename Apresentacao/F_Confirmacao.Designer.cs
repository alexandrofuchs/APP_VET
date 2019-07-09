namespace Apresentacao
{
    partial class F_Confirmacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Nao = new System.Windows.Forms.Button();
            this.btn_Sim = new System.Windows.Forms.Button();
            this.lbl_Mensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmar Ação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Nao
            // 
            this.btn_Nao.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Nao.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Nao.FlatAppearance.BorderSize = 2;
            this.btn_Nao.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_Nao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Nao.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Nao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nao.Location = new System.Drawing.Point(212, 209);
            this.btn_Nao.Name = "btn_Nao";
            this.btn_Nao.Size = new System.Drawing.Size(60, 40);
            this.btn_Nao.TabIndex = 1;
            this.btn_Nao.Text = "Não";
            this.btn_Nao.UseVisualStyleBackColor = false;
            this.btn_Nao.Click += new System.EventHandler(this.btn_Nao_Click);
            // 
            // btn_Sim
            // 
            this.btn_Sim.BackColor = System.Drawing.Color.Green;
            this.btn_Sim.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Sim.FlatAppearance.BorderSize = 2;
            this.btn_Sim.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_Sim.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Sim.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sim.Location = new System.Drawing.Point(12, 209);
            this.btn_Sim.Name = "btn_Sim";
            this.btn_Sim.Size = new System.Drawing.Size(60, 40);
            this.btn_Sim.TabIndex = 2;
            this.btn_Sim.Text = "Sim";
            this.btn_Sim.UseVisualStyleBackColor = false;
            this.btn_Sim.Click += new System.EventHandler(this.btn_Sim_Click);
            // 
            // lbl_Mensagem
            // 
            this.lbl_Mensagem.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Mensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Mensagem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Mensagem.Location = new System.Drawing.Point(12, 43);
            this.lbl_Mensagem.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Mensagem.Name = "lbl_Mensagem";
            this.lbl_Mensagem.Size = new System.Drawing.Size(260, 160);
            this.lbl_Mensagem.TabIndex = 3;
            this.lbl_Mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Confirmacao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_Mensagem);
            this.Controls.Add(this.btn_Sim);
            this.Controls.Add(this.btn_Nao);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Confirmacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Confirmacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Nao;
        private System.Windows.Forms.Button btn_Sim;
        private System.Windows.Forms.Label lbl_Mensagem;
    }
}