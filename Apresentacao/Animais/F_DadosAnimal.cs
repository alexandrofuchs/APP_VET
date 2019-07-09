using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Apresentacao.Animais
{
    public partial class F_DadosAnimal : Form
    {
        AnimalServico animalServico = new AnimalServico();
        Animal animal;

        public F_DadosAnimal(Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
            CarregarDados();
        }

        private void CarregarDados()
        {
            txt_NomeAnimal.Text = animal.Nome;
            txt_Especie.Text = animal.Especie;
            txt_Raca.Text = animal.Raca;
            txt_Peso.Text = animal.Peso.ToString();
            txt_Pelagem.Text = animal.Pelagem;
            txt_Idade.Text = animal.Idade.ToString();
            cmb_Sexo.DataSource = new List<string> { "Macho", "Femea" };
            lbl_ValorProprietario.Text = animal.Cliente.Nome;
        }

        private void btn_AtualizarDados_Click(object sender, EventArgs e)
        {
            try
            {
                var a = animalServico.BuscarPorID(animal.AnimalID);
                a.Nome = txt_NomeAnimal.Text;
                a.Especie = txt_Especie.Text;
                a.Raca = txt_Raca.Text;
                a.Peso = double.Parse(txt_Peso.Text);
                a.Sexo = cmb_Sexo.SelectedValue.ToString();
                a.Pelagem = txt_Pelagem.Text;
                a.Idade = double.Parse(txt_Idade.Value.ToString());
                animalServico.Atualizar(a);
                new F_TelaDeMensagem("Atualizado");
            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }
        }

        private void txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                if (!(e.KeyChar.Equals(',')))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
