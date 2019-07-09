namespace Apresentacao.Buscas
{
    partial class F_BuscarAnimal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Animais = new System.Windows.Forms.DataGridView();
            this.txt_DadoBusca = new System.Windows.Forms.TextBox();
            this.cmb_BuscarPor = new System.Windows.Forms.ComboBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.lbl_BuscarPor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_DadoBusca = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Animais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Animais
            // 
            this.dgv_Animais.AllowUserToAddRows = false;
            this.dgv_Animais.AllowUserToDeleteRows = false;
            this.dgv_Animais.AllowUserToResizeColumns = false;
            this.dgv_Animais.AllowUserToResizeRows = false;
            this.dgv_Animais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Animais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Animais.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Animais.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Animais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Animais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Animais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Animais.EnableHeadersVisualStyles = false;
            this.dgv_Animais.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Animais.Location = new System.Drawing.Point(13, 138);
            this.dgv_Animais.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgv_Animais.Name = "dgv_Animais";
            this.dgv_Animais.RowHeadersVisible = false;
            this.dgv_Animais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Animais.Size = new System.Drawing.Size(574, 238);
            this.dgv_Animais.TabIndex = 0;
            // 
            // txt_DadoBusca
            // 
            this.txt_DadoBusca.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DadoBusca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_DadoBusca.Location = new System.Drawing.Point(168, 88);
            this.txt_DadoBusca.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txt_DadoBusca.Name = "txt_DadoBusca";
            this.txt_DadoBusca.Size = new System.Drawing.Size(232, 35);
            this.txt_DadoBusca.TabIndex = 1;
            // 
            // cmb_BuscarPor
            // 
            this.cmb_BuscarPor.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_BuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_BuscarPor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_BuscarPor.FormattingEnabled = true;
            this.cmb_BuscarPor.Location = new System.Drawing.Point(168, 47);
            this.cmb_BuscarPor.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmb_BuscarPor.Name = "cmb_BuscarPor";
            this.cmb_BuscarPor.Size = new System.Drawing.Size(232, 30);
            this.cmb_BuscarPor.TabIndex = 2;
            this.cmb_BuscarPor.SelectionChangeCommitted += new System.EventHandler(this.cmb_BuscarPor_SelectionChangeCommitted);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Confirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Confirmar.FlatAppearance.BorderSize = 2;
            this.btn_Confirmar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Confirmar.Location = new System.Drawing.Point(437, 394);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(150, 40);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Buscar.FlatAppearance.BorderSize = 2;
            this.btn_Buscar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Buscar.Location = new System.Drawing.Point(408, 85);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(100, 40);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // lbl_BuscarPor
            // 
            this.lbl_BuscarPor.AutoSize = true;
            this.lbl_BuscarPor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_BuscarPor.Location = new System.Drawing.Point(13, 52);
            this.lbl_BuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BuscarPor.Name = "lbl_BuscarPor";
            this.lbl_BuscarPor.Size = new System.Drawing.Size(114, 22);
            this.lbl_BuscarPor.TabIndex = 7;
            this.lbl_BuscarPor.Text = "Buscar Por: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 8;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Sair.FlatAppearance.BorderSize = 2;
            this.btn_Sair.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Sair.Location = new System.Drawing.Point(13, 394);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(150, 40);
            this.btn_Sair.TabIndex = 10;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_DadoBusca
            // 
            this.lbl_DadoBusca.AutoSize = true;
            this.lbl_DadoBusca.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_DadoBusca.Location = new System.Drawing.Point(14, 96);
            this.lbl_DadoBusca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DadoBusca.Name = "lbl_DadoBusca";
            this.lbl_DadoBusca.Size = new System.Drawing.Size(141, 22);
            this.lbl_DadoBusca.TabIndex = 11;
            this.lbl_DadoBusca.Text = "Dado de Busca";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "Buscar Animal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_BuscarAnimal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_DadoBusca);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_BuscarPor);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.cmb_BuscarPor);
            this.Controls.Add(this.txt_DadoBusca);
            this.Controls.Add(this.dgv_Animais);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "F_BuscarAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Animal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Animais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Animais;
        private System.Windows.Forms.TextBox txt_DadoBusca;
        private System.Windows.Forms.ComboBox cmb_BuscarPor;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_BuscarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_DadoBusca;
        private System.Windows.Forms.Label label3;
    }
}