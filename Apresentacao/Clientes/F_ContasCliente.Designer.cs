namespace Apresentacao.Clientes
{
    partial class F_ContasCliente
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
            this.dgv_ContasCliente = new System.Windows.Forms.DataGridView();
            this.btn_EfetuarPagamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ContasCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ContasCliente
            // 
            this.dgv_ContasCliente.AllowUserToAddRows = false;
            this.dgv_ContasCliente.AllowUserToDeleteRows = false;
            this.dgv_ContasCliente.AllowUserToResizeColumns = false;
            this.dgv_ContasCliente.AllowUserToResizeRows = false;
            this.dgv_ContasCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ContasCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ContasCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ContasCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ContasCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ContasCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ContasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ContasCliente.EnableHeadersVisualStyles = false;
            this.dgv_ContasCliente.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_ContasCliente.Location = new System.Drawing.Point(59, 59);
            this.dgv_ContasCliente.Margin = new System.Windows.Forms.Padding(50);
            this.dgv_ContasCliente.MultiSelect = false;
            this.dgv_ContasCliente.Name = "dgv_ContasCliente";
            this.dgv_ContasCliente.ReadOnly = true;
            this.dgv_ContasCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ContasCliente.RowHeadersVisible = false;
            this.dgv_ContasCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ContasCliente.Size = new System.Drawing.Size(1082, 282);
            this.dgv_ContasCliente.TabIndex = 0;
            // 
            // btn_EfetuarPagamento
            // 
            this.btn_EfetuarPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_EfetuarPagamento.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_EfetuarPagamento.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_EfetuarPagamento.FlatAppearance.BorderSize = 2;
            this.btn_EfetuarPagamento.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_EfetuarPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_EfetuarPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_EfetuarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EfetuarPagamento.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_EfetuarPagamento.Location = new System.Drawing.Point(59, 348);
            this.btn_EfetuarPagamento.Name = "btn_EfetuarPagamento";
            this.btn_EfetuarPagamento.Size = new System.Drawing.Size(200, 40);
            this.btn_EfetuarPagamento.TabIndex = 2;
            this.btn_EfetuarPagamento.Text = "Pagamento";
            this.btn_EfetuarPagamento.UseVisualStyleBackColor = false;
            this.btn_EfetuarPagamento.Click += new System.EventHandler(this.btn_EfetuarPagamento_Click);
            // 
            // F_ContasCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 400);
            this.Controls.Add(this.btn_EfetuarPagamento);
            this.Controls.Add(this.dgv_ContasCliente);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "F_ContasCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ContasCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ContasCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ContasCliente;
        private System.Windows.Forms.Button btn_EfetuarPagamento;
    }
}