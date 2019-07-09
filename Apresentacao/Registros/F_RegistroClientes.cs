using Apresentacao.Clientes;
using Modelo;
using Servico;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Registros
{
    public partial class F_RegistroClientes : F_AbrirForm
    {
        ClienteServico clienteServico = new ClienteServico();

        public F_RegistroClientes(F_Principal f_Principal) : base(f_Principal)
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            var clientes = from c in clienteServico.BuscarTodos()
                           select new
                           {
                               ID = c.ClienteID,
                               c.Nome,
                               c.CPF,
                               Registro = c.DataRegistro
                           };
            dgv_Clientes.DataSource = clientes.ToList();
            dgv_Clientes.Columns["ID"].Visible = false;
        }

        private void btn_BuscarPorNome_Click(object sender, EventArgs e)
        {
            var clientes = from c in clienteServico.BuscarPorNome(txt_BuscarNome.Text)
                           .OrderBy(c => c.Nome)
                           select new
                           {
                               ID = c.ClienteID,
                               c.Nome,
                               c.CPF,
                               Registro = c.DataRegistro
                           };
            dgv_Clientes.DataSource = clientes.ToList();
            dgv_Clientes.Columns["ID"].Visible = false;
        }

        private void AbrirPaginaCliente(Cliente cli)
        {
            f_Principal.AbrirForm(new F_PaginaCliente(f_Principal, cli));
        }

        private void btn_BuscarCPF_Click(object sender, EventArgs e)
        {
            var cli = clienteServico.BuscarPorCPF(txt_BuscarCPF.Text);

            if (cli is null)
            {
                new F_TelaDeMensagem("Cliente não Encontrado");
            }
            else
            {
                AbrirPaginaCliente(cli);
            }

        }

        private void dgv_Clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Clientes.RowCount > 0 && e.RowIndex >= 0)
            {
                int linha = e.RowIndex;
                long id = long.Parse(dgv_Clientes["ID", linha].Value.ToString());
                var cli = clienteServico.BuscarPorID(id);
                AbrirPaginaCliente(cli);
            }
        }



        private void btn_RegistrarCliente_Click(object sender, EventArgs e)
        {
            new F_RegistrarCliente();
            CarregarClientes();
        }

        private void btn_PaginaDoCliente_Click(object sender, EventArgs e)
        {
            if (dgv_Clientes.RowCount > 0 && dgv_Clientes.CurrentRow.Index >= 0)
            {
                int linha = dgv_Clientes.CurrentRow.Index;

                long id = long.Parse(dgv_Clientes["ID", linha].Value.ToString());

                var cli = clienteServico.BuscarPorID(id);
                AbrirPaginaCliente(cli);
            }

        }
    }
}

