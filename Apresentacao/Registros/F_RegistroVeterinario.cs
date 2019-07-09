using Modelo;
using Servico;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Registros
{
    public partial class F_RegistroVeterinario : F_AbrirForm
    {
        VeterinarioServico veterinarioServico = new VeterinarioServico();
        Veterinario veterinario;

        public F_RegistroVeterinario(F_Principal f_Principal) : base(f_Principal)
        {
            InitializeComponent();
            CarregarVeterinarios();
            btn_Atualizar.Visible = false;
            btn_CancelarAlteracao.Visible = false;
        }

        private void LimparCampos()
        {
            txt_Celular.Clear();
            txt_CPF.Clear();
            txt_DataNascimento.Clear();
            txt_DescricaoCargo.Clear();
            txt_Email.Clear();
            txt_Nome.Clear();
            txt_RG.Clear();
            txt_Telefone.Clear();
        }


        private void CarregarVeterinarios()
        {
            var veterinarios = from v in veterinarioServico.BuscarTodos()
                               select new
                               {
                                   ID = v.VeterinarioID,
                                   v.Nome,
                                   v.CPF,
                                   Registro = v.DataRegistro,
                                   Situação = v.Vinculo
                               };
            dgv_Veterinarios.DataSource = veterinarios.ToList();
            dgv_Veterinarios.Columns["ID"].Visible = false;
        }


        private void GravarDados(Veterinario vet)
        {
            vet.Nome = txt_Nome.Text;
            vet.CPF = txt_CPF.Text;
            vet.Celular = txt_Celular.Text;
            vet.DataNascimento = Convert.ToDateTime(txt_DataNascimento.Text);
            vet.Telefone = txt_Telefone.Text;
            vet.RG = txt_RG.Text;
            vet.Especialidade = txt_DescricaoCargo.Text;
            vet.Email = txt_Email.Text;
        }


        private void btn_RegistrarVeterinario_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new F_Confirmacao("Registrar Veterinário?").Acao;
                if (op == AcaoConfirmacao.Sim)
                {
                    veterinario = new Veterinario();
                    GravarDados(veterinario);
                    veterinarioServico.Registrar(veterinario);
                    new F_TelaDeMensagem("Registrado!");
                    LimparCampos();
                    CarregarVeterinarios();
                }
            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }
        }

        private void btn_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void CarregarDados(Veterinario vet)
        {
            txt_Nome.Text = vet.Nome;
            txt_CPF.Text = vet.CPF;
            txt_Celular.Text = vet.Celular;
            txt_DataNascimento.Text = vet.DataNascimento.ToShortDateString();
            txt_DescricaoCargo.Text = vet.Especialidade;
            txt_Email.Text = vet.Email;
            txt_RG.Text = vet.RG;
            txt_Telefone.Text = vet.Telefone;
        }

        private void btn_AlterarDados_Click(object sender, EventArgs e)
        {
            if (dgv_Veterinarios.RowCount > 0 && dgv_Veterinarios.CurrentRow.Index >= 0)
            {
                var linha = dgv_Veterinarios.CurrentRow.Index;
                var id = long.Parse(dgv_Veterinarios["ID", linha].Value.ToString());
                veterinario = veterinarioServico.BuscarPorID(id);
                CarregarDados(veterinario);
                TrocaBotoes();
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            var op = new F_Confirmacao("Atualizar Dados do Veterinário?").Acao;
            if (op == AcaoConfirmacao.Sim)
            {
                GravarDados(veterinario);
                veterinarioServico.Atualizar(veterinario);
                TrocaBotoes();
                LimparCampos();
            }
        }

        private void btn_CancelarAlteracao_Click(object sender, EventArgs e)
        {
            var op = new F_Confirmacao("Cancelar Alteração?").Acao;
            if (op == AcaoConfirmacao.Sim)
            {
                TrocaBotoes();
                LimparCampos();
            }
        }


        private void btn_VincularVeterinario_Click(object sender, EventArgs e)
        {
            if (dgv_Veterinarios.RowCount > 0 && dgv_Veterinarios.CurrentRow.Index >= 0)
            {
                var op = new F_Confirmacao("Alterar Vinculo?").Acao;
                if (op == AcaoConfirmacao.Sim)
                {
                    var linha = dgv_Veterinarios.CurrentRow.Index;
                    var id = long.Parse(dgv_Veterinarios["ID", linha].Value.ToString());
                    veterinario = veterinarioServico.BuscarPorID(id);
                    veterinario.AlterarVinculo();
                    veterinarioServico.Atualizar(veterinario);
                    new F_TelaDeMensagem("Vinculo Alterado!");
                    CarregarVeterinarios();
                }
            }
        }

        private void btn_VerDados_Click(object sender, EventArgs e)
        {
            if (dgv_Veterinarios.RowCount > 0 && dgv_Veterinarios.CurrentRow.Index >= 0)
            {
                var linha = dgv_Veterinarios.CurrentRow.Index;
                var id = long.Parse(dgv_Veterinarios["ID", linha].Value.ToString());
                veterinario = veterinarioServico.BuscarPorID(id);
                lbl_DadosVeterinario.Text = veterinario.ToString();
            }
        }


        private void TrocaBotoes()
        {
            if (btn_RegistrarVeterinario.Visible == true)
            {
                btn_RegistrarVeterinario.Visible = false;
            }
            else
            {
                btn_RegistrarVeterinario.Visible = true;
            }
            if (btn_CancelarAlteracao.Visible == true)
            {
                btn_CancelarAlteracao.Visible = false;
            }
            else
            {
                btn_CancelarAlteracao.Visible = true;
            }
            if (btn_AlterarDados.Visible == true)
            {
                btn_AlterarDados.Visible = false;
            }
            else
            {
                btn_AlterarDados.Visible = true;
            }
            if (btn_Atualizar.Visible == true)
            {
                btn_Atualizar.Visible = false;
            }
            else
            {
                btn_Atualizar.Visible = true;
            }
            if (btn_LimparCampos.Visible == true)
            {
                btn_LimparCampos.Visible = false;
            }
            else
            {
                btn_LimparCampos.Visible = true;
            }

        }

        private void SoNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}

