namespace Apresentacao.Agendamentos
{
    partial class F_Agendamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_AgendaDiaria = new System.Windows.Forms.DataGridView();
            this.dgv_AgendaMensal = new System.Windows.Forms.DataGridView();
            this.monthCalendar_Consultas = new System.Windows.Forms.MonthCalendar();
            this.cmb_Mes = new System.Windows.Forms.ComboBox();
            this.btn_AgendarServico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_ValorAnimal = new System.Windows.Forms.Label();
            this.lbl_ValorVeterinario = new System.Windows.Forms.Label();
            this.lbl_ValorCliente = new System.Windows.Forms.Label();
            this.lbl_ValorDataHora = new System.Windows.Forms.Label();
            this.btn_Concluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AgendaDiaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AgendaMensal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_AgendaDiaria
            // 
            this.dgv_AgendaDiaria.AllowUserToAddRows = false;
            this.dgv_AgendaDiaria.AllowUserToDeleteRows = false;
            this.dgv_AgendaDiaria.AllowUserToResizeColumns = false;
            this.dgv_AgendaDiaria.AllowUserToResizeRows = false;
            this.dgv_AgendaDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_AgendaDiaria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AgendaDiaria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AgendaDiaria.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_AgendaDiaria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AgendaDiaria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_AgendaDiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AgendaDiaria.EnableHeadersVisualStyles = false;
            this.dgv_AgendaDiaria.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_AgendaDiaria.Location = new System.Drawing.Point(59, 90);
            this.dgv_AgendaDiaria.Margin = new System.Windows.Forms.Padding(50);
            this.dgv_AgendaDiaria.MultiSelect = false;
            this.dgv_AgendaDiaria.Name = "dgv_AgendaDiaria";
            this.dgv_AgendaDiaria.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgv_AgendaDiaria.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_AgendaDiaria.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_AgendaDiaria.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_AgendaDiaria.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_AgendaDiaria.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_AgendaDiaria.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgv_AgendaDiaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AgendaDiaria.Size = new System.Drawing.Size(755, 157);
            this.dgv_AgendaDiaria.TabIndex = 21;
            this.dgv_AgendaDiaria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AgendaDiaria_CellContentClick);
            // 
            // dgv_AgendaMensal
            // 
            this.dgv_AgendaMensal.AllowUserToAddRows = false;
            this.dgv_AgendaMensal.AllowUserToDeleteRows = false;
            this.dgv_AgendaMensal.AllowUserToResizeColumns = false;
            this.dgv_AgendaMensal.AllowUserToResizeRows = false;
            this.dgv_AgendaMensal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_AgendaMensal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AgendaMensal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AgendaMensal.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_AgendaMensal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AgendaMensal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_AgendaMensal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AgendaMensal.EnableHeadersVisualStyles = false;
            this.dgv_AgendaMensal.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_AgendaMensal.Location = new System.Drawing.Point(59, 347);
            this.dgv_AgendaMensal.Margin = new System.Windows.Forms.Padding(50);
            this.dgv_AgendaMensal.MultiSelect = false;
            this.dgv_AgendaMensal.Name = "dgv_AgendaMensal";
            this.dgv_AgendaMensal.ReadOnly = true;
            this.dgv_AgendaMensal.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Source Sans Pro Semibold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgv_AgendaMensal.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_AgendaMensal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_AgendaMensal.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_AgendaMensal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_AgendaMensal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_AgendaMensal.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgv_AgendaMensal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AgendaMensal.Size = new System.Drawing.Size(755, 194);
            this.dgv_AgendaMensal.TabIndex = 28;
            this.dgv_AgendaMensal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AgendaMensal_CellContentClick);
            // 
            // monthCalendar_Consultas
            // 
            this.monthCalendar_Consultas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar_Consultas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar_Consultas.Location = new System.Drawing.Point(914, 59);
            this.monthCalendar_Consultas.Margin = new System.Windows.Forms.Padding(50);
            this.monthCalendar_Consultas.Name = "monthCalendar_Consultas";
            this.monthCalendar_Consultas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar_Consultas.ShowTodayCircle = false;
            this.monthCalendar_Consultas.TabIndex = 20;
            this.monthCalendar_Consultas.TitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.monthCalendar_Consultas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_Consultas_DateChanged);
            // 
            // cmb_Mes
            // 
            this.cmb_Mes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Mes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mes.ForeColor = System.Drawing.SystemColors.Window;
            this.cmb_Mes.FormattingEnabled = true;
            this.cmb_Mes.Location = new System.Drawing.Point(59, 306);
            this.cmb_Mes.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Mes.Name = "cmb_Mes";
            this.cmb_Mes.Size = new System.Drawing.Size(186, 30);
            this.cmb_Mes.TabIndex = 24;
            this.cmb_Mes.SelectionChangeCommitted += new System.EventHandler(this.cmb_Mes_SelectionChangeCommitted);
            // 
            // btn_AgendarServico
            // 
            this.btn_AgendarServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AgendarServico.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AgendarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgendarServico.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_AgendarServico.FlatAppearance.BorderSize = 2;
            this.btn_AgendarServico.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_AgendarServico.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_AgendarServico.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_AgendarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgendarServico.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_AgendarServico.Location = new System.Drawing.Point(914, 375);
            this.btn_AgendarServico.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgendarServico.Name = "btn_AgendarServico";
            this.btn_AgendarServico.Size = new System.Drawing.Size(227, 40);
            this.btn_AgendarServico.TabIndex = 22;
            this.btn_AgendarServico.Text = "Agendar Serviço";
            this.btn_AgendarServico.UseVisualStyleBackColor = false;
            this.btn_AgendarServico.Click += new System.EventHandler(this.btn_AgendarServico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(55, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Agenda Mensal";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancelar.FlatAppearance.BorderSize = 2;
            this.btn_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Cancelar.Location = new System.Drawing.Point(914, 423);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(227, 40);
            this.btn_Cancelar.TabIndex = 38;
            this.btn_Cancelar.Text = "Cancelar Agendamento";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 43);
            this.panel1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1200, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Agendamentos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(909, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Animal: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(909, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Vet.:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(909, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Cli.:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(909, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Data/Hora: ";
            // 
            // lbl_ValorAnimal
            // 
            this.lbl_ValorAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValorAnimal.AutoSize = true;
            this.lbl_ValorAnimal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorAnimal.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_ValorAnimal.Location = new System.Drawing.Point(992, 235);
            this.lbl_ValorAnimal.Name = "lbl_ValorAnimal";
            this.lbl_ValorAnimal.Size = new System.Drawing.Size(12, 18);
            this.lbl_ValorAnimal.TabIndex = 46;
            this.lbl_ValorAnimal.Text = ".";
            // 
            // lbl_ValorVeterinario
            // 
            this.lbl_ValorVeterinario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValorVeterinario.AutoSize = true;
            this.lbl_ValorVeterinario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorVeterinario.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_ValorVeterinario.Location = new System.Drawing.Point(957, 274);
            this.lbl_ValorVeterinario.Name = "lbl_ValorVeterinario";
            this.lbl_ValorVeterinario.Size = new System.Drawing.Size(12, 18);
            this.lbl_ValorVeterinario.TabIndex = 47;
            this.lbl_ValorVeterinario.Text = ".";
            // 
            // lbl_ValorCliente
            // 
            this.lbl_ValorCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValorCliente.AutoSize = true;
            this.lbl_ValorCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_ValorCliente.Location = new System.Drawing.Point(957, 313);
            this.lbl_ValorCliente.Name = "lbl_ValorCliente";
            this.lbl_ValorCliente.Size = new System.Drawing.Size(12, 18);
            this.lbl_ValorCliente.TabIndex = 48;
            this.lbl_ValorCliente.Text = ".";
            // 
            // lbl_ValorDataHora
            // 
            this.lbl_ValorDataHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValorDataHora.AutoSize = true;
            this.lbl_ValorDataHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorDataHora.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_ValorDataHora.Location = new System.Drawing.Point(1019, 353);
            this.lbl_ValorDataHora.Name = "lbl_ValorDataHora";
            this.lbl_ValorDataHora.Size = new System.Drawing.Size(12, 18);
            this.lbl_ValorDataHora.TabIndex = 49;
            this.lbl_ValorDataHora.Text = ".";
            // 
            // btn_Concluir
            // 
            this.btn_Concluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Concluir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Concluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Concluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Concluir.FlatAppearance.BorderSize = 2;
            this.btn_Concluir.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Concluir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Concluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Concluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Concluir.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Concluir.Location = new System.Drawing.Point(914, 471);
            this.btn_Concluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Concluir.Name = "btn_Concluir";
            this.btn_Concluir.Size = new System.Drawing.Size(227, 40);
            this.btn_Concluir.TabIndex = 50;
            this.btn_Concluir.Text = "Concluído";
            this.btn_Concluir.UseVisualStyleBackColor = false;
            this.btn_Concluir.Click += new System.EventHandler(this.btn_Concluir_Click);
            // 
            // F_Agendamento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btn_Concluir);
            this.Controls.Add(this.lbl_ValorDataHora);
            this.Controls.Add(this.lbl_ValorCliente);
            this.Controls.Add(this.lbl_ValorVeterinario);
            this.Controls.Add(this.lbl_ValorAnimal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.monthCalendar_Consultas);
            this.Controls.Add(this.dgv_AgendaMensal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Mes);
            this.Controls.Add(this.dgv_AgendaDiaria);
            this.Controls.Add(this.btn_AgendarServico);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "F_Agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AgendaDiaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AgendaMensal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_AgendaDiaria;
        private System.Windows.Forms.DataGridView dgv_AgendaMensal;
        private System.Windows.Forms.MonthCalendar monthCalendar_Consultas;
        private System.Windows.Forms.ComboBox cmb_Mes;
        private System.Windows.Forms.Button btn_AgendarServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_ValorAnimal;
        private System.Windows.Forms.Label lbl_ValorVeterinario;
        private System.Windows.Forms.Label lbl_ValorCliente;
        private System.Windows.Forms.Label lbl_ValorDataHora;
        private System.Windows.Forms.Button btn_Concluir;
    }
}