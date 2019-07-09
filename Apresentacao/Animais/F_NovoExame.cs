using Modelo;
using Servico;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Animais
{
    public partial class F_NovoExame : Form
    {
        Animal animal;
        ExameAnimalServico exameAnimalServico = new ExameAnimalServico();

        public F_NovoExame(Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
            txt_Animal.Text = animal.Nome;
            txt_Proprietario.Text = animal.Cliente.Nome;
            txt_Animal.ReadOnly = true;
            txt_Proprietario.ReadOnly = true;
            CarregarExames();
            ShowDialog();
        }

        private void CarregarExames()
        {
            var produtoServico = new ProdutoServico();
            var exames = from e in produtoServico.BuscarPorTipo("Exame")
                         select new
                         {
                             Exame = e.Nome
                         };
            cmb_Exame.DataSource = exames.ToList();
            cmb_Exame.ValueMember = "Exame";
            cmb_Exame.DisplayMember = "Exame";
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new F_Confirmacao("Registrar Exame?").Acao;
                if (op == AcaoConfirmacao.Sim)
                {
                    exameAnimalServico.Registrar(new ExameAnimal
                    {
                        DataColeta = DateTime.Parse(txt_DataColeta.Text),
                        DataResultado = DateTime.Parse(txt_DataResultado.Text),
                        AnimalID = animal.AnimalID,
                        Laudo = txt_Laudo.Text,
                        Resultado = txt_Resultado.Text,
                        NomeExame = cmb_Exame.SelectedValue.ToString(),
                        Laboratorio = txt_Laboratorio.Text
                    });
                    new F_TelaDeMensagem("Exame Registrado!");
                    Close();
                }
            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
