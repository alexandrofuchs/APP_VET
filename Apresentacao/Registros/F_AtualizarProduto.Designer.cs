namespace Apresentacao.Registros
{
    partial class F_AtualizarProduto
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
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Sigla = new System.Windows.Forms.TextBox();
            this.txt_Custo = new System.Windows.Forms.TextBox();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atualizar Produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Atualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Atualizar.FlatAppearance.BorderSize = 2;
            this.btn_Atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Atualizar.Location = new System.Drawing.Point(238, 298);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(100, 40);
            this.btn_Atualizar.TabIndex = 5;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Fechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Fechar.FlatAppearance.BorderSize = 2;
            this.btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.Location = new System.Drawing.Point(12, 298);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(100, 40);
            this.btn_Fechar.TabIndex = 6;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 61);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(71, 22);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sigla: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Custo(R$): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição : ";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(129, 54);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(209, 29);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Sigla
            // 
            this.txt_Sigla.Location = new System.Drawing.Point(238, 89);
            this.txt_Sigla.MaxLength = 5;
            this.txt_Sigla.Name = "txt_Sigla";
            this.txt_Sigla.Size = new System.Drawing.Size(100, 29);
            this.txt_Sigla.TabIndex = 2;
            // 
            // txt_Custo
            // 
            this.txt_Custo.Location = new System.Drawing.Point(238, 124);
            this.txt_Custo.MaxLength = 20;
            this.txt_Custo.Name = "txt_Custo";
            this.txt_Custo.Size = new System.Drawing.Size(100, 29);
            this.txt_Custo.TabIndex = 3;
            this.txt_Custo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(129, 159);
            this.txt_Descricao.MaxLength = 500;
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(209, 104);
            this.txt_Descricao.TabIndex = 4;
            // 
            // F_AtualizarProduto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.txt_Custo);
            this.Controls.Add(this.txt_Sigla);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "F_AtualizarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_AtualizarProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Sigla;
        private System.Windows.Forms.TextBox txt_Custo;
        private System.Windows.Forms.TextBox txt_Descricao;
    }
}