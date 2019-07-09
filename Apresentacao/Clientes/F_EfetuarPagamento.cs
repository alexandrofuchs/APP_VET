using Modelo;
using Servico;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Clientes
{
    public partial class F_EfetuarPagamento : Form
    {
        Atendimento atendimento;
        public F_EfetuarPagamento(Atendimento atendimento)
        {
            InitializeComponent();
            this.atendimento = atendimento;
            CarregarDados();
            ShowDialog();
        }

        private void CarregarDados()
        {
            lbl_ValorCliente.Text = atendimento.Animal.Cliente.Nome;
            lbl_ValorCPF.Text = atendimento.Animal.Cliente.CPF;
            lbl_ValorPendente.Text = "R$ " + (atendimento.TotalAtendimento() - atendimento.TotalPago()).ToString("F2", CultureInfo.InvariantCulture);
            var itens = from ip in atendimento.ItemProdutos
                        select new
                        {
                            ip.Nome,
                            ip.Quantidade,
                            ip.Tipo,
                            ip.Custo
                        };
            dgv_Itens.DataSource = itens.ToList();
            dgv_Itens.Columns["Custo"].DefaultCellStyle.Format = "c";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btn_RegistrarPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ValorPagamento.Text) || string.IsNullOrWhiteSpace(txt_ValorPagamento.Text))
                {
                    txt_ValorPagamento.Text = "0,0";
                }
                if( atendimento.Status == Modelo.Enums.StatusPagamento.Paga)
                {
                    throw new Exception("Conta já Quitada!");
                }
                var op = new F_Confirmacao("Registrar Pagamento?").Acao;
                if (op == AcaoConfirmacao.Sim)
                {
                    var pagamentoServico = new PagamentoServico();
                    pagamentoServico.Registrar(new Pagamento
                    {
                        AtendimentoID = atendimento.AtendimentoID,
                        DataHora = DateTime.Now,
                        Valor = double.Parse(txt_ValorPagamento.Text.ToString(CultureInfo.InvariantCulture))
                    });
                    new F_TelaDeMensagem("Pagamento Registrado");
                    Close();
                }

            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }
        }

        private void cb_ValorTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ValorTotal.Checked)
            {
                txt_ValorPagamento.Text = string.Concat(atendimento.TotalAtendimento() - atendimento.TotalPago());
                txt_ValorPagamento.ReadOnly = true;
            }
            else
            {
                txt_ValorPagamento.Clear();
                txt_ValorPagamento.ReadOnly = false;
            }
        }

        private void txt_ValorPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                if(!(e.KeyChar.Equals(',')))
                {
                    e.Handled = true;
                }           
            }
        }
    }
}
