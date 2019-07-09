namespace Apresentacao.Caixa
{
    partial class F_ContasReceber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_PagamentosDia = new System.Windows.Forms.Label();
            this.monthCalendar_DiasRecebimento = new System.Windows.Forms.MonthCalendar();
            this.lbl_TotalRecebimentos = new System.Windows.Forms.Label();
            this.lbl_ValorTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Mes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ValorGastos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Caixa = new System.Windows.Forms.Label();
            this.lbl_ValorTotalCaixa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_ItensProduto = new System.Windows.Forms.DataGridView();
            this.dgv_Recebimentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItensProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recebimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PagamentosDia
            // 
            this.lbl_PagamentosDia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_PagamentosDia.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_PagamentosDia.Location = new System.Drawing.Point(16, 45);
            this.lbl_PagamentosDia.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_PagamentosDia.Name = "lbl_PagamentosDia";
            this.lbl_PagamentosDia.Size = new System.Drawing.Size(227, 40);
            this.lbl_PagamentosDia.TabIndex = 1;
            this.lbl_PagamentosDia.Text = "Selecionar Dias ";
            this.lbl_PagamentosDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar_DiasRecebimento
            // 
            this.monthCalendar_DiasRecebimento.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar_DiasRecebimento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthCalendar_DiasRecebimento.Location = new System.Drawing.Point(16, 88);
            this.monthCalendar_DiasRecebimento.MaxSelectionCount = 31;
            this.monthCalendar_DiasRecebimento.Name = "monthCalendar_DiasRecebimento";
            this.monthCalendar_DiasRecebimento.ShowTodayCircle = false;
            this.monthCalendar_DiasRecebimento.TabIndex = 3;
            this.monthCalendar_DiasRecebimento.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DiasRecebimento_DateSelected);
            // 
            // lbl_TotalRecebimentos
            // 
            this.lbl_TotalRecebimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_TotalRecebimentos.AutoSize = true;
            this.lbl_TotalRecebimentos.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_TotalRecebimentos.Location = new System.Drawing.Point(252, 420);
            this.lbl_TotalRecebimentos.Name = "lbl_TotalRecebimentos";
            this.lbl_TotalRecebimentos.Size = new System.Drawing.Size(189, 22);
            this.lbl_TotalRecebimentos.TabIndex = 4;
            this.lbl_TotalRecebimentos.Text = "Total Recebimentos: ";
            // 
            // lbl_ValorTotal
            // 
            this.lbl_ValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValorTotal.AutoSize = true;
            this.lbl_ValorTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_ValorTotal.Location = new System.Drawing.Point(447, 420);
            this.lbl_ValorTotal.Name = "lbl_ValorTotal";
            this.lbl_ValorTotal.Size = new System.Drawing.Size(97, 22);
            this.lbl_ValorTotal.TabIndex = 5;
            this.lbl_ValorTotal.Text = "<<Valor>>";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Relatório de Caixa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Mes
            // 
            this.cmb_Mes.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Mes.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmb_Mes.FormattingEnabled = true;
            this.cmb_Mes.Location = new System.Drawing.Point(14, 309);
            this.cmb_Mes.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_Mes.Name = "cmb_Mes";
            this.cmb_Mes.Size = new System.Drawing.Size(227, 35);
            this.cmb_Mes.TabIndex = 7;
            this.cmb_Mes.SelectionChangeCommitted += new System.EventHandler(this.cmb_Mes_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(16, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mês";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ValorGastos
            // 
            this.lbl_ValorGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValorGastos.AutoSize = true;
            this.lbl_ValorGastos.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_ValorGastos.Location = new System.Drawing.Point(863, 420);
            this.lbl_ValorGastos.Name = "lbl_ValorGastos";
            this.lbl_ValorGastos.Size = new System.Drawing.Size(97, 22);
            this.lbl_ValorGastos.TabIndex = 11;
            this.lbl_ValorGastos.Text = "<<Valor>>";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(731, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Gastos: ";
            // 
            // lbl_Caixa
            // 
            this.lbl_Caixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Caixa.AutoSize = true;
            this.lbl_Caixa.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caixa.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Caixa.Location = new System.Drawing.Point(667, 557);
            this.lbl_Caixa.Name = "lbl_Caixa";
            this.lbl_Caixa.Size = new System.Drawing.Size(186, 34);
            this.lbl_Caixa.TabIndex = 12;
            this.lbl_Caixa.Text = "Total Caixa: ";
            // 
            // lbl_ValorTotalCaixa
            // 
            this.lbl_ValorTotalCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValorTotalCaixa.AutoSize = true;
            this.lbl_ValorTotalCaixa.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorTotalCaixa.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_ValorTotalCaixa.Location = new System.Drawing.Point(1035, 557);
            this.lbl_ValorTotalCaixa.Name = "lbl_ValorTotalCaixa";
            this.lbl_ValorTotalCaixa.Size = new System.Drawing.Size(153, 34);
            this.lbl_ValorTotalCaixa.TabIndex = 13;
            this.lbl_ValorTotalCaixa.Text = "<<Valor>>";
            this.lbl_ValorTotalCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(256, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.MaximumSize = new System.Drawing.Size(500, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "Recebimentos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(731, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.MaximumSize = new System.Drawing.Size(500, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gastos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_ItensProduto
            // 
            this.dgv_ItensProduto.AllowUserToAddRows = false;
            this.dgv_ItensProduto.AllowUserToDeleteRows = false;
            this.dgv_ItensProduto.AllowUserToResizeColumns = false;
            this.dgv_ItensProduto.AllowUserToResizeRows = false;
            this.dgv_ItensProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ItensProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ItensProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ItensProduto.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ItensProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ItensProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ItensProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ItensProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItensProduto.EnableHeadersVisualStyles = false;
            this.dgv_ItensProduto.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_ItensProduto.Location = new System.Drawing.Point(731, 110);
            this.dgv_ItensProduto.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_ItensProduto.MaximumSize = new System.Drawing.Size(500, 0);
            this.dgv_ItensProduto.MultiSelect = false;
            this.dgv_ItensProduto.Name = "dgv_ItensProduto";
            this.dgv_ItensProduto.ReadOnly = true;
            this.dgv_ItensProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_ItensProduto.RowHeadersVisible = false;
            this.dgv_ItensProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ItensProduto.Size = new System.Drawing.Size(450, 300);
            this.dgv_ItensProduto.TabIndex = 9;
            // 
            // dgv_Recebimentos
            // 
            this.dgv_Recebimentos.AllowUserToAddRows = false;
            this.dgv_Recebimentos.AllowUserToDeleteRows = false;
            this.dgv_Recebimentos.AllowUserToResizeColumns = false;
            this.dgv_Recebimentos.AllowUserToResizeRows = false;
            this.dgv_Recebimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Recebimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Recebimentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Recebimentos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Recebimentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Recebimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Recebimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Recebimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recebimentos.EnableHeadersVisualStyles = false;
            this.dgv_Recebimentos.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Recebimentos.Location = new System.Drawing.Point(256, 110);
            this.dgv_Recebimentos.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_Recebimentos.MaximumSize = new System.Drawing.Size(500, 0);
            this.dgv_Recebimentos.MultiSelect = false;
            this.dgv_Recebimentos.Name = "dgv_Recebimentos";
            this.dgv_Recebimentos.ReadOnly = true;
            this.dgv_Recebimentos.RowHeadersVisible = false;
            this.dgv_Recebimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Recebimentos.Size = new System.Drawing.Size(450, 300);
            this.dgv_Recebimentos.TabIndex = 16;
            // 
            // F_ContasReceber
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.dgv_Recebimentos);
            this.Controls.Add(this.lbl_ValorTotalCaixa);
            this.Controls.Add(this.lbl_Caixa);
            this.Controls.Add(this.lbl_ValorGastos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ValorTotal);
            this.Controls.Add(this.lbl_TotalRecebimentos);
            this.Controls.Add(this.dgv_ItensProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Mes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar_DiasRecebimento);
            this.Controls.Add(this.lbl_PagamentosDia);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "F_ContasReceber";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ContasReceber";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItensProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recebimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_PagamentosDia;
        private System.Windows.Forms.MonthCalendar monthCalendar_DiasRecebimento;
        private System.Windows.Forms.Label lbl_TotalRecebimentos;
        private System.Windows.Forms.Label lbl_ValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Mes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ValorGastos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Caixa;
        private System.Windows.Forms.Label lbl_ValorTotalCaixa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_ItensProduto;
        private System.Windows.Forms.DataGridView dgv_Recebimentos;
    }
}