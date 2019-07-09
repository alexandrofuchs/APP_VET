using Apresentacao.Consultas;
using Modelo;
using System;
using System.Windows.Forms;

namespace Apresentacao.Animais
{
    public partial class F_PaginaAnimal : F_AbrirForm
    {
        Animal animal;
        Form f_Atual;
        public F_PaginaAnimal(F_Principal f_Principal, Animal animal) : base(f_Principal)
        {
            InitializeComponent();
            this.animal = animal;
            CarregarDados();            
        }

        public void AbrirForm(Form form)
        {
            f_Atual?.Close();
            f_Atual = form;
            f_Atual.TopLevel = false;
            f_Atual.FormBorderStyle = FormBorderStyle.None;
            f_Atual.Dock = DockStyle.Fill;
            pnl_Animal.Controls.Add(f_Atual);
            f_Atual.Show();
        }


        private void CarregarDados()
        {
            lbl_ValorNomeAnimal.Text = animal.Nome;
            lbl_ValorNomeProprietario.Text = animal.Cliente.Nome;
            lbl_ValorDataRegistro.Text = animal.DataRegistro.ToShortDateString();            
        }

        private void btn_NovaConsulta_Click(object sender, EventArgs e)
        {
            f_Principal.AbrirForm(new F_RegistrarConsulta(f_Principal, animal));
        }

        private void btn_ResumoConsultas_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_ConsultasAnimal(this, animal));
        }

        private void btn_Dados_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_DadosAnimal(animal));
        }

        private void btn_Exames_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_ExamesAnimal(f_Principal, animal));
        }
    }
}
