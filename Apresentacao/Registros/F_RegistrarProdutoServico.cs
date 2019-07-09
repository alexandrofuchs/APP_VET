using Modelo;
using Servico;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Apresentacao.Registros
{
    public partial class F_RegistrarProdutoServico : Form
    {
        ProdutoServico produtoServico = new ProdutoServico();
 
        public F_RegistrarProdutoServico()
        {
            InitializeComponent();
            ShowDialog();            
        }


        private void btn_RegistrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_Medicamento.Checked)
                {
                    produtoServico.Registrar(
                        new Medicamento()
                        {
                            Nome = txt_Nome.Text,
                            Descricao = txt_Descricao.Text,
                            Custo = Convert.ToDouble(txt_Custo.Text),
                            Sigla = txt_Sigla.Text
                        });
                }
                if (rb_ServicoClinico.Checked)
                {
                    produtoServico.Registrar(
                        new ServicoClinico
                        {
                            Nome = txt_Nome.Text,
                            Custo = Convert.ToDouble(txt_Custo.Text),
                            Descricao = txt_Descricao.Text,
                            Sigla = txt_Sigla.Text
                        });
                }
                if (rb_Exame.Checked)
                {
                    produtoServico.Registrar(
                        new Exame
                        {
                            Nome = txt_Nome.Text,
                            Custo = Convert.ToDouble(txt_Custo.Text),
                            Descricao = txt_Descricao.Text,
                            Sigla = txt_Sigla.Text
                        });
                }
                if (rb_OutrosProdutos.Checked)
                {
                    produtoServico.Registrar(
                        new Produto
                        {
                            Nome = txt_Nome.Text,
                            Custo = Convert.ToDouble(txt_Custo.Text),
                            Descricao = txt_Descricao.Text,
                            Sigla = txt_Sigla.Text
                        });
                }
                new F_TelaDeMensagem("Registrado!");
                LimparCampos();
            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }
        }

        private void LimparCampos()
        {
            txt_Custo.Clear();
            txt_Descricao.Clear();
            txt_Nome.Clear();
            txt_Sigla.Clear();            
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Custo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                if (!(e.KeyChar.Equals(',')))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
