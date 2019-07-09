using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Animais
{
    public partial class F_ResumoExame : F_AbrirForm
    {
        ExameAnimal exame;

        public F_ResumoExame(F_Principal f_Principal, ExameAnimal exame)
        {
            InitializeComponent();
            this.f_Principal = f_Principal;
            this.exame = exame;
            CarregarDados();
        }

        private void CarregarDados()
        {
            lbl_ValorExame.Text = exame.NomeExame;
            lbl_ValorDataColeta.Text = exame.DataColeta.ToShortDateString();
            lbl_ValorDataResultado.Text = exame.DataResultado.ToShortDateString();
            lbl_ValorLaboratorio.Text = exame.Laboratorio;
            lbl_ValorAnimal.Text = $"Nome: {exame.Animal.Nome}, Espécie: {exame.Animal.Especie}, Raça: {exame.Animal.Raca}\n" +
                                   $"Idade: {exame.Animal.Idade} anos, Peso: {exame.Animal.Peso}, Sexo: {exame.Animal.Sexo}\n" +
                                   $"Proprietário: {exame.Animal.Cliente.Nome}, CPF: {exame.Animal.Cliente.CPF}";
            lbl_ValorResultadoExame.Text = exame.Resultado;
            lbl_ValorLaudoExame.Text = exame.Laudo;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            f_Principal.VoltarForm();
        }
    }
}
