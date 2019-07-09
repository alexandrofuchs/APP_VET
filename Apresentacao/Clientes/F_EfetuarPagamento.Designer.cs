namespace Apresentacao.Clientes
{
    partial class F_EfetuarPagamento
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
            this.lbl_Pagamento = new System.Windows.Forms.Label();
            this.cb_ValorTotal = new System.Windows.Forms.CheckBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_DataAtendimento = new System.Windows.Forms.Label();
            this.lbl_ValorCliente = new System.Windows.Forms.Label();
            this.lbl_ValorCPF = new System.Windows.Forms.Label();
            this.btn_RegistrarPagamento = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ValorPendente = new System.Windows.Forms.Label();
            this.dgv_Itens = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ValorPagamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Pagamento
            // 
            this.lbl_Pagamento.AutoSize = true;
            this.lbl_Pagamento.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Pagamento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Pagamento.Location = new System.Drawing.Point(8, 416);
            this.lbl_Pagamento.Name = "lbl_Pagamento";
            this.lbl_Pagamento.Size = new System.Drawing.Size(100, 22);
            this.lbl_Pagamento.TabIndex = 1;
            this.lbl_Pagamento.Text = "Valor(R$): ";
            // 
            // cb_ValorTotal
            // 
            this.cb_ValorTotal.AutoSize = true;
            this.cb_ValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.cb_ValorTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cb_ValorTotal.Location = new System.Drawing.Point(244, 411);
            this.cb_ValorTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ValorTotal.Name = "cb_ValorTotal";
            this.cb_ValorTotal.Size = new System.Drawing.Size(117, 26);
            this.cb_ValorTotal.TabIndex = 2;
            this.cb_ValorTotal.Text = "Valor Total";
            this.cb_ValorTotal.UseVisualStyleBackColor = false;
            this.cb_ValorTotal.CheckedChanged += new System.EventHandler(this.cb_ValorTotal_CheckedChanged);
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Cliente.Location = new System.Drawing.Point(7, 36);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(79, 22);
            this.lbl_Cliente.TabIndex = 3;
            this.lbl_Cliente.Text = "Cliente: ";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_CPF.Location = new System.Drawing.Point(7, 58);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(59, 22);
            this.lbl_CPF.TabIndex = 4;
            this.lbl_CPF.Text = "CPF: ";
            // 
            // lbl_DataAtendimento
            // 
            this.lbl_DataAtendimento.AutoSize = true;
            this.lbl_DataAtendimento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_DataAtendimento.Location = new System.Drawing.Point(7, 80);
            this.lbl_DataAtendimento.Name = "lbl_DataAtendimento";
            this.lbl_DataAtendimento.Size = new System.Drawing.Size(206, 22);
            this.lbl_DataAtendimento.TabIndex = 5;
            this.lbl_DataAtendimento.Text = "Detalhes Atendimento: ";
            // 
            // lbl_ValorCliente
            // 
            this.lbl_ValorCliente.AutoSize = true;
            this.lbl_ValorCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorCliente.Location = new System.Drawing.Point(101, 36);
            this.lbl_ValorCliente.Name = "lbl_ValorCliente";
            this.lbl_ValorCliente.Size = new System.Drawing.Size(94, 22);
            this.lbl_ValorCliente.TabIndex = 6;
            this.lbl_ValorCliente.Text = "<<valor>>";
            // 
            // lbl_ValorCPF
            // 
            this.lbl_ValorCPF.AutoSize = true;
            this.lbl_ValorCPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorCPF.Location = new System.Drawing.Point(101, 58);
            this.lbl_ValorCPF.Name = "lbl_ValorCPF";
            this.lbl_ValorCPF.Size = new System.Drawing.Size(94, 22);
            this.lbl_ValorCPF.TabIndex = 7;
            this.lbl_ValorCPF.Text = "<<valor>>";
            // 
            // btn_RegistrarPagamento
            // 
            this.btn_RegistrarPagamento.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RegistrarPagamento.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_RegistrarPagamento.FlatAppearance.BorderSize = 2;
            this.btn_RegistrarPagamento.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_RegistrarPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_RegistrarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistrarPagamento.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarPagamento.Location = new System.Drawing.Point(338, 449);
            this.btn_RegistrarPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RegistrarPagamento.Name = "btn_RegistrarPagamento";
            this.btn_RegistrarPagamento.Size = new System.Drawing.Size(150, 40);
            this.btn_RegistrarPagamento.TabIndex = 9;
            this.btn_RegistrarPagamento.Text = "Confirmar";
            this.btn_RegistrarPagamento.UseVisualStyleBackColor = false;
            this.btn_RegistrarPagamento.Click += new System.EventHandler(this.btn_RegistrarPagamento_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancelar.FlatAppearance.BorderSize = 2;
            this.btn_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 449);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(150, 40);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(8, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor Pendente: ";
            // 
            // lbl_ValorPendente
            // 
            this.lbl_ValorPendente.AutoSize = true;
            this.lbl_ValorPendente.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ValorPendente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorPendente.Location = new System.Drawing.Point(164, 358);
            this.lbl_ValorPendente.Name = "lbl_ValorPendente";
            this.lbl_ValorPendente.Size = new System.Drawing.Size(72, 22);
            this.lbl_ValorPendente.TabIndex = 13;
            this.lbl_ValorPendente.Text = "<valor>";
            // 
            // dgv_Itens
            // 
            this.dgv_Itens.AllowUserToAddRows = false;
            this.dgv_Itens.AllowUserToDeleteRows = false;
            this.dgv_Itens.AllowUserToResizeColumns = false;
            this.dgv_Itens.AllowUserToResizeRows = false;
            this.dgv_Itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Itens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Itens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Itens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Itens.EnableHeadersVisualStyles = false;
            this.dgv_Itens.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Itens.Location = new System.Drawing.Point(12, 104);
            this.dgv_Itens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Itens.Name = "dgv_Itens";
            this.dgv_Itens.ReadOnly = true;
            this.dgv_Itens.RowHeadersVisible = false;
            this.dgv_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Itens.Size = new System.Drawing.Size(476, 252);
            this.dgv_Itens.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Registrar Pagamento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ValorPagamento
            // 
            this.txt_ValorPagamento.Location = new System.Drawing.Point(114, 408);
            this.txt_ValorPagamento.MaxLength = 20;
            this.txt_ValorPagamento.Name = "txt_ValorPagamento";
            this.txt_ValorPagamento.Size = new System.Drawing.Size(100, 29);
            this.txt_ValorPagamento.TabIndex = 16;
            this.txt_ValorPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorPagamento_KeyPress);
            // 
            // F_EfetuarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.txt_ValorPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Itens);
            this.Controls.Add(this.lbl_ValorPendente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RegistrarPagamento);
            this.Controls.Add(this.lbl_ValorCPF);
            this.Controls.Add(this.lbl_ValorCliente);
            this.Controls.Add(this.lbl_DataAtendimento);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.cb_ValorTotal);
            this.Controls.Add(this.lbl_Pagamento);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "F_EfetuarPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_EfetuarPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Pagamento;
        private System.Windows.Forms.CheckBox cb_ValorTotal;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_DataAtendimento;
        private System.Windows.Forms.Label lbl_ValorCliente;
        private System.Windows.Forms.Label lbl_ValorCPF;
        private System.Windows.Forms.Button btn_RegistrarPagamento;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ValorPendente;
        private System.Windows.Forms.DataGridView dgv_Itens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ValorPagamento;
    }
}