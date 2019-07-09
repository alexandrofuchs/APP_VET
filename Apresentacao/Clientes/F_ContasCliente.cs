using Modelo;
using Servico;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Clientes
{
    public partial class F_ContasCliente : Form
    {
        AtendimentoServico atendimentoServico = new AtendimentoServico();
        Cliente cliente;
        //Atendimento atendimento = new Atendimento();

        public F_ContasCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            CarregarContas();
        }

        private void CarregarContas()
        {
            var contas = from a in atendimentoServico.BuscarPorCliente(cliente.ClienteID)
                         select new
                         {
                             ID = a.AtendimentoID,
                             Animal = a.Animal.Nome,
                             Vencimento = a.DataVencimento.ToShortDateString(),
                             Registro = a.DataRegistro.ToShortDateString(),
                             Total = a.TotalAtendimento(),
                             Pendente = a.TotalAtendimento() - a.TotalPago(),
                             Pago = a.TotalPago(),
                             Situação = a.Status
                         };
            dgv_ContasCliente.DataSource = contas.ToList();
            dgv_ContasCliente.Columns["ID"].Visible = false;
            dgv_ContasCliente.Columns["Pago"].DefaultCellStyle.Format = "c";
            dgv_ContasCliente.Columns["Total"].DefaultCellStyle.Format = "c";
            dgv_ContasCliente.Columns["Pendente"].DefaultCellStyle.Format = "c";            
        }

        private void btn_EfetuarPagamento_Click(object sender, EventArgs e)
        {
            if( dgv_ContasCliente.RowCount > 0 && dgv_ContasCliente.CurrentRow.Index >= 0)
            {
                var linha = dgv_ContasCliente.CurrentRow.Index;
                var id = long.Parse(dgv_ContasCliente["ID", linha].Value.ToString());
                var atendimento = atendimentoServico.BuscarPorID(id);
                if (atendimento is null)
                {
                    throw new Exception("Atendimento não encontrado!");
                }
                new F_EfetuarPagamento(atendimento);
                CarregarContas();
            }            
        }
    }
}
