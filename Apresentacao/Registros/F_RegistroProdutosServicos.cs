using Servico;
using System.Linq;

namespace Apresentacao.Registros
{
    public partial class F_RegistroProdutosServicos : F_AbrirForm
    {
        ProdutoServico produtoServico = new ProdutoServico();

        public F_RegistroProdutosServicos(F_Principal f_Principal) : base(f_Principal)
        {
            InitializeComponent();
            CarregarProdutos();
            CarregarTipos();
        }

        private void CarregarProdutos()
        {
            var produtos = from p in produtoServico.BuscarTodos()
                           select new
                           {
                               ID = p.ProdutoID,
                               p.Nome,
                               p.Sigla,
                               Tipo = p.GetType().Name,
                               p.Custo,
                               Registro = p.DataRegistro
                           };
            dgv_ProdutosServicos.DataSource = produtos.ToList();
            dgv_ProdutosServicos.Columns["ID"].Visible = false;
            dgv_ProdutosServicos.Columns["Custo"].DefaultCellStyle.Format = "c";
        }

        private void CarregarTipos()
        {
            var tipos = from t in produtoServico.BuscarTodos()
                        select new
                        {
                            Tipo = t.GetType().Name
                        };
            var tps = tipos.Distinct();
            cmb_Tipo.DataSource = tps.ToList();
            cmb_Tipo.DisplayMember = "Tipo";
            cmb_Tipo.ValueMember = "Tipo";
        }

        private void CarregarProdutoPorTipo(string tipo)
        {
            var produtos = from p in produtoServico.BuscarPorTipo(tipo)
                           select new
                           {
                               ID = p.ProdutoID,
                               p.Nome,
                               p.Sigla,
                               Tipo = p.GetType().Name,
                               p.Custo,
                               Registro = p.DataRegistro
                           };
            dgv_ProdutosServicos.DataSource = produtos.ToList();
            dgv_ProdutosServicos.Columns["ID"].Visible = false;
            dgv_ProdutosServicos.Columns["Custo"].DefaultCellStyle.Format = "c";
        }

        private void btn_RegistrarProdutoServico_Click(object sender, System.EventArgs e)
        {
            new F_RegistrarProdutoServico();
            CarregarProdutos();
            CarregarTipos();
        }

        private void btn_Remover_Click(object sender, System.EventArgs e)
        {

            if (dgv_ProdutosServicos.RowCount > 0 && dgv_ProdutosServicos.CurrentRow.Index >= 0)
            {
                var op = new F_Confirmacao("Deseja Remover esse Produto?").Acao;
                if (op == AcaoConfirmacao.Sim)
                {
                    var linha = dgv_ProdutosServicos.CurrentRow.Index;
                    var id = long.Parse(dgv_ProdutosServicos["ID", linha].Value.ToString());
                    var produto = produtoServico.BuscarPorID(id);
                    produtoServico.Remover(produto);
                    CarregarProdutos();
                }
            }
        }

        private void cmb_Tipo_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            var tipo = cmb_Tipo.SelectedValue.ToString();
            CarregarProdutoPorTipo(tipo);
        }

        private void btn_BuscarPorNome_Click(object sender, System.EventArgs e)
        {
            var produtos = from p in produtoServico.BuscarPorNome(txt_BuscarPorNome.Text)
                           select new
                           {
                               ID = p.ProdutoID,
                               p.Nome,
                               p.Sigla,
                               Tipo = p.GetType().Name,
                               p.Custo,
                               Registro = p.DataRegistro
                           };
            dgv_ProdutosServicos.DataSource = produtos.ToList();
            dgv_ProdutosServicos.Columns["ID"].Visible = false;
            dgv_ProdutosServicos.Columns["Custo"].DefaultCellStyle.Format = "c";
        }

        private void btn_Alterar_Click(object sender, System.EventArgs e)
        {

            if (dgv_ProdutosServicos.RowCount > 0 && dgv_ProdutosServicos.CurrentRow.Index >= 0)
            {
                var linha = dgv_ProdutosServicos.CurrentRow.Index;
                var id = long.Parse(dgv_ProdutosServicos["ID", linha].Value.ToString());
                var produto = produtoServico.BuscarPorID(id);
                new F_AtualizarProduto(produto);
                CarregarProdutos();
            }
        }
    }
}
