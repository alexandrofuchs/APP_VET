namespace Apresentacao.Animais
{
    partial class F_ConsultasAnimal
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
            this.dgv_ConsultasRealizadas = new System.Windows.Forms.DataGridView();
            this.btn_VerDetalhesConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultasRealizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ConsultasRealizadas
            // 
            this.dgv_ConsultasRealizadas.AllowUserToAddRows = false;
            this.dgv_ConsultasRealizadas.AllowUserToDeleteRows = false;
            this.dgv_ConsultasRealizadas.AllowUserToResizeColumns = false;
            this.dgv_ConsultasRealizadas.AllowUserToResizeRows = false;
            this.dgv_ConsultasRealizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ConsultasRealizadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ConsultasRealizadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ConsultasRealizadas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ConsultasRealizadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ConsultasRealizadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ConsultasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ConsultasRealizadas.EnableHeadersVisualStyles = false;
            this.dgv_ConsultasRealizadas.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_ConsultasRealizadas.Location = new System.Drawing.Point(59, 59);
            this.dgv_ConsultasRealizadas.Margin = new System.Windows.Forms.Padding(50);
            this.dgv_ConsultasRealizadas.MultiSelect = false;
            this.dgv_ConsultasRealizadas.Name = "dgv_ConsultasRealizadas";
            this.dgv_ConsultasRealizadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ConsultasRealizadas.RowHeadersVisible = false;
            this.dgv_ConsultasRealizadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ConsultasRealizadas.Size = new System.Drawing.Size(1082, 229);
            this.dgv_ConsultasRealizadas.TabIndex = 0;
            // 
            // btn_VerDetalhesConsulta
            // 
            this.btn_VerDetalhesConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_VerDetalhesConsulta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_VerDetalhesConsulta.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_VerDetalhesConsulta.FlatAppearance.BorderSize = 2;
            this.btn_VerDetalhesConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_VerDetalhesConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_VerDetalhesConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerDetalhesConsulta.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_VerDetalhesConsulta.Location = new System.Drawing.Point(59, 296);
            this.btn_VerDetalhesConsulta.Name = "btn_VerDetalhesConsulta";
            this.btn_VerDetalhesConsulta.Size = new System.Drawing.Size(200, 40);
            this.btn_VerDetalhesConsulta.TabIndex = 1;
            this.btn_VerDetalhesConsulta.Text = "Dados da Consulta";
            this.btn_VerDetalhesConsulta.UseVisualStyleBackColor = false;
            this.btn_VerDetalhesConsulta.Click += new System.EventHandler(this.btn_VerDetalhesConsulta_Click);
            // 
            // F_ConsultasAnimal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 400);
            this.Controls.Add(this.btn_VerDetalhesConsulta);
            this.Controls.Add(this.dgv_ConsultasRealizadas);
            this.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1200, 400);
            this.Name = "F_ConsultasAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ResumoConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultasRealizadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ConsultasRealizadas;
        private System.Windows.Forms.Button btn_VerDetalhesConsulta;
    }
}