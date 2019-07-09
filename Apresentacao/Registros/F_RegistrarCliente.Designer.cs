namespace Apresentacao.Registros
{
    partial class F_RegistrarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NumeroCasa = new System.Windows.Forms.Label();
            this.txt_NumeroCasa = new System.Windows.Forms.TextBox();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_RG = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_RG = new System.Windows.Forms.Label();
            this.lbl_DataNascimento = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_RegistrarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 993);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(191, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "(dia/mês/ano)";
            // 
            // lbl_NumeroCasa
            // 
            this.lbl_NumeroCasa.AutoSize = true;
            this.lbl_NumeroCasa.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_NumeroCasa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroCasa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_NumeroCasa.Location = new System.Drawing.Point(346, 136);
            this.lbl_NumeroCasa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_NumeroCasa.Name = "lbl_NumeroCasa";
            this.lbl_NumeroCasa.Size = new System.Drawing.Size(143, 24);
            this.lbl_NumeroCasa.TabIndex = 15;
            this.lbl_NumeroCasa.Text = "Nº Residência";
            // 
            // txt_NumeroCasa
            // 
            this.txt_NumeroCasa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NumeroCasa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumeroCasa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_NumeroCasa.Location = new System.Drawing.Point(350, 166);
            this.txt_NumeroCasa.Margin = new System.Windows.Forms.Padding(6);
            this.txt_NumeroCasa.Name = "txt_NumeroCasa";
            this.txt_NumeroCasa.Size = new System.Drawing.Size(134, 32);
            this.txt_NumeroCasa.TabIndex = 16;
            this.txt_NumeroCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txt_Estado
            // 
            this.txt_Estado.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Estado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Estado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Estado.Location = new System.Drawing.Point(350, 370);
            this.txt_Estado.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(411, 32);
            this.txt_Estado.TabIndex = 22;
            // 
            // txt_DataNascimento
            // 
            this.txt_DataNascimento.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DataNascimento.Culture = new System.Globalization.CultureInfo("");
            this.txt_DataNascimento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataNascimento.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_DataNascimento.Location = new System.Drawing.Point(14, 302);
            this.txt_DataNascimento.Margin = new System.Windows.Forms.Padding(6);
            this.txt_DataNascimento.Mask = "00/00/0000";
            this.txt_DataNascimento.Name = "txt_DataNascimento";
            this.txt_DataNascimento.PromptChar = '0';
            this.txt_DataNascimento.ResetOnPrompt = false;
            this.txt_DataNascimento.Size = new System.Drawing.Size(165, 32);
            this.txt_DataNascimento.TabIndex = 8;
            this.txt_DataNascimento.ValidatingType = typeof(System.DateTime);
            this.txt_DataNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Cidade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cidade.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Cidade.Location = new System.Drawing.Point(350, 302);
            this.txt_Cidade.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(411, 32);
            this.txt_Cidade.TabIndex = 20;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Bairro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bairro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Bairro.Location = new System.Drawing.Point(350, 234);
            this.txt_Bairro.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(411, 32);
            this.txt_Bairro.TabIndex = 18;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Endereco.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Endereco.Location = new System.Drawing.Point(350, 98);
            this.txt_Endereco.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(411, 32);
            this.txt_Endereco.TabIndex = 14;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Telefone.Culture = new System.Globalization.CultureInfo("");
            this.txt_Telefone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Telefone.Location = new System.Drawing.Point(14, 438);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Telefone.Mask = "(00)0000-0000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.PromptChar = '0';
            this.txt_Telefone.ResetOnPrompt = false;
            this.txt_Telefone.Size = new System.Drawing.Size(165, 32);
            this.txt_Telefone.TabIndex = 12;
            this.txt_Telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txt_Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txt_Celular
            // 
            this.txt_Celular.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Celular.Culture = new System.Globalization.CultureInfo("");
            this.txt_Celular.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Celular.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Celular.Location = new System.Drawing.Point(15, 370);
            this.txt_Celular.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Celular.Mask = "(00)00000-0000";
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.PromptChar = '0';
            this.txt_Celular.ResetOnPrompt = false;
            this.txt_Celular.Size = new System.Drawing.Size(164, 32);
            this.txt_Celular.TabIndex = 10;
            this.txt_Celular.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txt_Celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txt_RG
            // 
            this.txt_RG.BackColor = System.Drawing.SystemColors.Window;
            this.txt_RG.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RG.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_RG.Location = new System.Drawing.Point(15, 234);
            this.txt_RG.Margin = new System.Windows.Forms.Padding(6);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(165, 32);
            this.txt_RG.TabIndex = 6;
            this.txt_RG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Nome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Nome.Location = new System.Drawing.Point(15, 98);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(323, 32);
            this.txt_Nome.TabIndex = 2;
            // 
            // txt_CPF
            // 
            this.txt_CPF.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CPF.Culture = new System.Globalization.CultureInfo("");
            this.txt_CPF.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CPF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_CPF.Location = new System.Drawing.Point(15, 166);
            this.txt_CPF.Margin = new System.Windows.Forms.Padding(6);
            this.txt_CPF.Mask = "000.000.000-00";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.PromptChar = '0';
            this.txt_CPF.ResetOnPrompt = false;
            this.txt_CPF.Size = new System.Drawing.Size(165, 32);
            this.txt_CPF.TabIndex = 4;
            this.txt_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Estado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Estado.Location = new System.Drawing.Point(346, 340);
            this.lbl_Estado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(76, 24);
            this.lbl_Estado.TabIndex = 21;
            this.lbl_Estado.Text = "Estado";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Cidade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cidade.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Cidade.Location = new System.Drawing.Point(346, 272);
            this.lbl_Cidade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(76, 24);
            this.lbl_Cidade.TabIndex = 19;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Bairro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bairro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Bairro.Location = new System.Drawing.Point(346, 204);
            this.lbl_Bairro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(67, 24);
            this.lbl_Bairro.TabIndex = 17;
            this.lbl_Bairro.Text = "Bairro";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Endereco.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereco.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Endereco.Location = new System.Drawing.Point(346, 68);
            this.lbl_Endereco.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(230, 24);
            this.lbl_Endereco.TabIndex = 13;
            this.lbl_Endereco.Text = "Endereco(rua, avenida)";
            // 
            // lbl_Celular
            // 
            this.lbl_Celular.AutoSize = true;
            this.lbl_Celular.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Celular.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Celular.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Celular.Location = new System.Drawing.Point(10, 341);
            this.lbl_Celular.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Celular.Name = "lbl_Celular";
            this.lbl_Celular.Size = new System.Drawing.Size(75, 24);
            this.lbl_Celular.TabIndex = 9;
            this.lbl_Celular.Text = "Celular";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Telefone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Telefone.Location = new System.Drawing.Point(11, 408);
            this.lbl_Telefone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(89, 24);
            this.lbl_Telefone.TabIndex = 11;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_RG
            // 
            this.lbl_RG.AutoSize = true;
            this.lbl_RG.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_RG.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RG.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_RG.Location = new System.Drawing.Point(11, 204);
            this.lbl_RG.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_RG.Name = "lbl_RG";
            this.lbl_RG.Size = new System.Drawing.Size(41, 24);
            this.lbl_RG.TabIndex = 5;
            this.lbl_RG.Text = "RG";
            // 
            // lbl_DataNascimento
            // 
            this.lbl_DataNascimento.AutoSize = true;
            this.lbl_DataNascimento.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_DataNascimento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataNascimento.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_DataNascimento.Location = new System.Drawing.Point(11, 273);
            this.lbl_DataNascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_DataNascimento.Name = "lbl_DataNascimento";
            this.lbl_DataNascimento.Size = new System.Drawing.Size(200, 24);
            this.lbl_DataNascimento.TabIndex = 7;
            this.lbl_DataNascimento.Text = "Data de Nascimento";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_CPF.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_CPF.Location = new System.Drawing.Point(10, 136);
            this.lbl_CPF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(52, 24);
            this.lbl_CPF.TabIndex = 3;
            this.lbl_CPF.Text = "CPF";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Nome.Location = new System.Drawing.Point(11, 68);
            this.lbl_Nome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(158, 24);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome Completo";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Fechar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Fechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_Fechar.FlatAppearance.BorderSize = 2;
            this.btn_Fechar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.Location = new System.Drawing.Point(15, 545);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(200, 40);
            this.btn_Fechar.TabIndex = 23;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_RegistrarCliente
            // 
            this.btn_RegistrarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RegistrarCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RegistrarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RegistrarCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_RegistrarCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btn_RegistrarCliente.FlatAppearance.BorderSize = 2;
            this.btn_RegistrarCliente.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_RegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistrarCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_RegistrarCliente.Location = new System.Drawing.Point(585, 545);
            this.btn_RegistrarCliente.Margin = new System.Windows.Forms.Padding(6);
            this.btn_RegistrarCliente.Name = "btn_RegistrarCliente";
            this.btn_RegistrarCliente.Size = new System.Drawing.Size(200, 40);
            this.btn_RegistrarCliente.TabIndex = 24;
            this.btn_RegistrarCliente.Text = "Registrar";
            this.btn_RegistrarCliente.UseVisualStyleBackColor = false;
            this.btn_RegistrarCliente.Click += new System.EventHandler(this.btn_RegistrarCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registrar Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_NumeroCasa);
            this.Controls.Add(this.txt_NumeroCasa);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.txt_DataNascimento);
            this.Controls.Add(this.btn_RegistrarCliente);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.txt_RG);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.lbl_Bairro);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_Celular);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_RG);
            this.Controls.Add(this.lbl_DataNascimento);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_Nome);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "F_RegistrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_RegistrarCliente";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_NumeroCasa;
        private System.Windows.Forms.TextBox txt_NumeroCasa;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.MaskedTextBox txt_DataNascimento;
        private System.Windows.Forms.Button btn_RegistrarCliente;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.MaskedTextBox txt_Celular;
        private System.Windows.Forms.TextBox txt_RG;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Celular;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_RG;
        private System.Windows.Forms.Label lbl_DataNascimento;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}