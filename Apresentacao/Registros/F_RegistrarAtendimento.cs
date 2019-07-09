using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Registros
{
    public partial class F_RegistrarAtendimento : Form
    {
        Animal animal;
        Atendimento atendimento;
        ProdutoServico produtoServico = new ProdutoServico();

        public F_RegistrarAtendimento(Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
            atendimento = new Atendimento
            {
                AnimalID = animal.AnimalID
            };
            CarregarProdutos();
            ClassificarPor();
            CarregarCampos();
            AtualizarCampos();
            ShowDialog();
        }

        private void CarregarCampos()
        {
            lbl_ValorAnimal.Text = animal.Nome;
            lbl_ValorProprietario.Text = animal.Cliente.Nome;
            lbl_ValorCPF.Text = animal.Cliente.CPF;
            lbl_ValorTelefone.Text = animal.Cliente.Telefone;
            lbl_ValorCelular.Text = animal.Cliente.Celular;
        }

        private void AtualizarCampos()
        {
            lbl_ValorTotal.Text = "R$ " + atendimento.TotalAtendimento().ToString("F2", CultureInfo.InvariantCulture);
            lbl_ValorTotalExames.Text = "R$ " + atendimento.TotalExames().ToString("F2", CultureInfo.InvariantCulture);
            lbl_ValorTotalMedicamentos.Text = "R$ " + atendimento.TotalMedicamentos().ToString("F2", CultureInfo.InvariantCulture);
            lbl_ValorTotalServicos.Text = "R$ " + atendimento.TotalServicos().ToString("F2", CultureInfo.InvariantCulture);
            lbl_ValorTotalOutros.Text = "R$ " + atendimento.TotalOutrosProdutos().ToString("F2", CultureInfo.InvariantCulture);
        }

        private void CarregarProdutos()
        {
            var produtos = from p in produtoServico.BuscarTodos()
                           select new
                           {
                               ID = p.ProdutoID,
                               p.Nome,
                               p.Custo,
                               Tipo = p.GetType().Name
                           };
            dgv_ProdutosServicos.DataSource = produtos.ToList();
            dgv_ProdutosServicos.Columns["Custo"].DefaultCellStyle.Format = "c";
            dgv_ProdutosServicos.Columns["ID"].Visible = false;
        }

        private void ClassificarPor()
        {
            var tipos = from t in produtoServico.BuscarTodos().Distinct()
                        select new
                        {
                            Tipo = t.GetType().Name
                        };
            var tps = tipos.Distinct();
            cmb_ClassificarPor.DataSource = tps.ToList();
            cmb_ClassificarPor.DisplayMember = "Tipo";
            cmb_ClassificarPor.ValueMember = "Tipo";
        }

        private void BuscarPorTipo(string tipo)
        {
            var produtos = from p in produtoServico.BuscarPorTipo(tipo)
                           select new
                           {
                               ID = p.ProdutoID,
                               p.Nome,
                               p.Custo,
                               Tipo = p.GetType().Name
                           };
            dgv_ProdutosServicos.DataSource = produtos.ToList();
            dgv_ProdutosServicos.Columns["Custo"].DefaultCellStyle.Format = "c";
            dgv_ProdutosServicos.Columns["ID"].Visible = false;
        }

        private void AtualizarProdutosAdicionados()
        {
            var produtos = from ip in atendimento.ItemProdutos
                           select new
                           {
                               ip.Nome,
                               ip.Quantidade,
                               ip.Custo,
                               ip.Tipo,
                           };

            dgv_ProdutosAdicionados.DataSource = produtos.ToList();
            dgv_ProdutosAdicionados.Columns["Custo"].DefaultCellStyle.Format = "c";
            AtualizarCampos();
        }

        private void cmb_ClassificarPor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarPorTipo(cmb_ClassificarPor.SelectedValue.ToString());
        }

        private void btn_AdicionarProduto_Click(object sender, EventArgs e)
        {
            if (dgv_ProdutosServicos.RowCount > 0 && dgv_ProdutosServicos.CurrentRow.Index >= 0)
            {
                var linha = dgv_ProdutosServicos.CurrentRow.Index;
                var id = long.Parse(dgv_ProdutosServicos["ID", linha].Value.ToString());
                var produto = produtoServico.BuscarPorID(id);
                if (produto is null)
                {
                    throw new Exception("Erro ao adicionar Produto");
                }
                atendimento.AdicionarItemProduto(produto.Nome,
                                                 produto.Custo,
                                                 Convert.ToInt32(txt_Quantidade.Text),
                                                 produto.GetType().Name);
                AtualizarProdutosAdicionados();
                txt_Quantidade.Value = 1;
            }
             
        }

        private void btn_RemoverProduto_Click(object sender, EventArgs e)
        {
            if (dgv_ProdutosAdicionados.RowCount > 0 && dgv_ProdutosAdicionados.CurrentRow.Index >=0)
            {
                var linha = dgv_ProdutosAdicionados.CurrentRow.Index;
                var nome = dgv_ProdutosAdicionados["Nome", linha].Value.ToString();
                atendimento.RemoverItemProduto(nome);
                AtualizarProdutosAdicionados();
            }
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new F_Confirmacao("Registrar Atendimento? ").Acao;
                if (op == AcaoConfirmacao.Sim)
                {
                    if (cb_Pago.Checked)
                    {
                        atendimento.EfetuarPagamento(new Pagamento
                        {
                            DataHora = DateTime.Now,
                            AtendimentoID = atendimento.AtendimentoID,
                            Valor = atendimento.TotalAtendimento()
                        });
                    }
                    else
                    {
                        atendimento.DataVencimento = atendimento.DataRegistro.AddDays(int.Parse(txt_DiasVencimento.Value.ToString()));
                    }
                    var atendimentoServico = new AtendimentoServico();
                    atendimentoServico.Registrar(atendimento);
                    new F_TelaDeMensagem("Atendimento Registrado!");

                    Close();
                }
            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_BuscarProduto_Click(object sender, EventArgs e)
        {
            var produtos = from p in produtoServico.BuscarPorNome(txt_BuscarProduto.Text)
                           select new
                           {
                               ID = p.ProdutoID,
                               p.Nome,
                               p.Custo,
                               Tipo = p.GetType().Name
                           };
            dgv_ProdutosServicos.DataSource = produtos.ToList();
            dgv_ProdutosServicos.Columns["Custo"].DefaultCellStyle.Format = "c";
            dgv_ProdutosServicos.Columns["ID"].Visible = false;
        }
    }
}

