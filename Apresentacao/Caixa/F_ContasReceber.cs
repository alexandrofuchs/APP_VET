using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Caixa
{
    public partial class F_ContasReceber : F_AbrirForm
    {
        List<string> meses = new List<string>
        {
            "[selecione]",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"
        };


        PagamentoServico pagamentoServico = new PagamentoServico();
        AtendimentoServico atendimentoServico = new AtendimentoServico();

        public F_ContasReceber(F_Principal f_Principal) : base(f_Principal)
        {
            InitializeComponent();
            cmb_Mes.DataSource = meses;
            CarregarDados(DateTime.Today, DateTime.Today);
        }


        private void CarregarDados(DateTime inicio, DateTime final)
        {
            var atendimentos = atendimentoServico.BuscarEntreDatas(inicio, final).ToList();

            List<ItemProduto> items = new List<ItemProduto>();

            foreach (var a in atendimentos)
            {
                items.AddRange(a.ItemProdutos);
            }
            var itensProdutos = from ip in items
                                select new
                                {
                                    Produto = ip.Nome,
                                    Quantidade = ip.Quantidade,
                                    Custo = ip.Custo,
                                    Total = ip.Custo * ip.Quantidade
                                };
            dgv_ItensProduto.DataSource = itensProdutos.ToList();
            dgv_ItensProduto.Columns["Custo"].DefaultCellStyle.Format = "c";
            dgv_ItensProduto.Columns["Total"].DefaultCellStyle.Format = "c";

            lbl_ValorGastos.Text = "R$ " + items.Sum(ip => ip.Quantidade * ip.Custo).ToString("F2", CultureInfo.InvariantCulture);


            var pagamentos = from p in pagamentoServico.BuscarEntreDatas(inicio, final)
                             select new
                             {
                                 p.Valor,
                                 Cliente = p.Atendimento.Animal.Cliente.Nome,
                                 p.Atendimento.Animal.Cliente.CPF
                             };
            dgv_Recebimentos.DataSource = pagamentos.ToList();
            dgv_Recebimentos.Columns["Valor"].DefaultCellStyle.Format = "c";

            lbl_ValorTotal.Text = "R$ " + pagamentos.Sum(p => p.Valor).ToString("F2", CultureInfo.InvariantCulture);
            lbl_ValorTotalCaixa.Text = "R$ " + (pagamentos.Sum(p => p.Valor) -items.Sum(ip => ip.Quantidade * ip.Custo)).ToString("F2", CultureInfo.InvariantCulture);
        }

        private void monthCalendar_DiasRecebimento_DateSelected(object sender, DateRangeEventArgs e)
        {
            var inicio = monthCalendar_DiasRecebimento.SelectionStart;
            var final = monthCalendar_DiasRecebimento.SelectionEnd;
            CarregarDados(inicio, final);
        }

        private void cmb_Mes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarPorMes(cmb_Mes.SelectedIndex);
        }

        private void BuscarPorMes(int mes)
        {
            var pagamentos = from p in pagamentoServico.BuscarPorMes(mes)
                             select new
                             {
                                 p.Valor,
                                 Cliente = p.Atendimento.Animal.Cliente.Nome,
                                 p.Atendimento.Animal.Cliente.CPF
                             };
            dgv_Recebimentos.DataSource = pagamentos.ToList();
            dgv_Recebimentos.Columns["Valor"].DefaultCellStyle.Format = "c";
            

            var atendimentos = atendimentoServico.BuscarPorMes(mes).ToList();

            List<ItemProduto> items = new List<ItemProduto>();

            foreach (var a in atendimentos)
            {
                items.AddRange(a.ItemProdutos);
            }
            var itensProdutos = from ip in items
                                select new
                                {
                                    Produto = ip.Nome,
                                    Quantidade = ip.Quantidade,
                                    Custo = ip.Custo,
                                    Total = ip.Custo * ip.Quantidade
                                };
            dgv_ItensProduto.DataSource = itensProdutos.ToList();
            dgv_ItensProduto.Columns["Custo"].DefaultCellStyle.Format = "c";
            dgv_ItensProduto.Columns["Total"].DefaultCellStyle.Format = "c";

            lbl_ValorTotal.Text = "R$ " + pagamentos.Sum(p => p.Valor).ToString("F2", CultureInfo.InvariantCulture);
            lbl_ValorGastos.Text = "R$ " + items.Sum(ip => ip.Quantidade * ip.Custo).ToString("F2", CultureInfo.InvariantCulture);
            lbl_ValorTotalCaixa.Text = "R$ " + (pagamentos.Sum(p => p.Valor) - items.Sum(ip => ip.Quantidade * ip.Custo)).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

