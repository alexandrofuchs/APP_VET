using Modelo;
using Servico;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Animais
{
    public partial class F_ExamesAnimal : F_AbrirForm
    {
        Animal animal;
        ExameAnimalServico exameAnimalServico = new ExameAnimalServico();

        public F_ExamesAnimal(F_Principal f_Principal, Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
            this.f_Principal = f_Principal;
            CarregarExames();
        }

        private void CarregarExames()
        {
            var exames = from e in exameAnimalServico.BuscarPorAnimal(animal.AnimalID)
                         select new
                         {
                             ID = e.ExameAnimalID,
                             Exame = e.NomeExame,
                             e.DataColeta,
                             e.DataResultado,
                             e.Laboratorio
                         };
            dgv_Exames.DataSource = exames.ToList();
            dgv_Exames.Columns["ID"].Visible = false;
            dgv_Exames.Columns["DataColeta"].HeaderText = "Data da Coleta";
            dgv_Exames.Columns["DataResultado"].HeaderText = "Data do Resultado";
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            new F_NovoExame(animal);
            CarregarExames();
        }

        private void btn_DadosExame_Click(object sender, EventArgs e)
        {
            if( dgv_Exames.RowCount > 0 && dgv_Exames.CurrentRow.Index >= 0)
            {
                var id = long.Parse(dgv_Exames["ID", dgv_Exames.CurrentRow.Index].Value.ToString());
                var exame = exameAnimalServico.BuscarPorID(id);
                f_Principal.AbrirForm(new F_ResumoExame(f_Principal, exame));
            }
            
        }
    }
}
