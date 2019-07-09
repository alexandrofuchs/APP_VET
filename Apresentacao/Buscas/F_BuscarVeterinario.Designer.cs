namespace Apresentacao.Buscas
{
    partial class F_BuscarVeterinario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_BuscarPorNome = new System.Windows.Forms.TextBox();
            this.lbl_BuscarPorNome = new System.Windows.Forms.Label();
            this.dgv_Consultas = new System.Windows.Forms.DataGridView();
            this.dgv_Veterinarios = new System.Windows.Forms.DataGridView();
            this.btn_BuscarVeterinario = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Veterinarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_BuscarPorNome
            // 
            this.txt_BuscarPorNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BuscarPorNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BuscarPorNome.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarPorNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_BuscarPorNome.Location = new System.Drawing.Point(14, 80);
            this.txt_BuscarPorNome.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_BuscarPorNome.Name = "txt_BuscarPorNome";
            this.txt_BuscarPorNome.Size = new System.Drawing.Size(322, 39);
            this.txt_BuscarPorNome.TabIndex = 1;
            // 
            // lbl_BuscarPorNome
            // 
            this.lbl_BuscarPorNome.AutoSize = true;
            this.lbl_BuscarPorNome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_BuscarPorNome.Location = new System.Drawing.Point(9, 50);
            this.lbl_BuscarPorNome.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_BuscarPorNome.Name = "lbl_BuscarPorNome";
            this.lbl_BuscarPorNome.Size = new System.Drawing.Size(160, 22);
            this.lbl_BuscarPorNome.TabIndex = 2;
            this.lbl_BuscarPorNome.Text = "Buscar Por Nome";
            // 
            // dgv_Consultas
            // 
            this.dgv_Consultas.AllowUserToAddRows = false;
            this.dgv_Consultas.AllowUserToDeleteRows = false;
            this.dgv_Consultas.AllowUserToResizeColumns = false;
            this.dgv_Consultas.AllowUserToResizeRows = false;
            this.dgv_Consultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Consultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Consultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Consultas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Consultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Consultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consultas.EnableHeadersVisualStyles = false;
            this.dgv_Consultas.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Consultas.Location = new System.Drawing.Point(13, 338);
            this.dgv_Consultas.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Consultas.MultiSelect = false;
            this.dgv_Consultas.Name = "dgv_Consultas";
            this.dgv_Consultas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Consultas.RowHeadersVisible = false;
            this.dgv_Consultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Consultas.Size = new System.Drawing.Size(574, 201);
            this.dgv_Consultas.TabIndex = 5;
            // 
            // dgv_Veterinarios
            // 
            this.dgv_Veterinarios.AllowUserToAddRows = false;
            this.dgv_Veterinarios.AllowUserToDeleteRows = false;
            this.dgv_Veterinarios.AllowUserToResizeColumns = false;
            this.dgv_Veterinarios.AllowUserToResizeRows = false;
            this.dgv_Veterinarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_Veterinarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Veterinarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Veterinarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Veterinarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Veterinarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Veterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Veterinarios.EnableHeadersVisualStyles = false;
            this.dgv_Veterinarios.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Veterinarios.Location = new System.Drawing.Point(13, 130);
            this.dgv_Veterinarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Veterinarios.MultiSelect = false;
            this.dgv_Veterinarios.Name = "dgv_Veterinarios";
            this.dgv_Veterinarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Veterinarios.RowHeadersVisible = false;
            this.dgv_Veterinarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Veterinarios.Size = new System.Drawing.Size(574, 200);
            this.dgv_Veterinarios.TabIndex = 6;
            this.dgv_Veterinarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Veterinarios_CellContentClick);
            // 
            // btn_BuscarVeterinario
            // 
            this.btn_BuscarVeterinario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BuscarVeterinario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BuscarVeterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarVeterinario.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarVeterinario.FlatAppearance.BorderSize = 2;
            this.btn_BuscarVeterinario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarVeterinario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarVeterinario.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarVeterinario.Location = new System.Drawing.Point(345, 79);
            this.btn_BuscarVeterinario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarVeterinario.Name = "btn_BuscarVeterinario";
            this.btn_BuscarVeterinario.Size = new System.Drawing.Size(100, 40);
            this.btn_BuscarVeterinario.TabIndex = 7;
            this.btn_BuscarVeterinario.Text = "Buscar";
            this.btn_BuscarVeterinario.UseVisualStyleBackColor = false;
            this.btn_BuscarVeterinario.Click += new System.EventHandler(this.btn_BuscarVeterinario_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirmar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Confirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Confirmar.FlatAppearance.BorderSize = 2;
            this.btn_Confirmar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Confirmar.Location = new System.Drawing.Point(437, 547);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(150, 40);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sair.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Sair.FlatAppearance.BorderSize = 2;
            this.btn_Sair.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Sair.Location = new System.Drawing.Point(13, 547);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(150, 40);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar Veterinários";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_BuscarVeterinario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.btn_BuscarVeterinario);
            this.Controls.Add(this.dgv_Veterinarios);
            this.Controls.Add(this.dgv_Consultas);
            this.Controls.Add(this.lbl_BuscarPorNome);
            this.Controls.Add(this.txt_BuscarPorNome);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "F_BuscarVeterinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Veterinário";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Veterinarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_BuscarPorNome;
        private System.Windows.Forms.Label lbl_BuscarPorNome;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.DataGridView dgv_Consultas;
        private System.Windows.Forms.DataGridView dgv_Veterinarios;
        private System.Windows.Forms.Button btn_BuscarVeterinario;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label label1;
    }
}