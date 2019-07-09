namespace Apresentacao.Registros
{
    partial class F_RegistrarAtendimento
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
            this.dgv_ProdutosServicos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BuscarProduto = new System.Windows.Forms.TextBox();
            this.btn_BuscarProduto = new System.Windows.Forms.Button();
            this.cmb_ClassificarPor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_ProdutosAdicionados = new System.Windows.Forms.DataGridView();
            this.lbl_Animal = new System.Windows.Forms.Label();
            this.lbl_Proprietario = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.lbl_TotalExames = new System.Windows.Forms.Label();
            this.lbl_TotalServicos = new System.Windows.Forms.Label();
            this.lbl_TotalMedicamentos = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_ValorTotalExames = new System.Windows.Forms.Label();
            this.lbl_ValorTotalServicos = new System.Windows.Forms.Label();
            this.lbl_ValorTotalMedicamentos = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.lbl_ValorTotal = new System.Windows.Forms.Label();
            this.lbl_ValorAnimal = new System.Windows.Forms.Label();
            this.lbl_ValorProprietario = new System.Windows.Forms.Label();
            this.lbl_ValorCPF = new System.Windows.Forms.Label();
            this.lbl_ValorTelefone = new System.Windows.Forms.Label();
            this.lbl_ValorCelular = new System.Windows.Forms.Label();
            this.btn_AdicionarProduto = new System.Windows.Forms.Button();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.btn_RemoverProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DiasVencimento = new System.Windows.Forms.NumericUpDown();
            this.cb_Pago = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.lbl_TotalOutrosProdutos = new System.Windows.Forms.Label();
            this.lbl_ValorTotalOutros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutosServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutosAdicionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiasVencimento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ProdutosServicos
            // 
            this.dgv_ProdutosServicos.AllowUserToAddRows = false;
            this.dgv_ProdutosServicos.AllowUserToDeleteRows = false;
            this.dgv_ProdutosServicos.AllowUserToResizeColumns = false;
            this.dgv_ProdutosServicos.AllowUserToResizeRows = false;
            this.dgv_ProdutosServicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_ProdutosServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProdutosServicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ProdutosServicos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ProdutosServicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProdutosServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProdutosServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProdutosServicos.EnableHeadersVisualStyles = false;
            this.dgv_ProdutosServicos.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_ProdutosServicos.Location = new System.Drawing.Point(647, 181);
            this.dgv_ProdutosServicos.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgv_ProdutosServicos.MultiSelect = false;
            this.dgv_ProdutosServicos.Name = "dgv_ProdutosServicos";
            this.dgv_ProdutosServicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ProdutosServicos.RowHeadersVisible = false;
            this.dgv_ProdutosServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProdutosServicos.Size = new System.Drawing.Size(543, 205);
            this.dgv_ProdutosServicos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(587, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produtos/Serviços";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(643, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar Produto: ";
            // 
            // txt_BuscarProduto
            // 
            this.txt_BuscarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_BuscarProduto.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarProduto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_BuscarProduto.Location = new System.Drawing.Point(796, 88);
            this.txt_BuscarProduto.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txt_BuscarProduto.Name = "txt_BuscarProduto";
            this.txt_BuscarProduto.Size = new System.Drawing.Size(255, 35);
            this.txt_BuscarProduto.TabIndex = 3;
            // 
            // btn_BuscarProduto
            // 
            this.btn_BuscarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BuscarProduto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BuscarProduto.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarProduto.FlatAppearance.BorderSize = 2;
            this.btn_BuscarProduto.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_BuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_BuscarProduto.Location = new System.Drawing.Point(1053, 85);
            this.btn_BuscarProduto.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_BuscarProduto.Name = "btn_BuscarProduto";
            this.btn_BuscarProduto.Size = new System.Drawing.Size(100, 40);
            this.btn_BuscarProduto.TabIndex = 4;
            this.btn_BuscarProduto.Text = "Buscar";
            this.btn_BuscarProduto.UseVisualStyleBackColor = false;
            this.btn_BuscarProduto.Click += new System.EventHandler(this.btn_BuscarProduto_Click);
            // 
            // cmb_ClassificarPor
            // 
            this.cmb_ClassificarPor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_ClassificarPor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmb_ClassificarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ClassificarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ClassificarPor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ClassificarPor.ForeColor = System.Drawing.SystemColors.Window;
            this.cmb_ClassificarPor.FormattingEnabled = true;
            this.cmb_ClassificarPor.Location = new System.Drawing.Point(934, 142);
            this.cmb_ClassificarPor.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmb_ClassificarPor.Name = "cmb_ClassificarPor";
            this.cmb_ClassificarPor.Size = new System.Drawing.Size(255, 35);
            this.cmb_ClassificarPor.TabIndex = 6;
            this.cmb_ClassificarPor.SelectionChangeCommitted += new System.EventHandler(this.cmb_ClassificarPor_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(643, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Classificar Por: ";
            // 
            // dgv_ProdutosAdicionados
            // 
            this.dgv_ProdutosAdicionados.AllowUserToAddRows = false;
            this.dgv_ProdutosAdicionados.AllowUserToDeleteRows = false;
            this.dgv_ProdutosAdicionados.AllowUserToResizeColumns = false;
            this.dgv_ProdutosAdicionados.AllowUserToResizeRows = false;
            this.dgv_ProdutosAdicionados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_ProdutosAdicionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProdutosAdicionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ProdutosAdicionados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ProdutosAdicionados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProdutosAdicionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ProdutosAdicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProdutosAdicionados.EnableHeadersVisualStyles = false;
            this.dgv_ProdutosAdicionados.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_ProdutosAdicionados.Location = new System.Drawing.Point(10, 181);
            this.dgv_ProdutosAdicionados.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgv_ProdutosAdicionados.MultiSelect = false;
            this.dgv_ProdutosAdicionados.Name = "dgv_ProdutosAdicionados";
            this.dgv_ProdutosAdicionados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ProdutosAdicionados.RowHeadersVisible = false;
            this.dgv_ProdutosAdicionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProdutosAdicionados.Size = new System.Drawing.Size(620, 205);
            this.dgv_ProdutosAdicionados.TabIndex = 8;
            // 
            // lbl_Animal
            // 
            this.lbl_Animal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Animal.AutoSize = true;
            this.lbl_Animal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Animal.Location = new System.Drawing.Point(6, 52);
            this.lbl_Animal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Animal.Name = "lbl_Animal";
            this.lbl_Animal.Size = new System.Drawing.Size(77, 22);
            this.lbl_Animal.TabIndex = 9;
            this.lbl_Animal.Text = "Animal: ";
            // 
            // lbl_Proprietario
            // 
            this.lbl_Proprietario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Proprietario.AutoSize = true;
            this.lbl_Proprietario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Proprietario.Location = new System.Drawing.Point(4, 84);
            this.lbl_Proprietario.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Proprietario.Name = "lbl_Proprietario";
            this.lbl_Proprietario.Size = new System.Drawing.Size(123, 22);
            this.lbl_Proprietario.TabIndex = 10;
            this.lbl_Proprietario.Text = "Proprietário:  ";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_CPF.Location = new System.Drawing.Point(4, 118);
            this.lbl_CPF.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(59, 22);
            this.lbl_CPF.TabIndex = 11;
            this.lbl_CPF.Text = "CPF: ";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Telefone.Location = new System.Drawing.Point(318, 84);
            this.lbl_Telefone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(99, 22);
            this.lbl_Telefone.TabIndex = 12;
            this.lbl_Telefone.Text = "Telefone:  ";
            // 
            // lbl_Celular
            // 
            this.lbl_Celular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Celular.AutoSize = true;
            this.lbl_Celular.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Celular.Location = new System.Drawing.Point(318, 52);
            this.lbl_Celular.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Celular.Name = "lbl_Celular";
            this.lbl_Celular.Size = new System.Drawing.Size(84, 22);
            this.lbl_Celular.TabIndex = 13;
            this.lbl_Celular.Text = "Celular:  ";
            // 
            // lbl_TotalExames
            // 
            this.lbl_TotalExames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TotalExames.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_TotalExames.Location = new System.Drawing.Point(6, 399);
            this.lbl_TotalExames.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_TotalExames.Name = "lbl_TotalExames";
            this.lbl_TotalExames.Size = new System.Drawing.Size(144, 22);
            this.lbl_TotalExames.TabIndex = 14;
            this.lbl_TotalExames.Text = "Total Exames:   ";
            // 
            // lbl_TotalServicos
            // 
            this.lbl_TotalServicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TotalServicos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_TotalServicos.Location = new System.Drawing.Point(6, 434);
            this.lbl_TotalServicos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_TotalServicos.Name = "lbl_TotalServicos";
            this.lbl_TotalServicos.Size = new System.Drawing.Size(139, 22);
            this.lbl_TotalServicos.TabIndex = 15;
            this.lbl_TotalServicos.Text = "Total Serviços: ";
            // 
            // lbl_TotalMedicamentos
            // 
            this.lbl_TotalMedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TotalMedicamentos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_TotalMedicamentos.Location = new System.Drawing.Point(6, 470);
            this.lbl_TotalMedicamentos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_TotalMedicamentos.Name = "lbl_TotalMedicamentos";
            this.lbl_TotalMedicamentos.Size = new System.Drawing.Size(184, 22);
            this.lbl_TotalMedicamentos.TabIndex = 16;
            this.lbl_TotalMedicamentos.Text = "Total Medicamentos:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Total.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Total.Location = new System.Drawing.Point(3, 553);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(107, 44);
            this.lbl_Total.TabIndex = 17;
            this.lbl_Total.Text = "Total: ";
            // 
            // lbl_ValorTotalExames
            // 
            this.lbl_ValorTotalExames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ValorTotalExames.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorTotalExames.Location = new System.Drawing.Point(146, 399);
            this.lbl_ValorTotalExames.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ValorTotalExames.Name = "lbl_ValorTotalExames";
            this.lbl_ValorTotalExames.Size = new System.Drawing.Size(291, 22);
            this.lbl_ValorTotalExames.TabIndex = 18;
            this.lbl_ValorTotalExames.Text = "<<valor>>  ";
            this.lbl_ValorTotalExames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ValorTotalServicos
            // 
            this.lbl_ValorTotalServicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ValorTotalServicos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorTotalServicos.Location = new System.Drawing.Point(151, 434);
            this.lbl_ValorTotalServicos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ValorTotalServicos.Name = "lbl_ValorTotalServicos";
            this.lbl_ValorTotalServicos.Size = new System.Drawing.Size(286, 22);
            this.lbl_ValorTotalServicos.TabIndex = 19;
            this.lbl_ValorTotalServicos.Text = "<<valor>>  ";
            this.lbl_ValorTotalServicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ValorTotalMedicamentos
            // 
            this.lbl_ValorTotalMedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ValorTotalMedicamentos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorTotalMedicamentos.Location = new System.Drawing.Point(197, 470);
            this.lbl_ValorTotalMedicamentos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ValorTotalMedicamentos.Name = "lbl_ValorTotalMedicamentos";
            this.lbl_ValorTotalMedicamentos.Size = new System.Drawing.Size(240, 22);
            this.lbl_ValorTotalMedicamentos.TabIndex = 20;
            this.lbl_ValorTotalMedicamentos.Text = "<<valor>>  ";
            this.lbl_ValorTotalMedicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Registrar.BackColor = System.Drawing.Color.Green;
            this.btn_Registrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Registrar.FlatAppearance.BorderSize = 2;
            this.btn_Registrar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Registrar.Location = new System.Drawing.Point(1004, 638);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(185, 49);
            this.btn_Registrar.TabIndex = 21;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // lbl_ValorTotal
            // 
            this.lbl_ValorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ValorTotal.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorTotal.Location = new System.Drawing.Point(255, 538);
            this.lbl_ValorTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ValorTotal.Name = "lbl_ValorTotal";
            this.lbl_ValorTotal.Size = new System.Drawing.Size(590, 59);
            this.lbl_ValorTotal.TabIndex = 22;
            this.lbl_ValorTotal.Text = "<<valor>>  ";
            this.lbl_ValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ValorAnimal
            // 
            this.lbl_ValorAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ValorAnimal.AutoSize = true;
            this.lbl_ValorAnimal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorAnimal.Location = new System.Drawing.Point(129, 52);
            this.lbl_ValorAnimal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ValorAnimal.Name = "lbl_ValorAnimal";
            this.lbl_ValorAnimal.Size = new System.Drawing.Size(104, 22);
            this.lbl_ValorAnimal.TabIndex = 23;
            this.lbl_ValorAnimal.Text = "<<valor>>  ";
            // 
            // lbl_ValorProprietario
            // 
            this.lbl_ValorProprietario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ValorProprietario.AutoSize = true;
            this.lbl_ValorProprietario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorProprietario.Location = new System.Drawing.Point(129, 84);
            this.lbl_ValorProprietario.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ValorProprietario.Name = "lbl_ValorProprietario";
            this.lbl_ValorProprietario.Size = new System.Drawing.Size(104, 22);
            this.lbl_ValorProprietario.TabIndex = 24;
            this.lbl_ValorProprietario.Text = "<<valor>>  ";
            // 
            // lbl_ValorCPF
            // 
            this.lbl_ValorCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ValorCPF.AutoSize = true;
            this.lbl_ValorCPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorCPF.Location = new System.Drawing.Point(129, 115);
            this.lbl_ValorCPF.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ValorCPF.Name = "lbl_ValorCPF";
            this.lbl_ValorCPF.Size = new System.Drawing.Size(104, 22);
            this.lbl_ValorCPF.TabIndex = 25;
            this.lbl_ValorCPF.Text = "<<valor>>  ";
            // 
            // lbl_ValorTelefone
            // 
            this.lbl_ValorTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ValorTelefone.AutoSize = true;
            this.lbl_ValorTelefone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorTelefone.Location = new System.Drawing.Point(419, 84);
            this.lbl_ValorTelefone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ValorTelefone.Name = "lbl_ValorTelefone";
            this.lbl_ValorTelefone.Size = new System.Drawing.Size(104, 22);
            this.lbl_ValorTelefone.TabIndex = 26;
            this.lbl_ValorTelefone.Text = "<<valor>>  ";
            // 
            // lbl_ValorCelular
            // 
            this.lbl_ValorCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ValorCelular.AutoSize = true;
            this.lbl_ValorCelular.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorCelular.Location = new System.Drawing.Point(419, 52);
            this.lbl_ValorCelular.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ValorCelular.Name = "lbl_ValorCelular";
            this.lbl_ValorCelular.Size = new System.Drawing.Size(104, 22);
            this.lbl_ValorCelular.TabIndex = 27;
            this.lbl_ValorCelular.Text = "<<valor>>  ";
            // 
            // btn_AdicionarProduto
            // 
            this.btn_AdicionarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AdicionarProduto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AdicionarProduto.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_AdicionarProduto.FlatAppearance.BorderSize = 2;
            this.btn_AdicionarProduto.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_AdicionarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_AdicionarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_AdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdicionarProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_AdicionarProduto.Location = new System.Drawing.Point(1055, 391);
            this.btn_AdicionarProduto.Name = "btn_AdicionarProduto";
            this.btn_AdicionarProduto.Size = new System.Drawing.Size(133, 39);
            this.btn_AdicionarProduto.TabIndex = 28;
            this.btn_AdicionarProduto.Text = "Adicionar";
            this.btn_AdicionarProduto.UseVisualStyleBackColor = false;
            this.btn_AdicionarProduto.Click += new System.EventHandler(this.btn_AdicionarProduto_Click);
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Quantidade.Location = new System.Drawing.Point(812, 408);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(169, 22);
            this.lbl_Quantidade.TabIndex = 29;
            this.lbl_Quantidade.Text = "Quantidade(itens): ";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Quantidade.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Quantidade.Location = new System.Drawing.Point(987, 401);
            this.txt_Quantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(62, 29);
            this.txt_Quantidade.TabIndex = 30;
            this.txt_Quantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_RemoverProduto
            // 
            this.btn_RemoverProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_RemoverProduto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RemoverProduto.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_RemoverProduto.FlatAppearance.BorderSize = 2;
            this.btn_RemoverProduto.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_RemoverProduto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_RemoverProduto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_RemoverProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoverProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_RemoverProduto.Location = new System.Drawing.Point(497, 391);
            this.btn_RemoverProduto.Name = "btn_RemoverProduto";
            this.btn_RemoverProduto.Size = new System.Drawing.Size(133, 39);
            this.btn_RemoverProduto.TabIndex = 31;
            this.btn_RemoverProduto.Text = "Remover";
            this.btn_RemoverProduto.UseVisualStyleBackColor = false;
            this.btn_RemoverProduto.Click += new System.EventHandler(this.btn_RemoverProduto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(849, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "Dias Para Vencimento: ";
            // 
            // txt_DiasVencimento
            // 
            this.txt_DiasVencimento.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DiasVencimento.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiasVencimento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_DiasVencimento.Location = new System.Drawing.Point(1131, 559);
            this.txt_DiasVencimento.Name = "txt_DiasVencimento";
            this.txt_DiasVencimento.Size = new System.Drawing.Size(57, 35);
            this.txt_DiasVencimento.TabIndex = 34;
            this.txt_DiasVencimento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_Pago
            // 
            this.cb_Pago.AutoSize = true;
            this.cb_Pago.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Pago.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_Pago.FlatAppearance.BorderSize = 2;
            this.cb_Pago.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_Pago.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_Pago.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_Pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Pago.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Pago.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cb_Pago.Location = new System.Drawing.Point(854, 600);
            this.cb_Pago.Name = "cb_Pago";
            this.cb_Pago.Size = new System.Drawing.Size(334, 31);
            this.cb_Pago.TabIndex = 35;
            this.cb_Pago.Text = "Pago no Ato do Atendimento";
            this.cb_Pago.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1200, 40);
            this.label5.TabIndex = 36;
            this.label5.Text = "Registrar Atendimento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Fechar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Fechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Fechar.FlatAppearance.BorderSize = 2;
            this.btn_Fechar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.Location = new System.Drawing.Point(12, 638);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(185, 50);
            this.btn_Fechar.TabIndex = 37;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // lbl_TotalOutrosProdutos
            // 
            this.lbl_TotalOutrosProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TotalOutrosProdutos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_TotalOutrosProdutos.Location = new System.Drawing.Point(6, 512);
            this.lbl_TotalOutrosProdutos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_TotalOutrosProdutos.Name = "lbl_TotalOutrosProdutos";
            this.lbl_TotalOutrosProdutos.Size = new System.Drawing.Size(223, 22);
            this.lbl_TotalOutrosProdutos.TabIndex = 38;
            this.lbl_TotalOutrosProdutos.Text = "Total Outros:";
            // 
            // lbl_ValorTotalOutros
            // 
            this.lbl_ValorTotalOutros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ValorTotalOutros.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ValorTotalOutros.Location = new System.Drawing.Point(197, 506);
            this.lbl_ValorTotalOutros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ValorTotalOutros.Name = "lbl_ValorTotalOutros";
            this.lbl_ValorTotalOutros.Size = new System.Drawing.Size(240, 22);
            this.lbl_ValorTotalOutros.TabIndex = 39;
            this.lbl_ValorTotalOutros.Text = "<<valor>>  ";
            this.lbl_ValorTotalOutros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // F_RegistrarAtendimento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.lbl_ValorTotalOutros);
            this.Controls.Add(this.lbl_TotalOutrosProdutos);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Pago);
            this.Controls.Add(this.txt_DiasVencimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_RemoverProduto);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.btn_AdicionarProduto);
            this.Controls.Add(this.lbl_ValorCelular);
            this.Controls.Add(this.lbl_ValorTelefone);
            this.Controls.Add(this.lbl_ValorCPF);
            this.Controls.Add(this.lbl_ValorProprietario);
            this.Controls.Add(this.lbl_ValorAnimal);
            this.Controls.Add(this.lbl_ValorTotal);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.lbl_ValorTotalMedicamentos);
            this.Controls.Add(this.lbl_ValorTotalServicos);
            this.Controls.Add(this.lbl_ValorTotalExames);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_TotalMedicamentos);
            this.Controls.Add(this.lbl_TotalServicos);
            this.Controls.Add(this.lbl_TotalExames);
            this.Controls.Add(this.lbl_Celular);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_Proprietario);
            this.Controls.Add(this.lbl_Animal);
            this.Controls.Add(this.dgv_ProdutosAdicionados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_ClassificarPor);
            this.Controls.Add(this.btn_BuscarProduto);
            this.Controls.Add(this.txt_BuscarProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ProdutosServicos);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "F_RegistrarAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_RegistrarAtendimento";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutosServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutosAdicionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiasVencimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ProdutosServicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BuscarProduto;
        private System.Windows.Forms.Button btn_BuscarProduto;
        private System.Windows.Forms.ComboBox cmb_ClassificarPor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_ProdutosAdicionados;
        private System.Windows.Forms.Label lbl_Animal;
        private System.Windows.Forms.Label lbl_Proprietario;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Celular;
        private System.Windows.Forms.Label lbl_TotalExames;
        private System.Windows.Forms.Label lbl_TotalServicos;
        private System.Windows.Forms.Label lbl_TotalMedicamentos;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_ValorTotalExames;
        private System.Windows.Forms.Label lbl_ValorTotalServicos;
        private System.Windows.Forms.Label lbl_ValorTotalMedicamentos;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Label lbl_ValorTotal;
        private System.Windows.Forms.Label lbl_ValorAnimal;
        private System.Windows.Forms.Label lbl_ValorProprietario;
        private System.Windows.Forms.Label lbl_ValorCPF;
        private System.Windows.Forms.Label lbl_ValorTelefone;
        private System.Windows.Forms.Label lbl_ValorCelular;
        private System.Windows.Forms.Button btn_AdicionarProduto;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.NumericUpDown txt_Quantidade;
        private System.Windows.Forms.Button btn_RemoverProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txt_DiasVencimento;
        private System.Windows.Forms.CheckBox cb_Pago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label lbl_TotalOutrosProdutos;
        private System.Windows.Forms.Label lbl_ValorTotalOutros;
    }
}