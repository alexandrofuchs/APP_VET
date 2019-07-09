using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class F_TelaDeMensagem : Form
    {
        public F_TelaDeMensagem(string mensagem)
        {
            InitializeComponent();
            lbl_Mensagem.Text = mensagem;
            ShowDialog();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
