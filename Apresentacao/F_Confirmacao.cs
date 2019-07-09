using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class F_Confirmacao : Form
    {
        private AcaoConfirmacao acao;

        public AcaoConfirmacao Acao
        {
            get { return acao; }
        }

        public F_Confirmacao(string mensagem)
        {
            InitializeComponent();
            lbl_Mensagem.Text = mensagem;
            ShowDialog();
        }

        private void btn_Nao_Click(object sender, EventArgs e)
        {
            acao = AcaoConfirmacao.Não;
            Close();
        }

        private void btn_Sim_Click(object sender, EventArgs e)
        {
            acao = AcaoConfirmacao.Sim;
            Close();
        }
    }
}
