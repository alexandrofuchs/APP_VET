using Modelo;
using Servico;
using System;
using System.Windows.Forms;

namespace Apresentacao.Clientes
{
    public partial class F_PaginaCliente : F_AbrirForm
    {
        ClienteServico clienteServico = new ClienteServico();

        Cliente cliente;
        Form f_Atual;

        public F_PaginaCliente(F_Principal f_Principal, Cliente cliente) : base(f_Principal)
        {
            InitializeComponent();
            this.cliente = cliente;
            CarregarDadosCliente();
            AbrirForm(new F_AnimaisCliente(f_Principal, cliente));
        }

        private void AbrirForm(Form form)
        {
            f_Atual?.Close();
            f_Atual = form;
            f_Atual.TopLevel = false;
            f_Atual.FormBorderStyle = FormBorderStyle.None;
            f_Atual.Dock = DockStyle.Fill;
            pnl_Conteudo.Controls.Add(f_Atual);
            f_Atual.Show();
        }

        private void CarregarDadosCliente()
        {
            var c = cliente;
            lbl_ValorNome.Text = c.Nome;
            lbl_ValorCPF.Text = c.CPF;
            lbl_ValorDataRegistro.Text = c.DataRegistro.ToShortDateString();
            lbl_ValorDadosContato.Text = c.Telefone + c.Celular;
        }
        private void btn_DadosCliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_DadosCliente(cliente));
        }

        private void btn_Animais_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_AnimaisCliente(f_Principal, cliente));
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            f_Principal.VoltarForm();
        }

        private void btn_ContasAPagar_Click(object sender, EventArgs e)
        {
            AbrirForm(new F_ContasCliente(cliente));
        }
    }
}
