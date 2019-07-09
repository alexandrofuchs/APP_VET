using Apresentacao.Animais;
using Apresentacao.Buscas;
using Apresentacao.Clientes;
using Servico;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Registros
{
    public partial class F_RegistroAnimais : F_AbrirForm
    {
        AnimalServico animalServico = new AnimalServico();
        ClienteServico clienteServico = new ClienteServico();

        public F_RegistroAnimais(F_Principal f_Principal) : base(f_Principal)
        {
            InitializeComponent();
            CarregarAnimais();
        }

        private void CarregarAnimais()
        {
            var animais = from a in animalServico.BuscarTodos()
                          select new
                          {
                              ID = a.AnimalID,
                              a.Nome,
                              Raça = a.Raca,
                              Espécie = a.Especie,
                              Proprietário = a.Cliente.Nome,
                              ProprietarioID = a.Cliente.ClienteID
                          };
            dgv_AnimaisRegistrados.DataSource = animais.ToList();
            dgv_AnimaisRegistrados.Columns["ID"].Visible = false;
            dgv_AnimaisRegistrados.Columns["ProprietarioID"].Visible = false;

        }

        private void AbrirPaginaAnimal()
        {
            if (dgv_AnimaisRegistrados.RowCount > 0 && dgv_AnimaisRegistrados.CurrentRow.Index >=0)
            {
                var linha = dgv_AnimaisRegistrados.CurrentRow.Index;
                long id = long.Parse(dgv_AnimaisRegistrados["ID", linha].Value.ToString());
                var animal = animalServico.BuscarPorID(id);
                f_Principal.AbrirForm(new F_PaginaAnimal(f_Principal, animal));
            }
        }

        private void btn_PaginaAnimal_Click(object sender, EventArgs e)
        {
            AbrirPaginaAnimal();
        }

        private void btn_PaginaProprietario_Click(object sender, EventArgs e)
        {
            if (dgv_AnimaisRegistrados.RowCount > 0 && dgv_AnimaisRegistrados.CurrentRow.Index >= 0)
            {
                var linha = dgv_AnimaisRegistrados.CurrentRow.Index;
                long id = long.Parse(dgv_AnimaisRegistrados["ProprietarioID", linha].Value.ToString());
                var proprietario = clienteServico.BuscarPorID(id);
                f_Principal.AbrirForm(new F_PaginaCliente(f_Principal, proprietario));
            }
        }

        private void btn_RegistrarAnimal_Click(object sender, EventArgs e)
        {
            new F_BuscarCliente(f_Principal);
            CarregarAnimais();            
        }

        private void dgv_AnimaisRegistrados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_AnimaisRegistrados.RowCount > 0 && e.RowIndex >= 0)
            {
                AbrirPaginaAnimal();
            }            
        }

        private void btn_BuscarAnimal_Click(object sender, EventArgs e)
        {            
            var animais = from a in animalServico.BuscarPorNome(txt_BuscarAnimal.Text)
                          select new
                          {
                              ID = a.AnimalID,
                              a.Nome,
                              Raça = a.Raca,
                              Espécie = a.Especie,
                              Proprietário = a.Cliente.Nome,
                              ProprietarioID = a.Cliente.ClienteID
                          };
            dgv_AnimaisRegistrados.DataSource = animais.ToList();
            dgv_AnimaisRegistrados.Columns["ID"].Visible = false;
            dgv_AnimaisRegistrados.Columns["ProprietarioID"].Visible = false;

        }
    }
}
