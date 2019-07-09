using Apresentacao.Animais;
using Apresentacao.Registros;
using Modelo;
using Servico;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Clientes
{ 
    public partial class F_AnimaisCliente : F_AbrirForm
    {
        AnimalServico animalServico = new AnimalServico();
        Cliente cliente;

        public F_AnimaisCliente(F_Principal f_Principal, Cliente cliente) : base(f_Principal)
        {
            InitializeComponent();
            this.cliente = cliente;
            CarregarAnimais();
        }

        private void CarregarAnimais()
        {
            var animais = from a in animalServico.BuscarPorProprietario(cliente.ClienteID)
                          select new
                          {
                              ID = a.AnimalID,
                              a.Nome,
                              Raça = a.Raca,
                              Espécie = a.Especie
                          };
            dgv_Animais.DataSource = animais.ToList();
            dgv_Animais.Columns["ID"].Visible = false;
        }

        private void AbrirPaginaAnimal(long id)
        {
            var animal = animalServico.BuscarPorID(id);
            if (animal is null)
            {
                MessageBox.Show("Animal não encontrado!");
            }
            else
            {
                f_Principal.AbrirForm(new F_PaginaAnimal(f_Principal, animal));
            }
        }
        private void btn_RegistrarAnimal_Click(object sender, EventArgs e)
        {
            new F_RegistrarAnimal(cliente.ClienteID, cliente.Nome);
            CarregarAnimais();
        }

        private void dgv_Animais_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Animais.RowCount > 0 && dgv_Animais.CurrentRow.Index >= 0)
            {
                int linha = e.RowIndex;
                long id = long.Parse(dgv_Animais["ID", linha].Value.ToString());
                AbrirPaginaAnimal(id);
            }
        }

        private void btn_PaginaAnimal_Click(object sender, EventArgs e)
        {
            if(dgv_Animais.RowCount > 0 && dgv_Animais.CurrentRow.Index >= 0 )
            {
                var linha = dgv_Animais.CurrentRow.Index;
                long id = long.Parse(dgv_Animais["ID", linha].Value.ToString());
                AbrirPaginaAnimal(id);
            }
        }
    }
}
