using Modelo;
using Servico;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Apresentacao.Registros
{
    public partial class F_AtualizarProduto : Form
    {
        ProdutoServico produtoServico = new ProdutoServico();
        Produto produto;

        public F_AtualizarProduto(Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
            txt_Nome.Text = produto.Nome;
            txt_Sigla.Text = produto.Sigla;
            txt_Descricao.Text = produto.Descricao;
            txt_Custo.Text = produto.Custo.ToString("F2");
            ShowDialog();
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new F_Confirmacao("Atualizar Dados? ").Acao;
                if (op == AcaoConfirmacao.Sim)
                {
                    produto.Nome = txt_Nome.Text;
                    produto.Sigla = txt_Sigla.Text;
                    produto.Custo = Convert.ToDouble(txt_Custo.Text.ToString(CultureInfo.InvariantCulture));
                    produto.Descricao = txt_Descricao.Text;
                    produtoServico.Atualizar(produto);
                    new F_TelaDeMensagem("Atualizado!");
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

        private void SomenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
