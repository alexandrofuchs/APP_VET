using Modelo;
using Servico;
using System;
using System.Windows.Forms;

namespace Apresentacao.Clientes
{
    public partial class F_DadosCliente : Form
    {
        ClienteServico clienteServico = new ClienteServico();
        Cliente cliente;

        public F_DadosCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            CarregarDadosCliente();
        }

        private void CarregarDadosCliente()
        {
            var c = cliente;
            txt_Nome.Text = c.Nome;
            txt_CPF.Text = c.CPF;
            txt_DataNascimento.Text = c.DataNascimento.ToShortDateString();
            txt_RG.Text = c.RG;
            txt_Telefone.Text = c.Telefone;
            txt_Celular.Text = c.Celular;
            txt_Cidade.Text = c.Cidade;
            txt_Endereco.Text = c.Endereco;
            txt_Bairro.Text = c.Bairro;
            txt_Estado.Text = c.Estado;
            txt_NumeroResidencia.Text = c.NumeroResidencia;
        }
        
        private void btn_AtualizarDados_Click(object sender, EventArgs e)
        {
            try
            {                
                if (cliente is null)
                {
                    new F_TelaDeMensagem("Cliente não Encontrado!");
                }
                else
                {
                    cliente.Nome = txt_Nome.Text;
                    cliente.CPF = txt_CPF.Text;
                    cliente.DataNascimento = Convert.ToDateTime(txt_DataNascimento.Text);
                    cliente.Cidade = txt_Cidade.Text;
                    cliente.Celular = txt_Celular.Text;
                    cliente.Endereco = txt_Endereco.Text;
                    cliente.Estado = txt_Estado.Text;
                    cliente.RG = txt_RG.Text;
                    cliente.Telefone = txt_Telefone.Text;
                    cliente.Bairro = txt_Bairro.Text;
                    cliente.Estado = txt_Estado.Text;
                    clienteServico.Atualizar(cliente);
                    new F_TelaDeMensagem("Atualizado Com Sucesso");
                }
            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }
        }

        private void btn_RestaurarDados_Click(object sender, EventArgs e)
        {
            CarregarDadosCliente();
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
