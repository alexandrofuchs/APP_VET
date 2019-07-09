namespace Apresentacao.Registros
{
    partial class F_RegistrarProdutoServico
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
            this.btn_RegistrarProduto = new System.Windows.Forms.Button();
            this.txt_Sigla = new System.Windows.Forms.TextBox();
            this.lbl_Sigla = new System.Windows.Forms.Label();
            this.lbl_Moeda = new System.Windows.Forms.Label();
            this.txt_Custo = new System.Windows.Forms.TextBox();
            this.lbl_CustoProduto = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_NomeProduto = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.rb_Medicamento = new System.Windows.Forms.RadioButton();
            this.rb_ServicoClinico = new System.Windows.Forms.RadioButton();
            this.rb_Exame = new System.Windows.Forms.RadioButton();
            this.rb_OutrosProdutos = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_RegistrarProduto
            // 
            this.btn_RegistrarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RegistrarProduto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RegistrarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RegistrarProduto.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_RegistrarProduto.FlatAppearance.BorderSize = 2;
            this.btn_RegistrarProduto.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_RegistrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistrarProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarProduto.Location = new System.Drawing.Point(407, 448);
            this.btn_RegistrarProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RegistrarProduto.Name = "btn_RegistrarProduto";
            this.btn_RegistrarProduto.Size = new System.Drawing.Size(150, 41);
            this.btn_RegistrarProduto.TabIndex = 15;
            this.btn_RegistrarProduto.Text = "Registrar";
            this.btn_RegistrarProduto.UseVisualStyleBackColor = false;
            this.btn_RegistrarProduto.Click += new System.EventHandler(this.btn_RegistrarProduto_Click);
            // 
            // txt_Sigla
            // 
            this.txt_Sigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Sigla.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Sigla.Location = new System.Drawing.Point(418, 125);
            this.txt_Sigla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Sigla.MaxLength = 5;
            this.txt_Sigla.Name = "txt_Sigla";
            this.txt_Sigla.Size = new System.Drawing.Size(139, 29);
            this.txt_Sigla.TabIndex = 9;
            // 
            // lbl_Sigla
            // 
            this.lbl_Sigla.AutoSize = true;
            this.lbl_Sigla.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Sigla.Location = new System.Drawing.Point(12, 133);
            this.lbl_Sigla.Name = "lbl_Sigla";
            this.lbl_Sigla.Size = new System.Drawing.Size(62, 22);
            this.lbl_Sigla.TabIndex = 8;
            this.lbl_Sigla.Text = "Sigla: ";
            // 
            // lbl_Moeda
            // 
            this.lbl_Moeda.AutoSize = true;
            this.lbl_Moeda.Location = new System.Drawing.Point(377, 172);
            this.lbl_Moeda.Name = "lbl_Moeda";
            this.lbl_Moeda.Size = new System.Drawing.Size(35, 22);
            this.lbl_Moeda.TabIndex = 18;
            this.lbl_Moeda.Text = "R$";
            // 
            // txt_Custo
            // 
            this.txt_Custo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Custo.Location = new System.Drawing.Point(418, 164);
            this.txt_Custo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Custo.MaxLength = 10;
            this.txt_Custo.Name = "txt_Custo";
            this.txt_Custo.Size = new System.Drawing.Size(139, 29);
            this.txt_Custo.TabIndex = 11;
            this.txt_Custo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Custo_KeyPress);
            // 
            // lbl_CustoProduto
            // 
            this.lbl_CustoProduto.AutoSize = true;
            this.lbl_CustoProduto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_CustoProduto.Location = new System.Drawing.Point(12, 172);
            this.lbl_CustoProduto.Name = "lbl_CustoProduto";
            this.lbl_CustoProduto.Size = new System.Drawing.Size(70, 22);
            this.lbl_CustoProduto.TabIndex = 10;
            this.lbl_CustoProduto.Text = "Custo: ";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Descricao.Location = new System.Drawing.Point(17, 241);
            this.txt_Descricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Descricao.MaxLength = 200;
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(540, 202);
            this.txt_Descricao.TabIndex = 13;
            // 
            // txt_Nome
            // 
            this.txt_Nome.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Nome.Location = new System.Drawing.Point(91, 85);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(466, 29);
            this.txt_Nome.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl.Location = new System.Drawing.Point(12, 211);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(200, 22);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Descrição do Produto:";
            // 
            // lbl_NomeProduto
            // 
            this.lbl_NomeProduto.AutoSize = true;
            this.lbl_NomeProduto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_NomeProduto.Location = new System.Drawing.Point(12, 92);
            this.lbl_NomeProduto.Name = "lbl_NomeProduto";
            this.lbl_NomeProduto.Size = new System.Drawing.Size(66, 22);
            this.lbl_NomeProduto.TabIndex = 6;
            this.lbl_NomeProduto.Text = "Nome:";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Voltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Voltar.FlatAppearance.BorderSize = 2;
            this.btn_Voltar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Voltar.Location = new System.Drawing.Point(17, 448);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(150, 41);
            this.btn_Voltar.TabIndex = 14;
            this.btn_Voltar.Text = "Fechar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Tipo.Location = new System.Drawing.Point(12, 43);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(57, 22);
            this.lbl_Tipo.TabIndex = 1;
            this.lbl_Tipo.Text = "Tipo: ";
            // 
            // rb_Medicamento
            // 
            this.rb_Medicamento.AutoSize = true;
            this.rb_Medicamento.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Medicamento.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rb_Medicamento.Location = new System.Drawing.Point(81, 45);
            this.rb_Medicamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Medicamento.Name = "rb_Medicamento";
            this.rb_Medicamento.Size = new System.Drawing.Size(120, 24);
            this.rb_Medicamento.TabIndex = 2;
            this.rb_Medicamento.TabStop = true;
            this.rb_Medicamento.Text = "Medicamento";
            this.rb_Medicamento.UseVisualStyleBackColor = true;
            // 
            // rb_ServicoClinico
            // 
            this.rb_ServicoClinico.AutoSize = true;
            this.rb_ServicoClinico.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ServicoClinico.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rb_ServicoClinico.Location = new System.Drawing.Point(285, 45);
            this.rb_ServicoClinico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ServicoClinico.Name = "rb_ServicoClinico";
            this.rb_ServicoClinico.Size = new System.Drawing.Size(127, 24);
            this.rb_ServicoClinico.TabIndex = 4;
            this.rb_ServicoClinico.TabStop = true;
            this.rb_ServicoClinico.Text = "Serviço Clínico";
            this.rb_ServicoClinico.UseVisualStyleBackColor = true;
            // 
            // rb_Exame
            // 
            this.rb_Exame.AutoSize = true;
            this.rb_Exame.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Exame.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rb_Exame.Location = new System.Drawing.Point(207, 45);
            this.rb_Exame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Exame.Name = "rb_Exame";
            this.rb_Exame.Size = new System.Drawing.Size(72, 24);
            this.rb_Exame.TabIndex = 3;
            this.rb_Exame.TabStop = true;
            this.rb_Exame.Text = "Exame";
            this.rb_Exame.UseVisualStyleBackColor = true;
            // 
            // rb_OutrosProdutos
            // 
            this.rb_OutrosProdutos.AutoSize = true;
            this.rb_OutrosProdutos.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_OutrosProdutos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rb_OutrosProdutos.Location = new System.Drawing.Point(418, 45);
            this.rb_OutrosProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_OutrosProdutos.Name = "rb_OutrosProdutos";
            this.rb_OutrosProdutos.Size = new System.Drawing.Size(142, 24);
            this.rb_OutrosProdutos.TabIndex = 5;
            this.rb_OutrosProdutos.TabStop = true;
            this.rb_OutrosProdutos.Text = "Outros Produtos";
            this.rb_OutrosProdutos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 41);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Produto/Serviço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_RegistrarProdutoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(569, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rb_OutrosProdutos);
            this.Controls.Add(this.rb_Exame);
            this.Controls.Add(this.rb_ServicoClinico);
            this.Controls.Add(this.rb_Medicamento);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.txt_Sigla);
            this.Controls.Add(this.lbl_Sigla);
            this.Controls.Add(this.lbl_Moeda);
            this.Controls.Add(this.txt_Custo);
            this.Controls.Add(this.lbl_CustoProduto);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbl_NomeProduto);
            this.Controls.Add(this.btn_RegistrarProduto);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "F_RegistrarProdutoServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Serviço";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_RegistrarProduto;
        private System.Windows.Forms.TextBox txt_Sigla;
        private System.Windows.Forms.Label lbl_Sigla;
        private System.Windows.Forms.Label lbl_Moeda;
        private System.Windows.Forms.TextBox txt_Custo;
        private System.Windows.Forms.Label lbl_CustoProduto;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_NomeProduto;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.RadioButton rb_Medicamento;
        private System.Windows.Forms.RadioButton rb_ServicoClinico;
        private System.Windows.Forms.RadioButton rb_Exame;
        private System.Windows.Forms.RadioButton rb_OutrosProdutos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}