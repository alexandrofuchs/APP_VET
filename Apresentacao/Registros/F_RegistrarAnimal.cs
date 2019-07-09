using Modelo;
using Servico;
using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Apresentacao.Registros
{
    public partial class F_RegistrarAnimal : Form
    {
        AnimalServico animalServico = new AnimalServico();

        long clienteID;
        string[] genero = new string[2] { "Macho", "Femea" };

        public F_RegistrarAnimal(long clienteID, string nome)
        {
            this.clienteID = clienteID;
            InitializeComponent();
            lbl_ValorProprietario.Text = nome;            
            cmb_Sexo.DataSource = genero;
            ShowDialog();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                animalServico.Registrar(new Animal()
                {
                    Nome = txt_NomeAnimal.Text,
                    ClienteID = clienteID,
                    Idade = Convert.ToInt32(txt_Idade.Value),
                    Pelagem = txt_Pelagem.Text,
                    Sexo = cmb_Sexo.SelectedValue.ToString(),
                    Especie = txt_Especie.Text,
                    Raca = txt_Raca.Text,
                    Peso = Convert.ToDouble(txt_Peso.Text)                    
                });
                new F_TelaDeMensagem("Registrado!");
                Close();
            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SomenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
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
