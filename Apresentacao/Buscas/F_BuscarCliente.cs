using Apresentacao.Registros;
using Servico;
using System;
using System.Windows.Forms;

namespace Apresentacao.Buscas
{
    public partial class F_BuscarCliente : Form
    {
        F_Principal f_Principal;

        ClienteServico clienteServico = new ClienteServico();

        public F_BuscarCliente(F_Principal f_Principal)
        {
            InitializeComponent();
            this.f_Principal = f_Principal;
            ShowDialog();
        }

        private void btn_BuscarCPF_Click(object sender, EventArgs e)
        {
            var cliente = clienteServico.BuscarPorCPF(txt_CPF.Text);
            if (cliente is null)
            {
                new F_TelaDeMensagem("Cliente não Encontrado\r\nVerifique o CPF!");
            }
            else
            {
                new F_RegistrarAnimal(cliente.ClienteID, cliente.Nome);
                Close();
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
