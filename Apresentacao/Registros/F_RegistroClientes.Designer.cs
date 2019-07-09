namespace Apresentacao.Registros
{
    partial class F_RegistroClientes
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
            this.btn_PaginaDoCliente = new System.Windows.Forms.Button();
            this.btn_BuscarPorNome = new System.Windows.Forms.Button();
            this.btn_RegistrarCliente = new System.Windows.Forms.Button();
            this.lbl_BuscarNome = new System.Windows.Forms.Label();
            this.btn_BuscarCPF = new System.Windows.Forms.Button();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.txt_BuscarNome = new System.Windows.Forms.TextBox();
            this.txt_BuscarCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbl_BuscarCPF = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 40);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_PaginaDoCliente
            // 
            this.btn_PaginaDoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_PaginaDoCliente.BackColor = System.Drawing.Color.Green;
            this.btn_PaginaDoCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_PaginaDoCliente.FlatAppearance.BorderSize = 2;
            this.btn_PaginaDoCliente.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_PaginaDoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_PaginaDoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuText;
            this.btn_PaginaDoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PaginaDoCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_PaginaDoCliente.Location = new System.Drawing.Point(59, 548);
            this.btn_PaginaDoCliente.Name = "btn_PaginaDoCliente";
            this.btn_PaginaDoCliente.Size = new System.Drawing.Size(200, 40);
            this.btn_PaginaDoCliente.TabIndex = 9;
            this.btn_PaginaDoCliente.Text = "Página do Cliente";
            this.btn_PaginaDoCliente.UseVisualStyleBackColor = false;
            this.btn_PaginaDoCliente.Click += new System.EventHandler(this.btn_PaginaDoCliente_Click);
            // 
            // btn_BuscarPorNome
            // 
            this.btn_BuscarPorNome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BuscarPorNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarPorNome.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_BuscarPorNome.FlatAppearance.BorderSize = 2;
            this.btn_BuscarPorNome.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarPorNome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarPorNome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuText;
            this.btn_BuscarPorNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarPorNome.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarPorNome.Location = new System.Drawing.Point(616, 115);
            this.btn_BuscarPorNome.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarPorNome.Name = "btn_BuscarPorNome";
            this.btn_BuscarPorNome.Size = new System.Drawing.Size(100, 40);
            this.btn_BuscarPorNome.TabIndex = 4;
            this.btn_BuscarPorNome.Text = "Buscar ";
            this.btn_BuscarPorNome.UseVisualStyleBackColor = false;
            this.btn_BuscarPorNome.Click += new System.EventHandler(this.btn_BuscarPorNome_Click);
            // 
            // btn_RegistrarCliente
            // 
            this.btn_RegistrarCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RegistrarCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_RegistrarCliente.FlatAppearance.BorderSize = 2;
            this.btn_RegistrarCliente.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuText;
            this.btn_RegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistrarCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarCliente.Location = new System.Drawing.Point(59, 72);
            this.btn_RegistrarCliente.Name = "btn_RegistrarCliente";
            this.btn_RegistrarCliente.Size = new System.Drawing.Size(250, 40);
            this.btn_RegistrarCliente.TabIndex = 1;
            this.btn_RegistrarCliente.Text = "Registrar Novo Cliente";
            this.btn_RegistrarCliente.UseVisualStyleBackColor = false;
            this.btn_RegistrarCliente.Click += new System.EventHandler(this.btn_RegistrarCliente_Click);
            // 
            // lbl_BuscarNome
            // 
            this.lbl_BuscarNome.AutoSize = true;
            this.lbl_BuscarNome.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_BuscarNome.Location = new System.Drawing.Point(54, 128);
            this.lbl_BuscarNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BuscarNome.Name = "lbl_BuscarNome";
            this.lbl_BuscarNome.Size = new System.Drawing.Size(158, 22);
            this.lbl_BuscarNome.TabIndex = 2;
            this.lbl_BuscarNome.Text = "Buscar por Nome";
            // 
            // btn_BuscarCPF
            // 
            this.btn_BuscarCPF.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BuscarCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarCPF.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btn_BuscarCPF.FlatAppearance.BorderSize = 2;
            this.btn_BuscarCPF.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarCPF.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarCPF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuText;
            this.btn_BuscarCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarCPF.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarCPF.Location = new System.Drawing.Point(462, 157);
            this.btn_BuscarCPF.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarCPF.Name = "btn_BuscarCPF";
            this.btn_BuscarCPF.Size = new System.Drawing.Size(100, 40);
            this.btn_BuscarCPF.TabIndex = 7;
            this.btn_BuscarCPF.Text = "Buscar";
            this.btn_BuscarCPF.UseVisualStyleBackColor = false;
            this.btn_BuscarCPF.Click += new System.EventHandler(this.btn_BuscarCPF_Click);
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AllowUserToDeleteRows = false;
            this.dgv_Clientes.AllowUserToResizeColumns = false;
            this.dgv_Clientes.AllowUserToResizeRows = false;
            this.dgv_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Clientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.EnableHeadersVisualStyles = false;
            this.dgv_Clientes.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Clientes.Location = new System.Drawing.Point(59, 208);
            this.dgv_Clientes.Margin = new System.Windows.Forms.Padding(50);
            this.dgv_Clientes.MultiSelect = false;
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Clientes.RowHeadersVisible = false;
            this.dgv_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clientes.Size = new System.Drawing.Size(1082, 333);
            this.dgv_Clientes.TabIndex = 8;
            this.dgv_Clientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clientes_CellContentDoubleClick);
            // 
            // txt_BuscarNome
            // 
            this.txt_BuscarNome.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarNome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_BuscarNome.Location = new System.Drawing.Point(284, 119);
            this.txt_BuscarNome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BuscarNome.Name = "txt_BuscarNome";
            this.txt_BuscarNome.Size = new System.Drawing.Size(324, 34);
            this.txt_BuscarNome.TabIndex = 3;
            // 
            // txt_BuscarCPF
            // 
            this.txt_BuscarCPF.Culture = new System.Globalization.CultureInfo("");
            this.txt_BuscarCPF.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarCPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_BuscarCPF.Location = new System.Drawing.Point(284, 161);
            this.txt_BuscarCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BuscarCPF.Mask = "000.000.000-00";
            this.txt_BuscarCPF.Name = "txt_BuscarCPF";
            this.txt_BuscarCPF.Size = new System.Drawing.Size(170, 34);
            this.txt_BuscarCPF.TabIndex = 6;
            // 
            // lbl_BuscarCPF
            // 
            this.lbl_BuscarCPF.AutoSize = true;
            this.lbl_BuscarCPF.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_BuscarCPF.Location = new System.Drawing.Point(54, 170);
            this.lbl_BuscarCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BuscarCPF.Name = "lbl_BuscarCPF";
            this.lbl_BuscarCPF.Size = new System.Drawing.Size(146, 22);
            this.lbl_BuscarCPF.TabIndex = 5;
            this.lbl_BuscarCPF.Text = "Buscar por CPF";
            // 
            // F_RegistroClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_PaginaDoCliente);
            this.Controls.Add(this.btn_BuscarPorNome);
            this.Controls.Add(this.btn_RegistrarCliente);
            this.Controls.Add(this.lbl_BuscarNome);
            this.Controls.Add(this.btn_BuscarCPF);
            this.Controls.Add(this.dgv_Clientes);
            this.Controls.Add(this.txt_BuscarNome);
            this.Controls.Add(this.txt_BuscarCPF);
            this.Controls.Add(this.lbl_BuscarCPF);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "F_RegistroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_BuscarCPF;
        private System.Windows.Forms.Label lbl_BuscarCPF;
        private System.Windows.Forms.MaskedTextBox txt_BuscarCPF;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.Label lbl_BuscarNome;
        private System.Windows.Forms.TextBox txt_BuscarNome;
        private System.Windows.Forms.Button btn_RegistrarCliente;
        private System.Windows.Forms.Button btn_BuscarPorNome;
        private System.Windows.Forms.Button btn_PaginaDoCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}