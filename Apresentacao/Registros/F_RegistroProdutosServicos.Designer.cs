namespace Apresentacao.Registros
{
    partial class F_RegistroProdutosServicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.dgv_ProdutosServicos = new System.Windows.Forms.DataGridView();
            this.btn_RegistrarProdutoServico = new System.Windows.Forms.Button();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BuscarPorNome = new System.Windows.Forms.TextBox();
            this.btn_BuscarPorNome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutosServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 40);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos e Serviços";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Alterar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Alterar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.btn_Alterar.FlatAppearance.BorderSize = 2;
            this.btn_Alterar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuText;
            this.btn_Alterar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Alterar.Location = new System.Drawing.Point(59, 548);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(150, 40);
            this.btn_Alterar.TabIndex = 3;
            this.btn_Alterar.Text = "Alterar Dados";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remover.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Remover.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.btn_Remover.FlatAppearance.BorderSize = 2;
            this.btn_Remover.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuText;
            this.btn_Remover.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Remover.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remover.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Remover.Location = new System.Drawing.Point(991, 548);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(150, 40);
            this.btn_Remover.TabIndex = 4;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // dgv_ProdutosServicos
            // 
            this.dgv_ProdutosServicos.AllowUserToAddRows = false;
            this.dgv_ProdutosServicos.AllowUserToDeleteRows = false;
            this.dgv_ProdutosServicos.AllowUserToResizeColumns = false;
            this.dgv_ProdutosServicos.AllowUserToResizeRows = false;
            this.dgv_ProdutosServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ProdutosServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProdutosServicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ProdutosServicos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ProdutosServicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProdutosServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProdutosServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProdutosServicos.EnableHeadersVisualStyles = false;
            this.dgv_ProdutosServicos.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_ProdutosServicos.Location = new System.Drawing.Point(59, 135);
            this.dgv_ProdutosServicos.Margin = new System.Windows.Forms.Padding(50);
            this.dgv_ProdutosServicos.MultiSelect = false;
            this.dgv_ProdutosServicos.Name = "dgv_ProdutosServicos";
            this.dgv_ProdutosServicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ProdutosServicos.RowHeadersVisible = false;
            this.dgv_ProdutosServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProdutosServicos.Size = new System.Drawing.Size(1082, 406);
            this.dgv_ProdutosServicos.TabIndex = 2;
            // 
            // btn_RegistrarProdutoServico
            // 
            this.btn_RegistrarProdutoServico.BackColor = System.Drawing.Color.Green;
            this.btn_RegistrarProdutoServico.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.btn_RegistrarProdutoServico.FlatAppearance.BorderSize = 2;
            this.btn_RegistrarProdutoServico.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuText;
            this.btn_RegistrarProdutoServico.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarProdutoServico.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_RegistrarProdutoServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistrarProdutoServico.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarProdutoServico.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarProdutoServico.Location = new System.Drawing.Point(59, 46);
            this.btn_RegistrarProdutoServico.Name = "btn_RegistrarProdutoServico";
            this.btn_RegistrarProdutoServico.Size = new System.Drawing.Size(150, 40);
            this.btn_RegistrarProdutoServico.TabIndex = 1;
            this.btn_RegistrarProdutoServico.Text = "Adicionar";
            this.btn_RegistrarProdutoServico.UseVisualStyleBackColor = false;
            this.btn_RegistrarProdutoServico.Click += new System.EventHandler(this.btn_RegistrarProdutoServico_Click);
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Location = new System.Drawing.Point(913, 96);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(228, 32);
            this.cmb_Tipo.TabIndex = 7;
            this.cmb_Tipo.SelectionChangeCommitted += new System.EventHandler(this.cmb_Tipo_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(846, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(55, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar Por Nome: ";
            // 
            // txt_BuscarPorNome
            // 
            this.txt_BuscarPorNome.Location = new System.Drawing.Point(248, 96);
            this.txt_BuscarPorNome.Name = "txt_BuscarPorNome";
            this.txt_BuscarPorNome.Size = new System.Drawing.Size(251, 32);
            this.txt_BuscarPorNome.TabIndex = 10;
            // 
            // btn_BuscarPorNome
            // 
            this.btn_BuscarPorNome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BuscarPorNome.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.btn_BuscarPorNome.FlatAppearance.BorderSize = 2;
            this.btn_BuscarPorNome.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuText;
            this.btn_BuscarPorNome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarPorNome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarPorNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarPorNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarPorNome.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarPorNome.Location = new System.Drawing.Point(505, 91);
            this.btn_BuscarPorNome.Name = "btn_BuscarPorNome";
            this.btn_BuscarPorNome.Size = new System.Drawing.Size(100, 40);
            this.btn_BuscarPorNome.TabIndex = 11;
            this.btn_BuscarPorNome.Text = "Buscar";
            this.btn_BuscarPorNome.UseVisualStyleBackColor = false;
            this.btn_BuscarPorNome.Click += new System.EventHandler(this.btn_BuscarPorNome_Click);
            // 
            // F_RegistroProdutosServicos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btn_BuscarPorNome);
            this.Controls.Add(this.txt_BuscarPorNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.dgv_ProdutosServicos);
            this.Controls.Add(this.btn_RegistrarProdutoServico);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "F_RegistroProdutosServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ProdutosRegistrados";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutosServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RegistrarProdutoServico;
        private System.Windows.Forms.DataGridView dgv_ProdutosServicos;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BuscarPorNome;
        private System.Windows.Forms.Button btn_BuscarPorNome;
    }
}