using Apresentacao.Agendamentos;
using Apresentacao.Buscas;
using Apresentacao.Caixa;
using Apresentacao.Consultas;
using Apresentacao.Registros;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class F_Principal : Form
    {
        Form f_Atual;
        Stack<Form> f_Anterior = new Stack<Form>();


        public F_Principal()
        {
            InitializeComponent();
            lbl_HoraSistema.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToShortTimeString();
            AbrirForm(new F_Agendamento(this));
        }

        public void AbrirForm(Form f)
        {
            if (!(f_Atual is null))
            {
                f_Anterior.Push(f_Atual);
            }
            //f_Atual?.Hide();
            f_Atual = f;
            AbrirnoPanelInicial(f_Atual);
        }

        public void VoltarForm()
        {
            if (f_Anterior.Count > 0)
            {
                f_Atual = f_Anterior.Pop();
                AbrirnoPanelInicial(f_Atual);
            }
        }

        public void AtualizarForm(Form form)
        {           

            
        }

        private void AbrirnoPanelInicial(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_Inicial.Controls.Clear();
            panel_Inicial.Controls.Add(form);
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_RegistroClientes(this));
        }

        private void btn_Consultas_Click(object sender, EventArgs e)
        {
           //AbrirForm(new F_RegistrarConsulta());
        }

        private void btn_ProdutosServicos_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_RegistroProdutosServicos(this));

        }
        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var op = new F_Confirmacao("Deseja Realmente Sair?").Acao;

            if( op == AcaoConfirmacao.Sim)
            {
                Close();
            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_RegistroClientes(this));
        }

        private void produtosEServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_RegistroProdutosServicos(this));
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_RegistroAnimais(this));
        }



        private void veterináriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_RegistroVeterinario(this));
        }

        private void registrarAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_Agendamento(this));
        }

        private void atendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new F_AbrirAtendimento();
        }

        private void timer_RelogioSistema_Tick(object sender, EventArgs e)
        {
            lbl_HoraSistema.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToShortTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contasReceber_toolStripMenuItem_Click(object sender, EventArgs e)
        {
             AbrirForm(new F_ContasReceber(this));
        }
    }
}
