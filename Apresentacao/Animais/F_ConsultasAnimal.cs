using Modelo;
using Servico;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Animais
{
    public partial class F_ConsultasAnimal : Form
    {
        F_PaginaAnimal f_PaginaAnimal;
        Animal animal;
        ConsultaServico consultaServico = new ConsultaServico();

        public F_ConsultasAnimal(F_PaginaAnimal f_PaginaAnimal, Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
            this.f_PaginaAnimal = f_PaginaAnimal;
            CarregarConsultas();
        }
        public void CarregarConsultas()
        {
            var consultas = from c in consultaServico.BuscarPorAnimal(animal.AnimalID)
                            select new
                            {
                                ID = c.ConsultaID,
                                Data = c.DataConsulta,
                                Veterinario = c.Veterinario.Nome
                            };
            dgv_ConsultasRealizadas.DataSource = consultas.ToList();
            dgv_ConsultasRealizadas.Columns["ID"].Visible = false;

        }

        private void btn_VerDetalhesConsulta_Click(object sender, System.EventArgs e)
        {
            if( dgv_ConsultasRealizadas.RowCount > 0 && dgv_ConsultasRealizadas.CurrentRow.Index >= 0)
            {
                var linha = dgv_ConsultasRealizadas.CurrentRow.Index;
                var id = long.Parse(dgv_ConsultasRealizadas["ID", linha].Value.ToString());
                var consulta = consultaServico.BuscarPorID(id);
                f_PaginaAnimal.AbrirForm(new F_ResumoConsulta(consulta));
            }

        }
    }
}
