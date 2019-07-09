using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Animais
{
    public partial class F_ResumoConsulta : Form
    {        
        
        public F_ResumoConsulta(Consulta consulta)
        {
            InitializeComponent();
            CarregarDados(consulta);            
        }

        private void CarregarDados(Consulta consulta)
        {
            var ps = from p in consulta.DadosConsulta
                     select new
                     {
                         p.Dado,
                         Situação = p.Situacao
                     };

            dgv_DadosConsulta.DataSource = ps.ToList();

            
            txt_ExamesMedicamentos.Text = consulta.ExamesSolicitados+"\r\n"+consulta.MedicamentosReceitados;
            txt_PrescricaoMedica.Text = consulta.PrescricaoMedica;
            txt_PrincipaisQueixas.Text = consulta.ProblemasRelatados;
            txt_Sintomas.Text = consulta.SintomasRelatados;
        }

        private void txt_ResumoConsulta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
