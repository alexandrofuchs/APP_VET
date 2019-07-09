using System.Windows.Forms;

namespace Apresentacao
{
    public partial class F_AbrirForm : Form
    {
        protected F_Principal f_Principal;

        public F_AbrirForm()
        {
            InitializeComponent();
        }


        public F_AbrirForm(F_Principal f_Principal)
        {
            this.f_Principal = f_Principal;
        }
    }
}
