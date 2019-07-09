namespace Apresentacao.Clientes
{
    partial class F_DadosCliente
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
            this.txt_NumeroResidencia = new System.Windows.Forms.TextBox();
            this.lbl_NumeroResidencia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_RG = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_RG = new System.Windows.Forms.Label();
            this.lbl_DataNascimento = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.btn_AtualizarDados = new System.Windows.Forms.Button();
            this.btn_RestaurarDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_NumeroResidencia
            // 
            this.txt_NumeroResidencia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_NumeroResidencia.Location = new System.Drawing.Point(665, 56);
            this.txt_NumeroResidencia.Margin = new System.Windows.Forms.Padding(5);
            this.txt_NumeroResidencia.Name = "txt_NumeroResidencia";
            this.txt_NumeroResidencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NumeroResidencia.Size = new System.Drawing.Size(155, 32);
            this.txt_NumeroResidencia.TabIndex = 82;
            this.txt_NumeroResidencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // lbl_NumeroResidencia
            // 
            this.lbl_NumeroResidencia.AutoSize = true;
            this.lbl_NumeroResidencia.Location = new System.Drawing.Point(512, 67);
            this.lbl_NumeroResidencia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NumeroResidencia.Name = "lbl_NumeroResidencia";
            this.lbl_NumeroResidencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_NumeroResidencia.Size = new System.Drawing.Size(143, 24);
            this.lbl_NumeroResidencia.TabIndex = 81;
            this.lbl_NumeroResidencia.Text = "Nº Residência";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 80;
            this.label3.Text = "(dia/mês/ano)";
            // 
            // txt_Estado
            // 
            this.txt_Estado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Estado.Location = new System.Drawing.Point(665, 182);
            this.txt_Estado.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Estado.Size = new System.Drawing.Size(246, 32);
            this.txt_Estado.TabIndex = 79;
            // 
            // txt_DataNascimento
            // 
            this.txt_DataNascimento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_DataNascimento.Location = new System.Drawing.Point(224, 143);
            this.txt_DataNascimento.Margin = new System.Windows.Forms.Padding(5);
            this.txt_DataNascimento.Mask = "00/00/0000";
            this.txt_DataNascimento.Name = "txt_DataNascimento";
            this.txt_DataNascimento.Size = new System.Drawing.Size(164, 32);
            this.txt_DataNascimento.TabIndex = 78;
            this.txt_DataNascimento.ValidatingType = typeof(System.DateTime);
            this.txt_DataNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Bairro.Location = new System.Drawing.Point(665, 98);
            this.txt_Bairro.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Bairro.Size = new System.Drawing.Size(246, 32);
            this.txt_Bairro.TabIndex = 77;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Endereco.Location = new System.Drawing.Point(665, 14);
            this.txt_Endereco.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Endereco.Size = new System.Drawing.Size(246, 32);
            this.txt_Endereco.TabIndex = 76;
            // 
            // txt_Nome
            // 
            this.txt_Nome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Nome.Location = new System.Drawing.Point(224, 17);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Nome.Size = new System.Drawing.Size(278, 32);
            this.txt_Nome.TabIndex = 73;
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Location = new System.Drawing.Point(512, 109);
            this.lbl_Bairro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Bairro.Size = new System.Drawing.Size(67, 24);
            this.lbl_Bairro.TabIndex = 75;
            this.lbl_Bairro.Text = "Bairro";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Location = new System.Drawing.Point(512, 25);
            this.lbl_Endereco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Endereco.Size = new System.Drawing.Size(100, 24);
            this.lbl_Endereco.TabIndex = 74;
            this.lbl_Endereco.Text = "Endereco";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(14, 22);
            this.lbl_Nome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Nome.Size = new System.Drawing.Size(64, 24);
            this.lbl_Nome.TabIndex = 71;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Cidade.Location = new System.Drawing.Point(665, 140);
            this.txt_Cidade.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Cidade.Size = new System.Drawing.Size(246, 32);
            this.txt_Cidade.TabIndex = 69;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Culture = new System.Globalization.CultureInfo("");
            this.txt_Telefone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Telefone.Location = new System.Drawing.Point(224, 227);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Telefone.Mask = "(00)0000-0000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Telefone.Size = new System.Drawing.Size(164, 32);
            this.txt_Telefone.TabIndex = 66;
            this.txt_Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txt_Celular
            // 
            this.txt_Celular.Culture = new System.Globalization.CultureInfo("");
            this.txt_Celular.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Celular.Location = new System.Drawing.Point(224, 185);
            this.txt_Celular.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Celular.Mask = "(00)00000-0000";
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Celular.Size = new System.Drawing.Size(164, 32);
            this.txt_Celular.TabIndex = 65;
            this.txt_Celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txt_RG
            // 
            this.txt_RG.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_RG.Location = new System.Drawing.Point(224, 101);
            this.txt_RG.Margin = new System.Windows.Forms.Padding(5);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_RG.Size = new System.Drawing.Size(164, 32);
            this.txt_RG.TabIndex = 64;
            this.txt_RG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txt_CPF
            // 
            this.txt_CPF.Culture = new System.Globalization.CultureInfo("");
            this.txt_CPF.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_CPF.Location = new System.Drawing.Point(224, 59);
            this.txt_CPF.Margin = new System.Windows.Forms.Padding(5);
            this.txt_CPF.Mask = "000.000.000-00";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CPF.Size = new System.Drawing.Size(164, 32);
            this.txt_CPF.TabIndex = 63;
            this.txt_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(512, 190);
            this.lbl_Estado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Estado.Size = new System.Drawing.Size(76, 24);
            this.lbl_Estado.TabIndex = 68;
            this.lbl_Estado.Text = "Estado";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(512, 148);
            this.lbl_Cidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Cidade.Size = new System.Drawing.Size(76, 24);
            this.lbl_Cidade.TabIndex = 67;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // lbl_Celular
            // 
            this.lbl_Celular.AutoSize = true;
            this.lbl_Celular.Location = new System.Drawing.Point(14, 195);
            this.lbl_Celular.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Celular.Name = "lbl_Celular";
            this.lbl_Celular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Celular.Size = new System.Drawing.Size(75, 24);
            this.lbl_Celular.TabIndex = 62;
            this.lbl_Celular.Text = "Celular";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(14, 235);
            this.lbl_Telefone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Telefone.Size = new System.Drawing.Size(89, 24);
            this.lbl_Telefone.TabIndex = 61;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_RG
            // 
            this.lbl_RG.AutoSize = true;
            this.lbl_RG.Location = new System.Drawing.Point(14, 106);
            this.lbl_RG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_RG.Name = "lbl_RG";
            this.lbl_RG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_RG.Size = new System.Drawing.Size(41, 24);
            this.lbl_RG.TabIndex = 60;
            this.lbl_RG.Text = "RG";
            // 
            // lbl_DataNascimento
            // 
            this.lbl_DataNascimento.AutoSize = true;
            this.lbl_DataNascimento.Location = new System.Drawing.Point(14, 151);
            this.lbl_DataNascimento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_DataNascimento.Name = "lbl_DataNascimento";
            this.lbl_DataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_DataNascimento.Size = new System.Drawing.Size(200, 24);
            this.lbl_DataNascimento.TabIndex = 59;
            this.lbl_DataNascimento.Text = "Data de Nascimento";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Location = new System.Drawing.Point(14, 64);
            this.lbl_CPF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_CPF.Size = new System.Drawing.Size(52, 24);
            this.lbl_CPF.TabIndex = 58;
            this.lbl_CPF.Text = "CPF";
            // 
            // btn_AtualizarDados
            // 
            this.btn_AtualizarDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AtualizarDados.BackColor = System.Drawing.Color.Green;
            this.btn_AtualizarDados.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_AtualizarDados.FlatAppearance.BorderSize = 2;
            this.btn_AtualizarDados.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_AtualizarDados.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_AtualizarDados.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_AtualizarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtualizarDados.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_AtualizarDados.Location = new System.Drawing.Point(994, 348);
            this.btn_AtualizarDados.Name = "btn_AtualizarDados";
            this.btn_AtualizarDados.Size = new System.Drawing.Size(200, 40);
            this.btn_AtualizarDados.TabIndex = 83;
            this.btn_AtualizarDados.Text = "Atualizar Dados";
            this.btn_AtualizarDados.UseVisualStyleBackColor = false;
            this.btn_AtualizarDados.Click += new System.EventHandler(this.btn_AtualizarDados_Click);
            // 
            // btn_RestaurarDados
            // 
            this.btn_RestaurarDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_RestaurarDados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RestaurarDados.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_RestaurarDados.FlatAppearance.BorderSize = 2;
            this.btn_RestaurarDados.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_RestaurarDados.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_RestaurarDados.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_RestaurarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RestaurarDados.Location = new System.Drawing.Point(11, 348);
            this.btn_RestaurarDados.Name = "btn_RestaurarDados";
            this.btn_RestaurarDados.Size = new System.Drawing.Size(200, 40);
            this.btn_RestaurarDados.TabIndex = 84;
            this.btn_RestaurarDados.Text = "Restaurar Dados";
            this.btn_RestaurarDados.UseVisualStyleBackColor = false;
            this.btn_RestaurarDados.Click += new System.EventHandler(this.btn_RestaurarDados_Click);
            // 
            // F_DadosCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 400);
            this.Controls.Add(this.btn_RestaurarDados);
            this.Controls.Add(this.btn_AtualizarDados);
            this.Controls.Add(this.txt_NumeroResidencia);
            this.Controls.Add(this.lbl_NumeroResidencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.txt_DataNascimento);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Bairro);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.txt_RG);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.lbl_Celular);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_RG);
            this.Controls.Add(this.lbl_DataNascimento);
            this.Controls.Add(this.lbl_CPF);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1200, 400);
            this.Name = "F_DadosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_DadosCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NumeroResidencia;
        private System.Windows.Forms.Label lbl_NumeroResidencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.MaskedTextBox txt_DataNascimento;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.MaskedTextBox txt_Celular;
        private System.Windows.Forms.TextBox txt_RG;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Celular;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_RG;
        private System.Windows.Forms.Label lbl_DataNascimento;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Button btn_AtualizarDados;
        private System.Windows.Forms.Button btn_RestaurarDados;
    }
}