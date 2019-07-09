using Apresentacao.Agendamentos;
using Apresentacao.Registros;
using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Buscas
{
    public partial class F_BuscarAnimal : Form
    {
        AnimalServico animalServico = new AnimalServico();
        Form form;

        public F_BuscarAnimal(Form form)
        {
            InitializeComponent();
            this.form = form;
            txt_DadoBusca.Visible = false;
            btn_Buscar.Visible = false;
            lbl_DadoBusca.Visible = false;
            CarregarComboBox();
            CarregarAnimais();
            ShowDialog();
        }

        private void CarregarAnimais()
        {
            var animais = from a in animalServico.BuscarTodos()
                          select new
                          {
                              ID = a.AnimalID,
                              a.Nome,
                              Espécie = a.Especie,
                              Raça = a.Raca,
                              Proprietário = a.Cliente.Nome
                          };
            dgv_Animais.DataSource = animais.ToList();
            dgv_Animais.Columns["ID"].Visible = false;
        }

        private void CarregarComboBox()
        {
            var buscarpor = new List<string>
            {
                "Todos",
                "Nome do Animal",
                "Nome do Proprietário"
            };
            cmb_BuscarPor.DataSource = buscarpor;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

            if (cmb_BuscarPor.SelectedValue.ToString().Equals("Nome do Animal"))
            {
                var animais = from a in animalServico.BuscarPorNome(txt_DadoBusca.Text)
                              select new
                              {
                                  ID = a.AnimalID,
                                  a.Nome,
                                  Espécie = a.Especie,
                                  Raça = a.Raca,
                                  Proprietário = a.Cliente.Nome     
                              };
                dgv_Animais.DataSource = animais.ToList();

            }
            if (cmb_BuscarPor.SelectedValue.ToString().Equals("Nome do Proprietário"))
            {
                var animais = from a in animalServico.BuscarPorNomeProprietario(txt_DadoBusca.Text)
                              select new
                              {
                                  ID = a.AnimalID,
                                  a.Nome,
                                  Espécie = a.Especie,
                                  Raça = a.Raca,
                                  Proprietário = a.Cliente.Nome
                              };
                dgv_Animais.DataSource = animais.ToList();
            }         
            if(cmb_BuscarPor.SelectedValue.ToString().Equals("Todos"))
            {
                CarregarAnimais();
            }
            dgv_Animais.Columns["ID"].Visible = false;
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                var linha = dgv_Animais.CurrentRow.Index;
                long id = long.Parse(dgv_Animais["ID", linha].Value.ToString());
                var animal = animalServico.BuscarPorID(id);
                
                if( form is F_AbrirAtendimento)
                {
                    var f = form as F_AbrirAtendimento;
                    f.GetAnimal(animal);
                }
                
                if( form is F_AgendarServico)
                {
                    var f = form as F_AgendarServico;
                    f.GetAnimal(animal);
                }
                Close();
            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }
        }

        private void cmb_BuscarPor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if( cmb_BuscarPor.SelectedIndex == 0)
            {
                lbl_DadoBusca.Visible = false;
                txt_DadoBusca.Visible = false;
                btn_Buscar.Visible = false;
            }
            else
            {
                lbl_DadoBusca.Visible = true;
                txt_DadoBusca.Visible = true;
                btn_Buscar.Visible = true;
            }
            
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
