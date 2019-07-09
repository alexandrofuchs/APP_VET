using Apresentacao.Buscas;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Registros
{
    public partial class F_AbrirAtendimento : Form
    {
        Animal animal;
        

        public F_AbrirAtendimento()
        {
            InitializeComponent();
            ShowDialog();
        }

        private void btn_BuscarAnimal_Click(object sender, EventArgs e)
        {
            new F_BuscarAnimal(this);
        }

        public void GetAnimal(Animal animal)
        {
            this.animal = animal;
            txt_Animal.Text = animal.Nome;
            txt_Proprietario.Text = animal.Cliente.Nome;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if( animal is null)
            {
                new F_TelaDeMensagem("Animal não Relacionado");
            }
            else
            {
                new F_RegistrarAtendimento(animal);
                Close();
            }
        }

    }
}
