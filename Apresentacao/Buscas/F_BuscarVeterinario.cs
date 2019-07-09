using Apresentacao.Agendamentos;
using Apresentacao.Consultas;
using Modelo;
using Servico;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Buscas
{
    public partial class F_BuscarVeterinario : Form
    {
        VeterinarioServico veterinarioServico = new VeterinarioServico();
        Form form;
        Veterinario veterinario;

        public F_BuscarVeterinario(Form form)
        {
            InitializeComponent();
            CarregarDGV_Veterinarios();
            this.form = form;
            ShowDialog();
        }


        private void CarregarDGV_Veterinarios()
        {
            var veterinarios = from v in veterinarioServico.BuscarVinculados()
                               select new
                               {
                                   ID = v.VeterinarioID,
                                   v.Nome
                               };
            dgv_Veterinarios.DataSource = veterinarios.ToList();
            dgv_Veterinarios.Columns["ID"].Visible = false;
        }

        private void CarregarDVG_ConsultasVeterinario(long id)
        {
            var consultas = from c in veterinarioServico.ConsultasPorVeterinario(id)
                            select new
                            {
                                Data = c.DataConsulta,
                                Animal = c.Animal
                            };
            dgv_Consultas.DataSource = consultas.ToList();
        }

        private void dgv_Veterinarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Veterinarios.RowCount > 0)
            {
                var linha = dgv_Veterinarios.CurrentRow.Index;
                var id = long.Parse(dgv_Veterinarios["ID", linha].Value.ToString());
                CarregarDVG_ConsultasVeterinario(id);
                veterinario = veterinarioServico.BuscarPorID(id);
            }

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (this.veterinario is null)
            {
                new F_TelaDeMensagem("Veterinário não selecionado!");
            }
            else
            {
                if (form is F_AgendarServico)
                {
                    var f = form as F_AgendarServico;
                    f.GetVeterinario(veterinario);
                }
                if (form is F_RegistrarConsulta)
                {
                    var f = form as F_RegistrarConsulta;
                    f.GetVeterinario(veterinario);
                }

                Close();
            }

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_BuscarVeterinario_Click(object sender, EventArgs e)
        {
            var vets = from v in veterinarioServico.BuscarPorNome(txt_BuscarPorNome.Text)
                       select new
                       {
                           ID = v.VeterinarioID,
                           v.Nome
                       };
            dgv_Veterinarios.DataSource = vets.ToList();
        }
    }
}

