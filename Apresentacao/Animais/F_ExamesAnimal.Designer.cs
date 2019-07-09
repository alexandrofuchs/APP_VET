namespace Apresentacao.Animais
{
    partial class F_ExamesAnimal
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
            this.dgv_Exames = new System.Windows.Forms.DataGridView();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_DadosExame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exames)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Exames
            // 
            this.dgv_Exames.AllowUserToAddRows = false;
            this.dgv_Exames.AllowUserToDeleteRows = false;
            this.dgv_Exames.AllowUserToResizeColumns = false;
            this.dgv_Exames.AllowUserToResizeRows = false;
            this.dgv_Exames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Exames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Exames.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Exames.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Exames.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Exames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Exames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exames.EnableHeadersVisualStyles = false;
            this.dgv_Exames.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Exames.Location = new System.Drawing.Point(59, 59);
            this.dgv_Exames.Margin = new System.Windows.Forms.Padding(50);
            this.dgv_Exames.MultiSelect = false;
            this.dgv_Exames.Name = "dgv_Exames";
            this.dgv_Exames.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Exames.RowHeadersVisible = false;
            this.dgv_Exames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Exames.Size = new System.Drawing.Size(1082, 236);
            this.dgv_Exames.TabIndex = 0;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Registrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Registrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Registrar.FlatAppearance.BorderSize = 2;
            this.btn_Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Registrar.Location = new System.Drawing.Point(59, 348);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(200, 40);
            this.btn_Registrar.TabIndex = 1;
            this.btn_Registrar.Text = "Registrar Exame";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_DadosExame
            // 
            this.btn_DadosExame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DadosExame.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DadosExame.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_DadosExame.FlatAppearance.BorderSize = 2;
            this.btn_DadosExame.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_DadosExame.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_DadosExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DadosExame.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_DadosExame.Location = new System.Drawing.Point(941, 348);
            this.btn_DadosExame.Name = "btn_DadosExame";
            this.btn_DadosExame.Size = new System.Drawing.Size(200, 40);
            this.btn_DadosExame.TabIndex = 5;
            this.btn_DadosExame.Text = "Dados Exame";
            this.btn_DadosExame.UseVisualStyleBackColor = false;
            this.btn_DadosExame.Click += new System.EventHandler(this.btn_DadosExame_Click);
            // 
            // F_ExamesAnimal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 400);
            this.Controls.Add(this.btn_DadosExame);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.dgv_Exames);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 400);
            this.Name = "F_ExamesAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Exames;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_DadosExame;
    }
}