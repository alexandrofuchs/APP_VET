using Modelo;
using Servico;
using System;
using System.Windows.Forms;

namespace Apresentacao.Registros
{
    public partial class F_RegistrarCliente : Form
    {
        ClienteServico clienteServico = new ClienteServico();

        public F_RegistrarCliente()
        { 
            InitializeComponent();
            ShowDialog();
        }
               
        private void btn_RegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                clienteServico.Registrar(
                    new Cliente()
                    {
                        Nome = txt_Nome.Text,
                        CPF = txt_CPF.Text,
                        DataNascimento = Convert.ToDateTime(txt_DataNascimento.Text),
                        Cidade = txt_Cidade.Text,
                        Celular = txt_Celular.Text,
                        Endereco = txt_Endereco.Text,
                        Estado = txt_Estado.Text,
                        RG = txt_RG.Text,
                        Telefone = txt_Telefone.Text,
                        Bairro = txt_Bairro.Text,
                        NumeroResidencia = txt_NumeroCasa.Text
                    });
                
                new F_TelaDeMensagem("Registrado");
                Close();
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

        private void LimparCampos()
        {
            txt_Bairro.Clear();
            txt_Celular.Clear();
            txt_Cidade.Clear();
            txt_CPF.Clear();
            txt_DataNascimento.Clear();
            txt_Endereco.Clear();
            txt_Estado.Clear();
            txt_Nome.Clear();
            txt_NumeroCasa.Clear();
            txt_RG.Clear();
            txt_Telefone.Clear();
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